using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net.Mime;
using Newtonsoft.Json;

namespace classes
{
    internal class YandexAuthToken
    {
        HttpClient client = new HttpClient();

        public async Task<iamTokenResult> getIamToken(string yandexPassportOauthToken)
        {

            string content = $"{{\"yandexPassportOauthToken\":\"{yandexPassportOauthToken}\"}}";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://iam.api.cloud.yandex.net/iam/v1/tokens");

            request.Content = new StringContent(content);

            request.Content.Headers.ContentType = new MediaTypeHeaderValue("Application/json");

            HttpResponseMessage response = await client.SendAsync(request);

            //response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return ParseIamTokenResult(responseBody);

        }

        public iamTokenResult ParseIamTokenResult(string json)
        {
            return JsonConvert.DeserializeObject<iamTokenResult>(json);
        }

        internal class iamTokenResult
        {
            // successfully:
            public string iamToken;
            public string expiresAt;

            // error:
            public string code;
            public string message;
        }
    }
}
