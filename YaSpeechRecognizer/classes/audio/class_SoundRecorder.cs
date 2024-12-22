using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Threading;

namespace classes
{
    internal class SoundRecorder
    {
        // WaveIn - поток для записи
        WaveIn waveIn;
        //Класс для записи в файл
        WaveFileWriter writer;

        MemoryStream _outStream = null;
        // Примерно расчитанное время последней записи;
        TimeSpan _outStreamSoundTime = TimeSpan.Zero;

        // Получение данных из входного буфера;
        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            // Записываем данные в буффер;
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        // Окончание записи;
        private void WaveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            waveIn.Dispose();
            waveIn = null;
            // Не стоит его уничтожать наверное...;
            writer.Close();
            writer = null;
        }

        public MemoryStream StopStreamRecording()
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
#warning проверить будут ли списывать деньги если флашеть буффер!!!
                writer.Flush();
                _outStream.Seek(0, SeekOrigin.Begin);
                _outStreamSoundTime = writer.TotalTime;

                // Будем возвращать новый поток, чтобы не было проблем с очищением буфера;
                return new MemoryStream(_outStream.ToArray());
            }
            return null;
        }

        /// <summary>Получает примерно расчитанное время последней записи;</summary>
        public TimeSpan LastRecordedSoundTime => _outStreamSoundTime;

        //Начинаем запись - обработчик нажатия кнопки
        public void StartRecordingStream()
        {
            try
            {
                waveIn = new WaveIn();
                //Дефолтное устройство для записи (если оно имеется)
                //встроенный микрофон ноутбука имеет номер 0
                waveIn.DeviceNumber = 0;
                //Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                waveIn.DataAvailable += waveIn_DataAvailable;
                //Прикрепляем обработчик завершения записи
                waveIn.RecordingStopped += WaveIn_RecordingStopped;
                //Формат wav-файла - принимает параметры - частоту дискретизации и количество каналов(здесь mono)
                waveIn.WaveFormat = new WaveFormat(22050, 16, 1);
                _outStream = new MemoryStream();
                _outStreamSoundTime = TimeSpan.Zero;
                //Инициализируем объект WaveFileWriter
                writer = new WaveFileWriter(_outStream, waveIn.WaveFormat);
                //Начало записи
                waveIn.StartRecording();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
