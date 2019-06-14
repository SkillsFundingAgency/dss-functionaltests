using RestSharp;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace FunctionalTests.Helpers
{
    public class RestHelper
    {

        public RestClient endpoint = null;
       
        public RestClient SetEndpoint(string endpointUrl)
        {
            endpoint = new RestClient(endpointUrl);
            return endpoint;
        }


        internal static IRestResponse Post(string url, string json, string touchPointId, string subscriptionKey)
        {
            Console.WriteLine("Attempt to POST: " + url);
            Console.WriteLine("Header value: touchPointId: " + touchPointId);
            Console.WriteLine("JSON Document: " + json);
            Thread.Sleep(250);
            try
            {

                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", touchPointId );
                request.AddHeader("Ocp-Apim-Subscription-Key", subscriptionKey);

                if (ScenarioContext.Current["version"].Equals("v2"))
                {
                    request.AddHeader("version", "v2");

                    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("subcontractorId"))
                    {
                        if (!ScenarioContext.Current.ContainsKey("subcontractorId"))
                        {
                            ScenarioContext.Current.Add("subcontractorId", "67576575");
                        }
                        request.AddHeader("SubcontractorId", "67576575");
                    }
                    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("invalidSubcontractorId"))
                    {
                            //ScenarioContext.Current.Add("subcontractorId", "123456789012345678901234567890123456789012345678901");
                            request.AddHeader("SubcontractorId", "123456789012345678901234567890123456789012345678901");
                    }
                }
                request.AddParameter("undefined", json, ParameterType.RequestBody);

                IRestResponse response = null;
                bool retry = true;
                int tries = 0;
                int maxTries = 8;
                while (retry)
                {
                    tries++;
                    response = client.Execute(request);
                    Console.WriteLine("Rest call Attempt: " + tries + " - Returned " + response.StatusCode);
                    if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError )
                    {
                        if (tries <= maxTries)
                        {
                            Console.WriteLine("Sleep for " + (500 * tries) + " ms  and retry ");
                            Thread.Sleep(500 * tries);
                        }
                        else retry = false;
                    }
                    else retry = false;
                }
                return response;
            }
            catch (Exception e) { throw e; }
        }


        internal static IRestResponse Patch(string url, string json, string touchPointId, string subscriptionKey, string id)
        {
            Console.WriteLine("Attempt to PATCH: " + url);
            Thread.Sleep(250);
            try
            {
                var client = new RestClient(url + id);
                var request = new RestRequest(Method.PATCH);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", touchPointId);

                if (ScenarioContext.Current["version"].Equals("v2"))
                {
                    request.AddHeader("version", "v2");
                    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("subcontractorId"))
                    {
                        if (!ScenarioContext.Current.ContainsKey("subcontractorId"))
                        {
                            ScenarioContext.Current.Add("subcontractorId", "67576575");
                            request.AddHeader("SubcontractorId", "67576575");
                        }
                    }
                    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("InvalidSubcontractorId"))
                    {
                        ScenarioContext.Current.Add("subcontractorId", "123456789012345678901234567890123456789012345678901");
                        request.AddHeader("SubcontractorId", "123456789012345678901234567890123456789012345678901");
                    }
                }
                request.AddHeader("Ocp-Apim-Subscription-Key", subscriptionKey);
                request.AddParameter("undefined", json, ParameterType.RequestBody);
               // IRestResponse response = client.Execute(request);
                IRestResponse response = null;
                bool retry = true;
                int tries = 0;
                int maxTries = 5;
                while (retry)
                {
                    tries++;
                    response = client.Execute(request);
                    Console.WriteLine("Rest call Attempt: " + tries + " - Returned " + response.StatusCode);
                    if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                    {
                        if (tries <= maxTries)
                        {
                            Console.WriteLine("Sleep and retry");
                            Thread.Sleep(10000);
                        }
                        else retry = false;
                    }
                    else retry = false;
                    Console.WriteLine("Retry flag : " +  ( retry ? "True" : "False" ) );
                }
                return response;
            }
            catch (Exception e) { throw e; }
        }

        internal static IRestResponse Get(string url, string touchPointId, string subscriptionKey)
        {
            Thread.Sleep(250);
            Console.WriteLine("Attempt to GET: " + url);
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
 
                if (ScenarioContext.Current["version"].Equals("v2"))
                {
                    request.AddHeader("version", "v2");
                    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("SubcontractorId"))
                    {
                        if (!ScenarioContext.Current.ContainsKey("subcontractorId"))
                        {
                            ScenarioContext.Current.Add("subcontractorId", "67576575");
                            request.AddHeader("SubcontractorId", "67576575");
                        }
                    }
                    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("InvalidSubcontra    ctorId"))
                    {
                        ScenarioContext.Current.Add("subcontractorId", "123456789012345678901234567890123456789012345678901");
                        request.AddHeader("SubcontractorId", "123456789012345678901234567890123456789012345678901");
                    }
                }
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", touchPointId);
                if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>("getV2") || ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("getV2"))
                {
                    request.AddHeader("version", "v2");
                }
 
                request.AddHeader("Ocp-Apim-Subscription-Key", subscriptionKey);
                IRestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception e) { throw e; }
        }



        /*public static Task<IRestResponse> ExecuteTaskAsync(this RestClient @this, RestRequest request)
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
        }*/

 

    }

 



}
