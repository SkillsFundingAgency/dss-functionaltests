using System;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;


namespace FunctionalTests.Helpers
{
    public static class RestHelper
    {

        public static RestClient endpoint = null;
       
        public static RestClient SetEndpoint(string endpointUrl)
        {
            endpoint = new RestClient(endpointUrl);
            return endpoint;
        }


        internal static IRestResponse Post(string url, string json, string touchPointId, string subscriptionKey)
        {
            try
            {

                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("Postman-Token", "02abe184-9e77-4428-9092-b2320031027e");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", touchPointId);
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
                request.AddHeader("Postman-Token", "1135482c-17c8-49ec-8793-49de564a3e4e");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", touchPointId);
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
                request.AddHeader("Postman-Token", "02abe184-9e77-4428-9092-b2320031027e");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", touchPointId);
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

        //internal static async Task<IRestResponse> GetAsync(string url)
        //{
        //    var client = new RestClient(url);
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader("cache-control", "no-cache");
        //    request.AddHeader("TouchpointId", testTouchpointId);
        //    request.AddHeader("Ocp-Apim-Subscription-Key", testSubscriptionKey);
        //    IRestResponse response = await client.ExecuteTaskAsync(request);
        //    return response;
        //}

    }

 



}
