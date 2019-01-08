using System;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;


namespace FunctionalTests.Helpers
{
    public static class RestHelper
    {

        public RestClient endpoint = null;
       
        public RestClient SetEndpoint(string endpointUrl)
        {
            endpoint = new RestClient(endpointUrl);
            return endpoint;
        }

        //public static async System.Threading.Tasks.Task<string> GetQueryAsync(string query)
        //{

        //    var request = new RestRequest(query, Method.GET);
        //    var cancellationTokenSource = new CancellationTokenSource();

        //    IRestResponse response = await endpoint.ExecuteTaskAsync(request, cancellationTokenSource.Token);

        //    var content = response.Content; // raw content as string
        //    return content;
          
        //}

        //public void Update(string query, string price)
        //{
        //    var request = new RestRequest(query, Method.POST) { RequestFormat = DataFormat.Json };
        //    var body = ("");
        //    request.AddParameter("application/json", body, ParameterType.RequestBody);
        //    endpoint.Execute(request);
        //}

        //public void Delete(string query)
        //{
        //    var request = new RestRequest(query, Method.DELETE);
        //    endpoint.Execute(request);
        //}




        internal static IRestResponse Post(string url,string json, string touchPointId, string subscriptionKey)
        {
            try
            {
                var cancellationTokenSource = new CancellationTokenSource();
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", "9000000000");
                request.AddHeader("Ocp-Apim-Subscription-Key", subscriptionKey);
                request.AddParameter("undefined", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception e) { throw e; }
        }


        internal static IRestResponse Patch(string url, string json, string touchPointId, string subscriptionKey, string id)
        {
            try
            {
                var client = new RestClient(url + id);
                var request = new RestRequest(Method.PATCH);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", "9000000000");
                request.AddHeader("Ocp-Apim-Subscription-Key", subscriptionKey);
                request.AddParameter("undefined", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception e) { throw e; }
        }

        internal static IRestResponse Get(string url, string touchPointId, string subscriptionKey)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", "9000000000");
                request.AddHeader("Ocp-Apim-Subscription-Key", subscriptionKey);
                IRestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception e) { throw e; }
        }



        public static Task<IRestResponse> ExecuteTaskAsync(this RestClient @this, RestRequest request)
        {
            if (@this == null)
                throw new NullReferenceException();

            var tcs = new TaskCompletionSource<IRestResponse>();

            @this.ExecuteAsync(request, (response) =>
            {
                if (response.ErrorException != null)
                    tcs.TrySetException(response.ErrorException);
                else
                    tcs.TrySetResult(response);
            });

            return tcs.Task;
        }

/*        internal static async Task<IRestResponse> GetAsync(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("TouchpointId", testTouchpointId);
            request.AddHeader("Ocp-Apim-Subscription-Key", testSubscriptionKey);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            return response;
        }
*/
    }

 



}
