﻿using RestSharp;
using System;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

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
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", touchPointId);
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
                    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("InvalidSubcontractorId"))
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

 

    }

 



}
