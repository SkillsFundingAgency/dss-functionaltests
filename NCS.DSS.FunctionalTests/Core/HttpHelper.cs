using Newtonsoft.Json;
using Polly;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NCS.DSS.FunctionSteps.Core
{
    public class HttpHelper
    {
        private static readonly HttpClient _client = new HttpClient();

        public async Task<HttpResponseMessage> Post<T>(T request, string url, string touchpoint, string version, string apiKey)
        {
            var json = request != null ? JsonConvert.SerializeObject(request) : null;
            var bytes = Encoding.UTF8.GetBytes(json);
            return await CallApiRetry(HttpMethod.Post, bytes, url, 1, 1, touchpoint, version, apiKey);
        }

        public async Task<HttpResponseMessage> Patch<T>(T request, string url, string touchpoint, string version, string apiKey)
        {
            var json = request != null ? JsonConvert.SerializeObject(request) : null;
            var bytes = Encoding.UTF8.GetBytes(json);
            return await CallApiRetry(HttpMethod.Patch, bytes, url, 3, 1, touchpoint, version, apiKey, true);
        }

        public async Task<HttpResponseMessage> Delete(string url, string touchpoint, string version, string apiKey)
        {
            return await CallApiRetry(HttpMethod.Delete, null, url, 3, 1, touchpoint, version, apiKey, true);
        }

        public async Task<HttpResponseMessage> Get(string url, string touchpoint, string version, string apiKey)
        {
            return await CallApiRetry(HttpMethod.Get, null, url, 3, 1, touchpoint, version, apiKey, true);
        }

        private async Task<HttpResponseMessage> CallApi(string url, HttpMethod httpVerb, byte[] body, string touchPointId, string version, string apiKey)
        {
            try
            {
                var request = new HttpRequestMessage(httpVerb, url);
                request.Headers.Add("Ocp-Apim-Subscription-Key", apiKey);
                request.Headers.Add("TouchpointId", touchPointId);
                request.Headers.Add("apimurl", "http://dss-functional-test-suite");
                request.Headers.Add("version", version);
                request.Content = (httpVerb == HttpMethod.Post || httpVerb == HttpMethod.Patch || httpVerb == HttpMethod.Put) ? new ByteArrayContent(body) : null;
                var response = await _client.SendAsync(request);
                return response;
            } catch (Exception)
            {
                Console.WriteLine("Calling api error");
                return null;
            }
        }

        private async Task<HttpResponseMessage> CallApiRetry(HttpMethod httpVerb, byte[] body, string url, int retries, int waitTime, string touchPointId, string version, string apiKey, bool exponentialWait = false)
        {
            HttpStatusCode[] httpStatusCodesWorthRetrying = {
                HttpStatusCode.NotFound
            };

            var retryPolicy = Policy
                .Handle<HttpRequestException>()
                .OrResult<HttpResponseMessage>(r => httpStatusCodesWorthRetrying.Contains(r.StatusCode))
                .WaitAndRetryAsync(retries, (time) =>
                {
                    if (exponentialWait)
                        return TimeSpan.FromSeconds(waitTime * time);

                    return TimeSpan.FromSeconds(waitTime);
                });

            var response = await retryPolicy.ExecuteAndCaptureAsync(() =>
            {
                var result = CallApi(url, httpVerb, body, touchPointId, version, apiKey);
                return result;
            });
            return response.FaultType.HasValue ? response.FinalHandledResult : response.Result;
        }
    }
}
