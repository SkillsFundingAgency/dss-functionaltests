using System;
using RestSharp;


namespace FunctionalTests.Helpers
{
    class RestHelper
    {

        public RestClient endpoint = null;
        public static string subscriptionKey = "33fa2bbd6ddd4990bc276b442071d755";


        public RestClient SetEndpoint(string endpointUrl)
        {
            endpoint = new RestClient(endpointUrl);
            return endpoint;
        }

        public string GetQuery(string query)
        {
            var request = new RestRequest(query, Method.GET);
            IRestResponse response = endpoint.Execute(request);
            var content = response.Content; // raw content as string
            return content;
        }

        public void Update(string query, string price)
        {
            var request = new RestRequest(query, Method.POST) { RequestFormat = DataFormat.Json };
            var body = ("");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            endpoint.Execute(request);
        }

        public void Delete(string query)
        {
            var request = new RestRequest(query, Method.DELETE);
            endpoint.Execute(request);
        }


        internal static IRestResponse Post(string url,string json)
        {
            try
            {

                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("Postman-Token", "02abe184-9e77-4428-9092-b2320031027e");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", "9000000000");
                request.AddHeader("Ocp-Apim-Subscription-Key", subscriptionKey);
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
                request.AddHeader("Postman-Token", "1135482c-17c8-49ec-8793-49de564a3e4e");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", "9000000000");
                request.AddHeader("Ocp-Apim-Subscription-Key", subscriptionKey);
                request.AddParameter("undefined", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception e) { throw e; }
        }




    }
}
