using System;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;


namespace FunctionalTests.Helpers
{
    public static class RestHelper
    {

        public static RestClient endpoint = null;

        //AT
        public static string atSubscriptionKey = "c51073f9040a4174bbd88334a388deb0";//at
        public static string atTouchpointId = "0000000101";

        //TEST
        public static string testSubscriptionKey = "d87530f670724eca800a3a14d660ed6f";//test
        public static string testTouchpointId = "0000000101";

        //PP
        public static string ppSubscriptionKey = "33fa2bbd6ddd4990bc276b442071d755";//pp
        public static string ppTouchpointId = "9000000000";


        public static RestClient SetEndpoint(string endpointUrl)
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




        internal static IRestResponse Post(string url,string json)
        {
            try
            {
                var cancellationTokenSource = new CancellationTokenSource();
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", testTouchpointId);
                request.AddHeader("Ocp-Apim-Subscription-Key", testSubscriptionKey);
                request.AddParameter("undefined", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception e) { throw e; }
        }





        internal static IRestResponse Patch(string url, string json,string id)
        {
            try
            {
                var client = new RestClient(url + id);
                var request = new RestRequest(Method.PATCH);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", testTouchpointId);
                request.AddHeader("Ocp-Apim-Subscription-Key", testSubscriptionKey);
                request.AddParameter("undefined", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception e) { throw e; }
        }

        internal static IRestResponse Get(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", testTouchpointId);
                request.AddHeader("Ocp-Apim-Subscription-Key", testSubscriptionKey);
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

        internal static async Task<IRestResponse> GetAsync(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("TouchpointId", testTouchpointId);
            request.AddHeader("Ocp-Apim-Subscription-Key", testSubscriptionKey);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            return response;
        }

    }

 



}
