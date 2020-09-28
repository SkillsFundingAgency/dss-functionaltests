using RestSharp;
using RestSharp.Extensions;
using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using TechTalk.SpecFlow;
using System.Collections.Generic;

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
        //static Dictionary<string, int> FailureTracker = new Dictionary<string, int>;

        public static int Throttle { get; set; }


        public RestHelper()
        {
            Throttle = 0;
        }

        public static void ThrottleHandler(int minimumWaitTime = 0)
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
                else if (ThrottleBackoffStart.AddSeconds(ThrottleBackoffPeriod) < DateTime.Now)
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
            Console.Write("Throttle Pause from:" + DateTime.UtcNow.ToString("MM/dd/yyyy hh:mm:ss.fff"));
            if (wait < minimumWaitTime)
            {
                wait = minimumWaitTime;
            }
            Thread.Sleep(wait);
            Console.WriteLine(" - Until " + DateTime.UtcNow.ToString("MM/dd/yyyy hh:mm:ss.fff"));

        }

        internal static IRestResponse Post(string resourceName, string url, string json, string touchPointId, string subscriptionKey)
        {
            Console.WriteLine("Attempt to POST: " + url);
            Console.WriteLine("Header value: touchPointId: " + touchPointId);
            Console.WriteLine("JSON Document: " + json);
            //Thread.Sleep(250);
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

                if (ScenarioContext.Current["version"] != "v1" )
                {
                    request.AddHeader("version", (string)ScenarioContext.Current["version"]);

                    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("subcontractorId"))
                    {
                        if (!ScenarioContext.Current.ContainsKey("subcontractorId"))
                        {
                            ScenarioContext.Current.Add("subcontractorId", "67576575");
                        }
                        request.AddHeader("SubcontractorId", "67576575");
                    }
                    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("MaxLengthSubcontractorId"))
                    {
                        //ScenarioContext.Current.Add("subcontractorId", "123456789012345678901234567890123456789012345678901");
                        request.AddHeader("SubcontractorId", "12345678901234567890123456789012345678901234567890");
                    }
                    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("invalidSubcontractorId"))
                    {
                            //ScenarioContext.Current.Add("subcontractorId", "123456789012345678901234567890123456789012345678901");
                            request.AddHeader("SubcontractorId", "123456789012345678901234567890123456789012345678901");
                    }
                }

                Console.WriteLine("The Following headers have been added");
                Console.WriteLine("-------------------------------------");
                foreach (var p in request.Parameters)
                {
                    Console.WriteLine(p.Name + " - " + (p.Value.ToString().Length > 10 ? "[hidden]" : p.Value));
                }


                request.AddParameter("undefined", json, ParameterType.RequestBody);


                Console.WriteLine("-------------------------------------");
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

        internal static IRestResponse DeleteRequest(string url, string touchPointId, string id, string subscriptionKey)
        {
            Console.WriteLine("Attempt to Delete: " + url);
            try
            {
                var client = new RestClient(url + id);
                var request = new RestRequest(Method.DELETE);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", touchPointId);

                if (ScenarioContext.Current["version"] != "v1")
                {
                    request.AddHeader("version", (string)ScenarioContext.Current["version"]);
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

                Console.WriteLine("The Following headers have been added");
                Console.WriteLine("-------------------------------------");
                foreach (var p in request.Parameters)
                {
                    Console.WriteLine(p.Name + " - " + (p.Value.ToString().Length > 10 ? "[hidden]" : p.Value));
                }

                // IRestResponse response = client.Execute(request);
                IRestResponse response = null;
                bool retry = true;
                int tries = 0;
                int maxTries = 5;
                while (retry)
                {
                    tries++;
                    ThrottleHandler();//  try logic to check change feed has fired first. should be faster... 5250); // pause for 5 and a bit seconds to ensure change feed has had time on initial post
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
                    Console.WriteLine("Retry flag : " + (retry ? "True" : "False"));
                }
                return response;
            }
            catch (Exception e) { throw e; }
        }


        internal static IRestResponse Patch(/*string resourceName,*/ string url, string json, string touchPointId, string subscriptionKey, string id)
        {
            Console.WriteLine("Attempt to PATCH: " + url);
            Console.WriteLine("JSON Document: " + json);
            try
            {
                var client = new RestClient(url + id);
                var request = new RestRequest(Method.PATCH);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("TouchpointId", touchPointId);

                if (ScenarioContext.Current["version"] != "v1")
                {
                    request.AddHeader("version", (string)ScenarioContext.Current["version"]);
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

                Console.WriteLine("The Following headers have been added");
                Console.WriteLine("-------------------------------------");
                foreach (var p in request.Parameters)
                {
                    Console.WriteLine(p.Name + " - " + (p.Value.ToString().Length > 10 ? "[hidden]": p.Value ));
                }


                request.AddParameter("undefined", json, ParameterType.RequestBody);
               // IRestResponse response = client.Execute(request);
                IRestResponse response = null;
                bool retry = true;
                int tries = 0;
                int maxTries = 5;
                while (retry)
                {
                    tries++;
                    ThrottleHandler();//  try logic to check change feed has fired first. should be faster... 5250); // pause for 5 and a bit seconds to ensure change feed has had time on initial post
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

        internal static IRestResponse Get(/*string resourceName,*/ string url, string touchPointId, string subscriptionKey)
        {
            //Thread.Sleep(250);
            Console.WriteLine("Attempt to GET: " + url);
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);

                if (ScenarioContext.Current["version"] != "v1")
                {
                    if (!string.IsNullOrEmpty((string)ScenarioContext.Current["version"]))
                        request.AddHeader("version", (string)ScenarioContext.Current["version"]);
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
                    Console.WriteLine("Rest call Attempt (" + tries + ") Returned " + response.StatusCode + " in " + responseTime.ElapsedMilliseconds + " ms");
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        if (tries <= maxTries)
                        {
                            Console.WriteLine("Sleep and retry");
                            Thread.Sleep(500);
                            if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError && !ThrottleBackoff)
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
