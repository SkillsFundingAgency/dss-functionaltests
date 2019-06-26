﻿using RestSharp;
using RestSharp.Extensions;
using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace FunctionalTests.Helpers
{
    public class RestHelper
    {

        public static Stopwatch responseTime = new Stopwatch();
        static int ThrottleBackofThreshold = 2000;
        static int ThrottleBackoffWaitTime = 5000;
        static bool ThrottleBackoff = false;
        static DateTime ThrottleBackoffStart = DateTime.MinValue;
        static int ThrottleBackoffPeriod = 60;
        static int RequestCount = 0;
        public static int Throttle { get; set; }

        public RestHelper()
        {
            Throttle = 0;
        }

        public static void ThrottleHandler()
        {
            int wait = 0;
            if (ThrottleBackoff)
            {
                wait = ThrottleBackoffWaitTime;
                if (ThrottleBackoffStart == DateTime.MinValue)
                {
                    ThrottleBackoffStart = DateTime.Now;
                    Console.WriteLine("Throttling: Backoff for " + ThrottleBackoffPeriod + "seconds");
                }
                else if (ThrottleBackoffStart.AddSeconds(ThrottleBackoffPeriod) > DateTime.Now)
                {
                    Console.WriteLine("Throttling: Backoff period expired - return to normal proccesing after this request");
                    ThrottleBackoff = false;
                    ThrottleBackoffStart = DateTime.MinValue;
                }
            }
            else if (responseTime.ElapsedMilliseconds > ThrottleBackofThreshold)
            {
                if (!ThrottleBackoff)
                {
                    ThrottleBackoff = true;
                    Console.WriteLine("Throttling: Request took too long. Invoke backoff");
                }
                wait = ThrottleBackoffWaitTime;
            }
            else if (Throttle > 0 && responseTime.ElapsedMilliseconds > 0)
            {
                // target interval is 1 second / throttle rate. 
                // If last response time was larger than that period then fire straight away, otherwise delay by difference between the two.
                int targetInterval = (int)(1000 / Throttle);
                wait = ( targetInterval > (int)responseTime.ElapsedMilliseconds ? targetInterval - (int)responseTime.ElapsedMilliseconds : 0 );
            }
            
            RequestCount++;
            Console.WriteLine("Throttling: Request " + RequestCount + " limited to " + Throttle + " requests per second.\nThrottling: Last responsetime was " + responseTime.ElapsedMilliseconds + " waiting for " + wait);
            Thread.Sleep(wait);

        }

        internal static IRestResponse Post(string url, string json, string touchPointId, string subscriptionKey)
        {
            Console.WriteLine("Attempt to POST: " + url);
            Console.WriteLine("Header value: touchPointId: " + touchPointId);
            Console.WriteLine("JSON Document: " + json);
            Thread.Sleep(250);
            try
            {

                RestClient client = null;

                //if (url.ToLower().Contains("outcome"))
                //{
                //    client = new RestClient(url) { Encoding = Encoding.GetEncoding("utf-32") };
                //}
                //else
                //{
                client = new RestClient(url);//) };
            //}


            //{ Encoding = Encoding.GetEncoding( (url.ToLower().Contains("outcome") ? "utf-8" : "utf-32")  )};


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
                    ThrottleHandler();
                    responseTime.Reset();
                    responseTime.Start();
                    response = client.Execute(request);
                    responseTime.Stop();
                    Console.WriteLine("Rest call Attempt: " + tries + " - Returned " + response.StatusCode + " in " + responseTime.ElapsedMilliseconds + " ms");
                    if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError )
                    {
                        if (tries <= maxTries)
                        {
                            Console.WriteLine("Sleep for " + (500 * tries) + " ms  and retry ");
                            Thread.Sleep(500 * tries);
                            if (!ThrottleBackoff)
                            {
                                Console.WriteLine("Throttling: Backoff invoked following 500 error");
                                ThrottleBackoff = true;
                            }
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
                    ThrottleHandler();
                    responseTime.Reset();
                    responseTime.Start();
                    response = client.Execute(request);
                    responseTime.Stop();
                    Console.WriteLine("Rest call Attempt: " + tries + " - Returned " + response.StatusCode + " in " + responseTime.ElapsedMilliseconds + " ms");
                    if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                    {
                        if (tries <= maxTries)
                        {
                            Console.WriteLine("Sleep and retry");
                            Thread.Sleep(500 * tries);
                            if (!ThrottleBackoff)
                            {
                                Console.WriteLine("Throttling: Backoff invoked following 500 error");
                                ThrottleBackoff = true;
                            }
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
                ThrottleHandler();
                responseTime.Reset();
                responseTime.Start();
                IRestResponse response = client.Execute(request);
                responseTime.Stop();
                Console.WriteLine("Rest call Attempt Returned " + response.StatusCode + " in " + responseTime.ElapsedMilliseconds + " ms");
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
