using System;
using RestSharp;


namespace FunctionalTests.Helpers
{
    class RestHelper
    {

        public RestClient endpoint = null;

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

        internal static IRestResponse Post()
        {
            var client = new RestClient("https://test.api.nationalcareersservice.org.uk/customers/api/customers/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "56ac1586-6533-4ca6-a436-0ad7ed9911ef");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("TouchpointId", "0000000101");
            request.AddHeader("Ocp-Apim-Subscription-Key", "d87530f670724eca800a3a14d660ed6f");
            request.AddParameter("undefined", "{\n  \"DateOfRegistration\": \"2018-08-02T08:11:00Z\",\n  \"Title\": \"2\",\n  \"GivenName\": \"Fred\",\n  \"FamilyName\": \"Wellie\",\n  \"DateofBirth\": \"2005-07-26\",\t\n  \"Gender\": \"2\",\n  \"UniqueLearnerNumber\": \"9999999999\",\n  \"OptInUserResearch\": \"true\",\n  \"OptInMarketResearch\": \"true\",\n  \"IntroducedBy\": \"98\",\n  \"IntroducedByAdditionalInfo\": \"Additional Info\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response;
        }


        internal static IRestResponse Post(string json)
        {
            try
            {
                var client = new RestClient("https://test.api.nationalcareersservice.org.uk/customers/api/customers/");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Postman-Token", "56ac1586-6533-4ca6-a436-0ad7ed9911ef");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", "0000000101");
                request.AddHeader("Ocp-Apim-Subscription-Key", "d87530f670724eca800a3a14d660ed6f");
                request.AddParameter("undefined", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception e) { throw e; }
        }
    }
}
