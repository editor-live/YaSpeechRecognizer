using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.Extensions.Logging;
using Speechkit.Stt.V3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using classes;

namespace classes
{
    internal class YandexRecognizer
    {
 
        /// <summary>Канал обмена сообщениями;</summary>
        GrpcChannel _channel = null;

        /// <summary>Клиент;</summary>
        Recognizer.RecognizerClient _client = null;

        CancellationTokenSource _tokenSource = null;
        //AsyncDuplexStreamingCall<StreamingRequest, StreamingResponse> call = null;
        IClientStreamWriter<StreamingRequest> _request;
        IAsyncStreamReader<StreamingResponse> _response;

        Task _readerTask = null;

        private Exception _readerException = null;


        AutoResetEvent _recognizedEvent;

        private string _result = null;

        ILoggerFactory _loggerFactory;

        ILogger _logger;

        public int StartCount { get; private set; } = 0;

        public YandexRecognizer(ILoggerFactory loggerFactory)
        {
            if(loggerFactory == null) throw new NullReferenceException(nameof(loggerFactory));
            _loggerFactory = loggerFactory;
            _logger = loggerFactory.CreateLogger(this.GetType().Name);
        }

        //public void StopService()
        //{
        //    //await _channel.ShutdownAsync();
        //    try
        //    {
        //        _channel.Dispose();
        //        _tokenSource.Cancel();
        //    } catch { }
        //}

        private void StartService(string iamToken, string folderId)
        {
            StartCount++;
            
            _logger.LogInformation("starting service");

            GrpcChannelOptions _channelOptions = new GrpcChannelOptions();// { LoggerFactory = _loggerFactory };
            
            // Cоздаем канал для обмена сообщениями с сервером (параметр - адрес сервера gRPC и настройки канала);
            _channel = GrpcChannel.ForAddress("https://stt.api.cloud.yandex.net:443", _channelOptions);
            _client = new Recognizer.RecognizerClient(_channel);
            
            var call = _client.RecognizeStreaming(headers: GetMetadata(iamToken, folderId), deadline: DateTime.UtcNow.AddMinutes(5));
            
            _request = call.RequestStream;

            _response = call.ResponseStream;

            _request.WriteAsync(GetStreamingRequestOptions()).Wait(); // Отправляем серверу опции распознования;

            _recognizedEvent = new AutoResetEvent(false);

            //var headers = await call.ResponseHeadersAsync;
            _tokenSource = new CancellationTokenSource();

            if (_readerTask == null)
            {
                _readerException = null;
                _readerTask = Task.Run(() => ReadRecognize(_response));
            }

            _logger.LogInformation("service started");
        }

        /// <summary>
        /// Может вызывать исключения!;
        /// </summary>
        /// <param name="audioData">Аудио данные;</param>
        /// <param name="iamToken">Token доступа;</param>
        /// <param name="folderId">Индикатор каталога;</param>
        /// <returns></returns>
        public string Recognize(byte[] audioData, string iamToken, string folderId)
        {
            _result = null;

            if (_readerTask == null) StartService(iamToken, folderId);

            if (_request == null || _recognizedEvent == null) return null; // Проверка, запущен ли сервис;

            StreamingRequest audio = new StreamingRequest()
            {
                Chunk = new AudioChunk()
                {
                    Data = Google.Protobuf.ByteString.CopyFrom(audioData)
                }
            };

            _logger.LogInformation("sending audio data...");

            _request.WriteAsync(audio).Wait(); // Отправляем серверу аудио данные;

            // Запрос на завершение текущего речевого фрагмента;
            StreamingRequest eou = new StreamingRequest() { Eou = new Eou() };
            _request.WriteAsync(eou).Wait(); // Сообщаем о окончании аудио;

            _logger.LogInformation("waiting recognize result");       

            _recognizedEvent.WaitOne(TimeSpan.FromSeconds(3));

            if (_readerException != null) throw new Exception("RecognizeReaderError", _readerException);

            _logger.LogInformation($"recognize result: {_result}");

            return _result;
        }

        private async void ReadRecognize(IAsyncStreamReader<StreamingResponse> reader)
        {
            // Без этих переменных нет смысла запускать сервис;
            if (reader == null || _tokenSource == null || _recognizedEvent == null) return;

            CancellationToken cancel = _tokenSource.Token;
            try
            {
                while (await reader.MoveNext(cancel))
                {
                    StreamingResponse result = reader.Current;

                    if (result.EventCase == StreamingResponse.EventOneofCase.FinalRefinement)
                    {
                        _logger.LogTrace($"РЕЗУЛЬТАТ ОБРАБОТКИ:{result.FinalRefinement.NormalizedText.Alternatives[0].Text}");
                        //Console.WriteLine($"РЕЗУЛЬТАТ ОБРАБОТКИ:{result.FinalRefinement.NormalizedText.Alternatives[0].Text}");
                        // Разорвем соединение после получения ответа?
                        //await channel.ShutdownAsync();
                        //channel.Dispose();
                        //_tokenSource.Cancel();
                        _result = result.FinalRefinement.NormalizedText.Alternatives[0].Text;
                        _recognizedEvent.Set();
                    }

                    //if(result.EventCase == StreamingResponse.EventOneofCase.StatusCode)
                    //{
                        
                    //}
                    //Console.WriteLine(result.ToString());
                    //Console.WriteLine(result.EventCase);
                    //await Task.Delay(1000);
                }
            } catch (RpcException ex) when (ex.StatusCode == Grpc.Core.StatusCode.Cancelled) { }
            catch (Exception e) 
            { 
                _readerException = e;
                _logger.LogError(e, "reader task error");
                _recognizedEvent.Set();      
            }
            _readerTask = null;
        }


        private StreamingRequest GetStreamingRequestOptions()
        {
            // Настройки первого запроса;
            return  new StreamingRequest()
            {

                SessionOptions = new StreamingOptions()
                {
                    RecognitionModel = new RecognitionModelOptions()
                    {
                        Model = "general",
                        AudioFormat = new AudioFormatOptions() // Настройка аудио данных;
                        {
                            RawAudio = new RawAudio() // Данные будут поступать в RAW (чистом) формате;
                            {
                                AudioChannelCount = 1,
                                AudioEncoding = RawAudio.Types.AudioEncoding.Linear16Pcm,
                                SampleRateHertz = 22050
                            }
                        },
                        TextNormalization = new TextNormalizationOptions() // Настройка нормализатора текста, в том числе и пунктуатора;
                        {
                            TextNormalization = TextNormalizationOptions.Types.TextNormalization.Enabled,
                            PhoneFormattingMode = TextNormalizationOptions.Types.PhoneFormattingMode.Disabled,
                            ProfanityFilter = false, // Цензура;
                            LiteratureText = true, // Эта настройка позволяет расставлять знаки препинания;
                        },
                        LanguageRestriction = new LanguageRestrictionOptions()
                        {
                            RestrictionType = LanguageRestrictionOptions.Types.LanguageRestrictionType.Whitelist,
                            //LanguageCode = "ru-RU" // Здесь нужно выбирать на каких языках распознавать речь;
                        },
                        AudioProcessingType = RecognitionModelOptions.Types.AudioProcessingType.FullData // Настройка распознавания речи только после полного приема данных;
                    },
                    // Настройка ручного завершения речевого фрагмента;
                    EouClassifier = new EouClassifierOptions() { ExternalClassifier = new ExternalEouClassifier() }
                }
            };
        }

        protected Metadata GetMetadata(string iam, string folderId)
        {
            Metadata serviceMetadata = new Metadata();
            serviceMetadata.Add("authorization", $"Bearer {iam}");
            serviceMetadata.Add("x-folder-id", folderId);
            serviceMetadata.Add("x-data-logging-enabled", "true");
            String requestId = Guid.NewGuid().ToString();
            serviceMetadata.Add("x-client-request-id", requestId); // Уникальный идентификатор запроса;
            Console.WriteLine($"Metadata configured for request: {requestId}");
            return serviceMetadata;
        }
    }
}
