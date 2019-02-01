using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SPYROtalks.Shared
{
    public abstract class BaseApiService
    {
        protected readonly Uri ApiUri;

        protected BaseApiService(string apiUrl)
        {
            ApiUri = new Uri(apiUrl);
        }

        protected async Task<T> GetAsync<T>(string path) where T : class
        {
            var http = HttpMethod.Get;

            var method = http.ToString();

            var request = new HttpRequestMessage();
            request.RequestUri = ParseRequestUri(path);
            request.Method = http;

            var client = new HttpClient();
            var result = await client.SendAsync(request,
                                HttpCompletionOption.ResponseContentRead,
                                default(CancellationToken));

            if (result.IsSuccessStatusCode)
            {
                string json = await result.Content.ReadAsStringAsync();
                var payload = DeserializeJson<T>(json);

                if (payload != null)
                {
                    return payload;
                }
            }
            throw new Exception(result.StatusCode.ToString());
        }

        private Uri ParseRequestUri(string path)
        {
            return new Uri(ApiUri, path);
        }

        protected T DeserializeJson<T>(string json)
        {
            var jsonSerializer = new JsonSerializerSettings
            {
                ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
                TypeNameHandling = TypeNameHandling.None,
                DateParseHandling = DateParseHandling.DateTimeOffset,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };

            return JsonConvert.DeserializeObject<T>(json, jsonSerializer);
        }
    }
}
