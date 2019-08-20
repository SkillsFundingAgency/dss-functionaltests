using FluentAssertions;
using NCS.DSS.FunctionalTests;
using FunctionalTests.Helpers;
using FunctionalTests.Models;
using NCS.DSS.FunctionalTests.Helpers;
using NCS.DSS.FunctionalTests.Models;
using Newtonsoft.Json;  
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Configuration;
using System.Threading;

namespace FunctionalTests.StepDefs
{
    [Binding]
    public class Steps
    {
        private EnvironmentSettings envSettings = new EnvironmentSettings();
        private IRestResponse response;
        //
       
            private string baseUrl;
             private string url;
             private string json;
             private string json2;
             private string id;
             private string customerId;
             private string adviserDetailId;
             private string addressId;
             private string contactId;
             private string interactionId;
             private string actionPlanId;

             private string sessionId;
             private string goalId;
             private string outcomeId;
             private string webChatId;
             private string diversityId;
             private string subscriptionId;
             private string transferId;
             private string learningProgressionId;
             private bool lastRequestWasPatch = false;
             private string targetOfLastPost = "";
             private DateTime requestTime;
             private DateTime PostUpdateTime;
             private string creatingTouchpoint;
             private string lastTouchpoint;
             private String lastResourceName;
             public string actionId { get; set; }
        RequestContext requestContext;
        private List<TestDataItem> loadedData = new List<TestDataItem>();
        Dictionary<string, string> sqlData = new Dictionary<string, string>();

        
        private readonly ScenarioContext scenarioContext;

        public Steps(ScenarioContext context)
        {
            requestContext = new RequestContext();
            scenarioContext = context;
            RestHelper.Throttle = envSettings.ThrottleValue;
            
        }
        string AssertAndExtract(string key, IRestResponse response)
        {
            string extractedValue = ExtractFromResponse(key, response);
            
            loadedData.Add(new TestDataItem(key, extractedValue));
            scenarioContext["TestData"] = loadedData;
            return extractedValue;
        }

        string ExtractFromResponse(string key, IRestResponse response)
        {
            string extractedValue = "";
            if (response.IsSuccessful)
            {
                Dictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                extractedValue = values[key];
                Console.WriteLine("Storing context information:" + key + " - " + extractedValue);
                if (extractedValue.Trim().Length == 0)
                {
                    Console.WriteLine("extraction failed, response.content:\n" + response.Content);
                    Console.WriteLine("");
                }
                extractedValue.Should().NotBeNullOrEmpty();
            }
            else
            {
                Console.WriteLine("Request was unsuccessful");
                Console.WriteLine("response status: " + response.StatusCode);
                Console.WriteLine("response status description: " + response.StatusDescription);
                Console.WriteLine("response message: " + response.ErrorMessage);
                Console.WriteLine("response expection: " + response.ErrorException);
            }
            return extractedValue;
        }
       public string PostRequest( string sBaseUrl, string sJson, string sResource)
        {
            string sUrl = sBaseUrl + requestContext.UrlBuilder(sResource);            
            response = RestHelper.Post(lastResourceName = sResource, sUrl, sJson, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            id = AssertAndExtract(constants.IdFromResource(sResource), response);
            requestContext.SetRequestDetails(sResource, sUrl, (id == string.Empty ? Guid.Empty : new Guid(id)), response.StatusCode, response.Content);
            creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            lastRequestWasPatch = false;
            return sUrl;
        }

        [Given(@"I post a Customer with the following details:")]
        public void GivenIPostACustomerWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            var customer = new object();
            if (ScenarioContext.Current["version"].Equals("v2"))
            {
                customer = table.CreateInstance<CustomerV2>();
            }
            else
            {
                customer = table.CreateInstance<Customer>();
            }

            json = JsonConvert.SerializeObject(customer);
            url = PostRequest(envSettings.BaseUrl, json, constants.Customers);
            customerId = id;
        }

         [Given(@"I post a customer with the given name '(.*)'")]
        public void GivenIPostACustomerWithTheGivenName(string givenName)
        {
            SetVersion("post", true);
            url = envSettings.BaseUrl + "customers/api/customers/";
            var customer = new Customer();
            customer.GivenName = givenName;
            customer.FamilyName = "Smith";
            json = JsonConvert.SerializeObject(customer);
            response = RestHelper.Post(lastResourceName = constants.Customers, url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            customerId = AssertAndExtract("CustomerId", response);
            creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            lastRequestWasPatch = false;
        }


        [Given(@"I post an adviser with the following details:")]
        public void GivenIPostAnAdviserWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            //url = envSettings.BaseUrl + "adviserdetails/api/AdviserDetails/";
            var adviser = table.CreateInstance<Adviser>();
            json2 = JsonConvert.SerializeObject(adviser);

            url = PostRequest(envSettings.BaseUrl, json2, constants.AdviserDetails);
            adviserDetailId = id;

            //response = RestHelper.Post(lastResourceName = constants.AdviserDetails, url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            //adviserDetailId = AssertAndExtract("AdviserDetailId", response);
            //id = adviserDetailId;
            //creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            //lastRequestWasPatch = false;
        }

        [Given(@"I post an Interaction with the following details:")]
        public void GivenIPostAnInteractionWithTheFollowingDetails(Table table)
        {
            var interaction = table.CreateInstance<Interaction>();
            json = JsonConvert.SerializeObject(interaction);
            //          if (interaction.AdviserDetailsId is null && adviserDetailId.Length > 0 )
            //            {
            //              interaction.AdviserDetailsId = adviserDetailId;
            //          }
            url = PostRequest(envSettings.BaseUrl, json, constants.Interactions);
            interactionId = id;
        }


        [Given(@"I post an Address with the following details:")]
        public void GivenIPostAnAddressWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
           // url = envSettings.BaseUrl + "addresses/api/Customers/" + customerId + "/Addresses/";
            var address = table.CreateInstance<Address>();
            json2 = JsonConvert.SerializeObject(address);

            url = PostRequest(envSettings.BaseUrl, json2, constants.Addresses);
            addressId = id;
            //response = RestHelper.Post(lastResourceName = targetOfLastPost = constants.Addresses, url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            //addressId = AssertAndExtract("AddressId", response);
            //id = addressId;
            //creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            //lastRequestWasPatch = false;
        }

        [Then(@"when I post an Address with the following details:")]
        public void ThenWhenIPostAnAddressWithTheFollowingDetails(Table table)
        {
            GivenIPostAnAddressWithTheFollowingDetails(table);
        }


        [Given(@"I post a Contact with the following details:")]
        public void GivenIPostAContactWithTheFollowingDetails(Table table)
        {
            ScenarioContext.Current["version"] = "";
           // url = envSettings.BaseUrl + "contactDetails/api/Customers/" + customerId + "/contactDetails/";
            var contact = table.CreateInstance<Contact>();
            json2 = JsonConvert.SerializeObject(contact);
            url = PostRequest(envSettings.BaseUrl, json2, constants.Contacts);
            contactId = id;
            //response = RestHelper.Post(lastResourceName = targetOfLastPost = constants.Contacts, url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            //contactId = AssertAndExtract("ContactId", response);
            //creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            //lastRequestWasPatch = false;
        }


        [Given(@"I post an ActionPlan with the following details:")]
        public void GivenIPostAnActionPlanWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            var actionPlan = new Object();
            //url = envSettings.BaseUrl + "actionplans/api/Customers/" + requestContext.GetDocumentId(constants.Customers) + "/Interactions/" + interactionId + "/ActionPlans/";

            if (ScenarioContext.Current["version"].Equals("v2"))
            {
                actionPlan = table.CreateInstance<ActionPlanV2>();
                actionPlan.As<ActionPlanV2>().SessionId = requestContext.GetDocumentId(constants.Sessions).ToString();
            }
            else
            {
                actionPlan = table.CreateInstance<ActionPlan>();
            }

            json = JsonConvert.SerializeObject(actionPlan);

            url = PostRequest(envSettings.BaseUrl, json, constants.ActionPlans);
            actionPlanId = id;
   
        }






        [Given(@"I post an Action with the following details:")]
        public void GivenIPostAnActionWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            var action = new object();
           // url = envSettings.BaseUrl + "actions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/actions/";
            if (ScenarioContext.Current["version"].Equals("v2"))
            {
                action = table.CreateInstance<ActionV2>();
            }
            else
            {
                action = table.CreateInstance<NCS.DSS.FunctionalTests.Models.Action>();
            }

            json = JsonConvert.SerializeObject(action);

            url = PostRequest(envSettings.BaseUrl, json, constants.Actions);
            actionId = id;

            //response = RestHelper.Post(lastResourceName = constants.Actions, url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            //actionId = AssertAndExtract("ActionId", response);
            //id = actionId;
            //creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            //lastRequestWasPatch = false;
        }

        [Given(@"I post a Diversity Details record with the following details:")]
        public void GivenIPostADiversityDetailsRecordWithTheFollowingDetails(Table table)
        {
            WhenIPostADiversityDetailWithTheFollowingDetails(table);
        }


        [When(@"I post a DiversityDetail with the following details:")]
        public void WhenIPostADiversityDetailWithTheFollowingDetails(Table table)
        {
           // ScenarioContext.Current["version"] = "";
            SetVersion("post", true);
            
           // url = envSettings.BaseUrl + "diversitydetails/api/Customers/" + customerId + "/DiversityDetails/";
            var diversity = table.CreateInstance<Diversity>();
            json2 = JsonConvert.SerializeObject(diversity);

            if (scenarioContext.ContainsKey("AdditionalFieldName"))
            {
                json2 = JsonHelper.AddPropertyToJsonString(json2, (string)scenarioContext["AdditionalFieldName"],
                                    ((string)scenarioContext["AdditionalFieldName"]).Contains("Date")? 
                                                                             SpecflowHelper.TranslateDateToken((string)scenarioContext["AdditionalFieldValue"]).ToString("yyyy-MM-ddTHH:mm:ssZ")
                                                                            : (string)scenarioContext["AdditionalFieldValue"] );  
            }

            url = PostRequest(envSettings.BaseUrl, json2, constants.DiversityDetails);
            diversityId = id;

            //response = RestHelper.Post(lastResourceName = constants.DiversityDetails, url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            //diversityId = AssertAndExtract("DiversityId", response);
            //creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            //lastRequestWasPatch = false;
        }


        [Given(@"I post a session with the following details:")]
            public void GivenIPostASessionWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
          //  url = envSettings.BaseUrl + requestContext.UrlBuilder(constants.Sessions);// "sessions/api/Customers/" + requestContext.GetDocumentId(constants.Customers) + "/Interactions/" + interactionId + "/sessions/";

            var session = new object();

            if (ScenarioContext.Current["version"].Equals("v2"))
            {
                session = table.CreateInstance<SessionV2>();
            }
            else
            {
                session = table.CreateInstance<Session>();
            }

            json = JsonConvert.SerializeObject(session);

            url = PostRequest(envSettings.BaseUrl, json, constants.Sessions);
            sessionId = id;
      
        }


        [Given(@"I post a goal with the following details:")]
        public void GivenIPostAGoalWithTheFollowingDetails(Table table)
        {
            SetVersion("post");

           // url = envSettings.BaseUrl + "goals/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/goals/";

            var goal = new object();

            if (ScenarioContext.Current["version"].Equals("v2"))
            {
                goal = table.CreateInstance<GoalV2>();
            }
            else
            {
                goal = table.CreateInstance<Goal>();
            }

            json = JsonConvert.SerializeObject(goal);

            url = PostRequest(envSettings.BaseUrl, json, constants.Goals);
            goalId = id;
            //response = RestHelper.Post(lastResourceName = constants.Goals, url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            //id = goalId = AssertAndExtract("GoalId", response);
            //creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            //lastRequestWasPatch = false;
        }

        [Given(@"I post a webchat with the following details:")]
        public void GivenIPostAWebchatWithTheFollowingDetails(Table table)
        {
            //url = envSettings.BaseUrl + "webchats/api/Customers/" + customerId + "/Interactions/" + interactionId + "/webchats/";
            var webchat = table.CreateInstance<WebChat>();
            json2 = JsonConvert.SerializeObject(webchat);

            url = PostRequest(envSettings.BaseUrl, json2, constants.WebChats);
            webChatId = id;


            //response = RestHelper.Post(lastResourceName = constants.WebChats, url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            //webChatId = AssertAndExtract("WebChatId", response);
            //PostUpdateTime = DateTime.Parse(ExtractFromResponse("LastModifiedDate", response)).ToUniversalTime();
            //creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            //lastRequestWasPatch = false;
        }

        [Given(@"I post an outcome with the following details:")]
        public void GivenIPostAnOutcomeWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            var outcome = new object();
  //          url = envSettings.BaseUrl + requestContext.UrlBuilder(constants.Outcomes);// outcomes/api/Customers/" + requestContext.GetDocumentId(constants.Customers) + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/outcomes/";

            if (ScenarioContext.Current["version"].Equals("v2"))
            {
                outcome = table.CreateInstance<OutcomeV2>();
                outcome.As<OutcomeV2>().SessionId = requestContext.GetDocumentId(constants.Sessions).ToString();
            }
            else
            {
                outcome = table.CreateInstance<Outcome>();
            }

            json = JsonConvert.SerializeObject(outcome);
            url = PostRequest(envSettings.BaseUrl, json, constants.Outcomes);
            outcomeId = id;
        }

        [Given(@"I post a Transfer with the following details:")]
        public void GivenIPostAnTransferWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "transfers/api/Customers/" + customerId + "/Interactions/" + interactionId + "/Transfers/";
            var transfer = table.CreateInstance<Transfer>();
            transfer.OriginatingTouchpointId = getTouchPoint(transfer.OriginatingTouchpointId);
            transfer.TargetTouchpointId = getTouchPoint(transfer.TargetTouchpointId);
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("InteractionId"))
            {
                transfer.InteractionId = interactionId;
            }

            transfer.OriginatingTouchpointId = envSettings.TestEndpoint01;
            transfer.TargetTouchpointId = envSettings.TestEndpoint02;

            json = JsonConvert.SerializeObject(transfer,
                                               Formatting.Indented,
                                               new JsonSerializerSettings
                                               {
                                                   NullValueHandling = NullValueHandling.Ignore
                                               });
            url = PostRequest(envSettings.BaseUrl, json, constants.Transfers);
            transferId = id;

            //response = RestHelper.Post(lastResourceName = constants.Transfers, url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            //transferId = AssertAndExtract("TransferId", response);
            //creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            //lastRequestWasPatch = false;
        }

        [Given(@"I post a new subscription request")]
        public void GivenIPostANewSubscriptionRequest()
        {
            url = envSettings.BaseUrl + "subscriptions/api/Customers/" + customerId + "/subscriptions/";
            json2 = "{ \"subscribe\": true }";
            response = RestHelper.Post(constants.Subscriptions, url, json2, envSettings.TestEndpoint02, envSettings.SubscriptionKey);
            subscriptionId = AssertAndExtract("SubscriptionId", response);
            creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            lastRequestWasPatch = false;
        }


        [Given(@"I post an subscription with the following details:")]
        public void GivenIPostASubscriptionWithTheFollowingDetails(Table table)
        {
           //rl = envSettings.BaseUrl + "subscriptions/api/Customers/" + customerId + "/subscriptions/";
            var subscription = table.CreateInstance<Subscription>();
            json2 = JsonConvert.SerializeObject(subscription);

            url = PostRequest(envSettings.BaseUrl, json, constants.Subscriptions);
            subscriptionId = id;

            /*response = RestHelper.Post(lastResourceName = constants.Subscriptions, url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            subscriptionId = AssertAndExtract("SubscriptionId", response);
            creatingTouchpoint = lastTouchpoint = envSettings.TestEndpoint01;
            lastRequestWasPatch = false;*/


        }

        [Given(@"I post a Learning Progression record with the following details:")]
        public void GivenIPostALearningProgressionRecordWithTheFollowingDetails(Table table)
        {
            table = SpecflowHelper.ReplaceTokensInTable(table, false, "Field");
            
            var learningProgression = table.CreateInstance<LearningProgression>();
            json2 = JsonConvert.SerializeObject(learningProgression);

            if (scenarioContext.ContainsKey("AdditionalFieldName"))
            {
                json2 = JsonHelper.AddPropertyToJsonString(json2, (string)scenarioContext["AdditionalFieldName"], (string)scenarioContext["AdditionalFieldValue"]);
            }

            url = PostRequest(envSettings.BaseUrl, json, constants.LearningProgression);
            learningProgressionId = id;
        }

        [Given(@"I want to send (.*) with value (.*) in the following request")]
        public void GivenIWantToSendCurrentLearningStatusWithValueInTheFollowingRequest(string p0, string p1)
        {
            scenarioContext["AdditionalFieldName"] = p0;
            scenarioContext["AdditionalFieldValue"] = p1;
        }


        [When(@"I patch the following using ""(.*)"":")]
        [When(@"I patch the following via a different touchpoint")]
        public void WhenIPatchTheFollowingViaADifferentTouchpoint(Table table)
        {
            // pass through to overload
            patchFromTable2(table, lastResourceName, envSettings.TestEndpoint02);
        }



        [When(@"I patch the following:")]
        public void WhenIPatchTheFollowing(Table table)
        {
            patchFromTable2(table, lastResourceName);
        }

        [Given(@"I patch ""(.*)"" with the following details:")]
        public void GivenIPatchWithTheFollowingDetails(string p0, Table table)
        {
            patchFromTable2(table, p0);
        }


        [When(@"I patch ""(.*)"" with the following details:")]
        public void WhenIPatchWithTheFollowingDetails(string p0, Table table)
        {
            patchFromTable2(table, p0);
        }

        [When(@"I patch the element (.*) with (.*):")]
        public void WhenIPatchTheElementWith(string p0, string p1)
        {
            Table table = new Table(new string[] { "Field", "Value" });
            table.AddRow(new string[] { p0, p1 });
            patchFromTable2(table, lastResourceName);
        }

        [When(@"I patch an unknown resource with the element (.*) with (.*):")]
        public void WhenIPatchAnUnknownResourceWithTheElementWith(string p0, string p1)
        {
            // update last resource with a random guid
            requestContext.SetDocumentId(lastResourceName, Guid.NewGuid());
            WhenIPatchTheElementWith(p0, p1);
        }

        private bool V3PatchSupported(string resource)
        {
            switch (resource)
            {
                case constants.DiversityDetails:
                    return true;
                default:
                    return false;
            }
        }

        private void patchFromTable2(Table table, string resource, String touchpointId = "")
        {
            // before we patch, make sure that the post has been picked up by change feed and arrived in staging db
            // otherwise  post and patch change feed may get wrapped up into one.
            requestContext.GetResponseCode(resource).Should().Be(HttpStatusCode.Created, "Because a patch cannot be attempted unless the post returned with 201 - Created");
            ThenThereShouldBeARecordInTheChangeFeedTable(resource);


            // five second pause to attempt to ensure that change feed trigger for patch is not wrapped up with post
            //Thread.Sleep(5250);
            SetVersion("patch", V3PatchSupported(resource));
           // Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
           // id = dict.FirstOrDefault().Value;
            Dictionary<string, string> patchVals = table.Rows.ToDictionary(r => r["Field"], r => r["Value"]);
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("SessionId"))
            {
                patchVals.Add("SessionId", sessionId);
            }

            json = JsonConvert.SerializeObject(patchVals);

            if (scenarioContext.ContainsKey("AdditionalFieldName"))
            {
//                json = JsonHelper.AddPropertyToJsonString(json, (string)scenarioContext["AdditionalFieldName"], (string)scenarioContext["AdditionalFieldValue"]);

                json = JsonHelper.AddPropertyToJsonString(json, (string)scenarioContext["AdditionalFieldName"],
                               ((string)scenarioContext["AdditionalFieldName"]).Contains("Date") ?
                                                                        SpecflowHelper.TranslateDateToken((string)scenarioContext["AdditionalFieldValue"]).ToString("yyyy-MM-ddTHH:mm:ssZ")
                                                                       : (string)scenarioContext["AdditionalFieldValue"]);

            }
            lastTouchpoint = (touchpointId.Equals(string.Empty) ? envSettings.TestEndpoint01 : touchpointId);
            //requestTime = DateTime.UtcNow;


            response = RestHelper.Patch(requestContext.GetDocumentBaseUrl(resource), json, lastTouchpoint, envSettings.SubscriptionKey, requestContext.GetDocumentId(resource).ToString());
            string RequestTimeString = response.Headers
                .Where(x => x.Name == "Date")
                .Select(x => x.Value)
                .FirstOrDefault().ToString();
            requestTime = DateTime.Parse(RequestTimeString).ToUniversalTime();
            lastRequestWasPatch = true;
            requestContext.UpdateRequestDetails(resource, response.StatusCode, response.Content);

        }

        private void patchFromTable(Table table, String touchpointId = "")
        {
            // before we patch, make sure that the post has been picked up by change feed and arrived in staging db
            // otherwise  post and patch change feed may get wrapped up into one.
            response.StatusCode.Should().Be(HttpStatusCode.Created, "Because a patch cannot be attempted unless the post returned with 201 - Created");
            ThenThereShouldBeARecordInTheChangeFeedTable(lastResourceName);



        //private void patchFromTable(Table table, String touchpointId = "")
        //{
        //    // before we patch, make sure that the post has been picked up by change feed and arrived in staging db
        //    // otherwise  post and patch change feed may get wrapped up into one.
        //    response.StatusCode.Should().Be(HttpStatusCode.Created, "Because a patch cannot be attempted unless the post returned with 201 - Created");
        //    ThenThereShouldBeARecordInTheChangeFeedTable(lastResourceName);


        //    // five second pause to attempt to ensure that change feed trigger for patch is not wrapped up with post
        //    //Thread.Sleep(5250);
        //    SetVersion("patch");
        //    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
        //    id = dict.FirstOrDefault().Value;
        //    Dictionary<string, string> patchVals = table.Rows.ToDictionary(r => r["Field"], r => r["Value"]);
        //    if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("SessionId"))
        //    {
        //        patchVals.Add("SessionId", sessionId);
        //    }
        //    json = JsonConvert.SerializeObject(patchVals);
        //    lastTouchpoint = (touchpointId.Equals(string.Empty) ? envSettings.TestEndpoint01 : touchpointId);
        //    //requestTime = DateTime.UtcNow;


        //    response = RestHelper.Patch(url, json, lastTouchpoint, envSettings.SubscriptionKey, id);
        //    string RequestTimeString = response.Headers
        //        .Where(x => x.Name == "Date")
        //        .Select(x => x.Value)
        //        .FirstOrDefault().ToString();
        //    requestTime = DateTime.Parse(RequestTimeString).ToUniversalTime();
        //    lastRequestWasPatch = true;

        //}



        [When(@"I get a Customer by ID")]
        public void WhenIGetACustomerByID()
        {
            url = envSettings.BaseUrl + "customers/api/customers/" + customerId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I search for:")]
        public void WhenISearchFor(Table table)
        {

            Dictionary<string, string> dict = table.Rows.ToDictionary(r => r["Field"], r => r["Value"]);
 
            url = envSettings.BaseUrl + "customers/api/CustomerSearch/?" + dict["parameter1"] + "=" + CheckForSpaces(dict["parameter2"]);
            if (!string.IsNullOrEmpty(GetKey(dict, "parameter3")))
            {
                url = url + "&" + dict["parameter3"] + "=" + CheckForSpaces(dict["parameter4"]);
            }
            if (!string.IsNullOrEmpty(GetKey(dict, "parameter5")))
            {
                url = url + "&" + dict["parameter5"] + "=" + CheckForSpaces(dict["parameter6"]);
            }

            var maxTries = 6;
            var triesSoFar = 0;
            while (triesSoFar < maxTries)
            {
                triesSoFar++;
                response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    break;
                }
                Console.WriteLine("Try" + triesSoFar + " of " + maxTries + " returned response " + response.StatusCode.ToString());
                Thread.Sleep(1000);
            }
        }


        [When(@"I get an Action by ID")]
        public void WhenIGetAnActionByID()
        {
            url = envSettings.BaseUrl + "actions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/actions/" + actionId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }


        [When(@"I get an ActionPlan by ID")]
        public void WhenIGetAnActionPlanByID()
        {
            url = envSettings.BaseUrl + "actionplans/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get an Address by ID")]
        public void WhenIGetAnAddressByID()
        {
            url = envSettings.BaseUrl + "addresses/api/Customers/" + customerId + "/Addresses/" + addressId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get an Adviser by ID")]
        public void WhenIGetAnAdviserByID()
        {
            url = envSettings.BaseUrl + "adviserdetails/api/AdviserDetails/" + adviserDetailId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get a Contact by ID")]
        public void WhenIGetAContactByID()
        {
            url = envSettings.BaseUrl + "contactDetails/api/Customers/" + customerId + "/contactDetails/" + contactId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get a Goal by ID")]
        public void WhenIGetAGoalByID()
        {
            url = envSettings.BaseUrl + "goals/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/goals/" + goalId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get an Interaction by ID")]
        public void WhenIGetAnInteractionByID()
        {
            url = envSettings.BaseUrl + "interactions/api/Customers/" + customerId + "/Interactions/" + interactionId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get an Outcome by ID")]
        public void WhenIGetAnOutcomeByID()
        {
            url = envSettings.BaseUrl + "outcomes/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/outcomes/" + outcomeId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get a Session by ID")]
        public void WhenIGetASessionByID()
        {
            url = envSettings.BaseUrl + "sessions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/sessions/" + sessionId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get a WebChat by ID")]
        public void WhenIGetAWebChatByID()
        {
            url = envSettings.BaseUrl + "webchats/api/Customers/" + customerId + "/Interactions/" + interactionId + "/webchats/" + webChatId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get a Diversity Details by ID")]
        public void WhenIGetADiversityDetailsByID()
        {
            url = envSettings.BaseUrl + "diversitydetails/api/Customers/" + customerId + "/diversitydetails/" + diversityId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }


        [When(@"I get a Learning Progression by ID")]
        public void WhenIGetALearningProgressionByID()
        {
            url = envSettings.BaseUrl + "LearningProgression/api/Customers/" + customerId + "/LearningProgression/" + learningProgressionId;
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get all Learning Progression records for a customer")]
        public void WhenIGetAllLearningProgressionRecordsForACustomer()
        {
            url = envSettings.BaseUrl + "LearningProgression/api/Customers/" + customerId + "/LearningProgression/";
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get all Address records for a customer")]
        public void WhenIGetAllAddressRecordsForACustomer()
        {
            url = envSettings.BaseUrl + "Addresses/api/Customers/" + customerId + "/Addresses/";
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }

        [When(@"I get all Diversity Details records for a customer")]
        public void WhenIGetAllDiversityDetailsRecordsForACustomer()
        {
            url = envSettings.BaseUrl + "diversitydetails/api/Customers/" + customerId + "/diversitydetails/";
            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
        }



        [Then(@"the response should contain (.*) document\(s\)")]
        public void ThenTheResponseShouldContainDocumentS(int p0)
        {
            JsonHelper.DocumentCount(response.Content).Should().Be(p0);
        }


        [Then(@"the response body should incorporate a document with the following details:")]
        public void ThenTheResponseBodyShouldIncorporateADocumentWithTheFollowingDetails(Table table)
        {
            var expectedVals = new Dictionary<string, string>();
            string jsonString = "{}";
            foreach (var row in table.Rows)
            {
                jsonString = JsonHelper.AddPropertyToJsonString(jsonString, row[0], row[1]);
               // expectedVals.Add(row[0], row[1]);
            }
            JsonHelper.MatchDocument(jsonString, response.Content).Should().BeTrue();
        }

        [Given(@"with an invalid subcontractorId")]
        public void GivenWithAnInvalidSubcontractorId()
        {
            //subContractorId = "123456789012345678901234567890123456789012345678901";
        }

        [Given(@"with an invalid customerId")]
        public void GivenWithAnInvalidCustomerId()
        {
            id = "zzz9zz9z-9999-99zz-9z99-9zz99z999zz9";
        }

        [Given(@"with an invalid interactionId")]
        public void GivenWithAnInvalidInteractionId()
        {
            interactionId = "153c7a4b-c7b2-4188-aed2-2e74c2fceb";
        }

        [Given(@"with an invalid sessionId")]
        public void GivenWithAnInvalidSessionId()
        {
            sessionId = "5ba962c8-1f46-4bd0-b2cd-ca17dbc38484";
        }


        [Then(@"there should be a (.*) response")]
        public void ThenThereShouldBeAResponse(int expectedResponseCode)
        {
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            numericStatusCode.Should().Be(expectedResponseCode);
        }

        [Then(@"the date field (.*) should hold a recent value")]
        public void ThenTheDateFieldShouldHoldARecentValue(string p0)
        {
            DateTime testDate;
            DateTime.TryParse(JsonHelper.GetPropertyFromJsonString(response.Content, p0), out testDate).Should().BeTrue("Because a date is expected in " + p0);
            testDate.Should().BeCloseTo(DateTime.Now, 60000, "Because " + JsonHelper.GetPropertyFromJsonString(response.Content, p0) + " should be a recent value");
            // THIS CONVERTS ALL DATE TO LOCAL TIME RATHER THAN UTC, BUT AS COMPARIING THEM THIS SHOULD BE OK
        }


        [Then(@"the response body should contain:")]
        public void ThenMyBindingShouldHaveTheFollowingObjects(Table table)
        {
            var expectedVals = new Dictionary<string, string>();
            var actualVals = new Dictionary<string, string>();
            actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            foreach (var row in table.Rows)
            {
                expectedVals.Add(row[0], row[1]);
            }
            string message = "";
            bool match = CheckResults(expectedVals, actualVals, out message);
            if (!match)
            {
                //output the dictionaries
                Console.WriteLine("Expected Results: ");
                foreach (var kv in expectedVals)
                {
                    Console.WriteLine("   " + kv.Key + " = " + kv.Value);
                }
                Console.WriteLine("Actual Results: ");
                foreach (var kv in actualVals)
                {
                    Console.WriteLine("   " + kv.Key + " = " + kv.Value);
                }
            }   

            match.Should().Be(true, "Because " + message);
        }


        [Then(@"all returned Customers should contain:")]
        public void ThenAllReturnedCustomersShouldContain(Table table)
        {
            var dictionary = ToDictionary(table);

            var fName = GetKey(dictionary, "FamilyName");
            var gName = GetKey(dictionary, "GivenName");
            var uln = GetKey(dictionary, "UniqueLearnerNumber");
            var dob = GetKey(dictionary, "DateOfBirth");

            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(response.Content);

            foreach (Customer c in customers)
            {
                if (!string.IsNullOrEmpty(gName)) { c.GivenName.ToLower().Contains(gName.ToLower()).Should().BeTrue(); }
                if (!string.IsNullOrEmpty(fName)) { c.FamilyName.ToLower().Contains(fName.ToLower()).Should().BeTrue(); }
                if (!string.IsNullOrEmpty(uln)) { c.UniqueLearnerNumber.ToLower().Contains(uln.ToLower()).Should().BeTrue(); }
                if (!string.IsNullOrEmpty(dob)) { c.DateofBirth.ToLower().Contains(dob.ToLower()).Should().BeTrue(); }

            }
        }

        [Then(@"the error message should be ""(.*)""")]
        public void ThenTheErrorMessageShouldBe(string expectedMessage)
        {
                   response.Content.Should().Contain(expectedMessage);
        }

        public bool CheckFamilyName(string name)
        {
            return true;
        }


        [When(@"I post a Customer with '(.*)' and  '(.*)' and '(.*)' and '(.*)'")]
        public void WhenIPostACustomerWithAndAndAnd(string GivenName, string FamilyName, string DateofBirth, string UniqueLearnerNumber)
        {
            url = envSettings.BaseUrl + "customers/api/customers/";
            var customer = new Customer();
            customer.GivenName = GivenName;
            customer.FamilyName = FamilyName;
            customer.DateofBirth = DateofBirth;
            customer.UniqueLearnerNumber = UniqueLearnerNumber;
            json = JsonConvert.SerializeObject(customer);
            response = RestHelper.Post(constants.Subscriptions, url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);

            id = AssertAndExtract("CustomerId", response);
            /*if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                id = actualVals["CustomerId"];
            }*/
        }

        [Then(@"the response body should contain the SubContractorId")]
        public void ThenTheResponseBodyShouldContainTheSubContractorId()
        {
            response.Content.Should().Contain(ScenarioContext.Current.Get<string>("subcontractorId"));
        }

        [Then(@"the response body should contain the SessionId")]
        public void ThenTheResponseBodyShouldContainTheSessionId()
        {
            response.Content.Should().Contain(sessionId);
        }

        [Then(@"the response body should have (.*) with value (.*)")]
        public void ThenTheResponseBodyShouldHaveFieldWithValue(string p0, string p1)
        {
            if ( p0.Contains("Date"))
            {
                p1 = SpecflowHelper.TranslateDateToken(p1).ToString("yyyy-MM-ddTHH:mm:ssZ");
            }
            JsonHelper.GetPropertyFromJsonString(response.Content, p0).Should().Be(p1);
        }

        [Then(@"the response body should not contain the ""(.*)""")]
        public void ThenTheResponseBodyShouldNotContainThe(string p0)
        {
            response.Content.Should().NotContain(p0);
        }

        [Then(@"the response body should include (.*)")]
        public void ThenTheResponseBodyShouldinclude(string p0)
        {
            response.Content.Should().Contain(p0);
        }

        [Then(@"the response body should have different LastUpdatedBy")]
        public void ThenTheResponseBodyShouldHaveDifferentLastUpdatedBy()
        {
            Table tempTable = new Table( new string[]{ "Field", "Value" } );
            tempTable.AddRow(new Dictionary<string, string>()
                                {
                                    // goals uses different field name for last modified by, so check if last ID was a goal and use appropriate field name
                                     { "Field", ( goalId == id ? "LastModifiedBy" : "LastModifiedTouchpointId" ) }
                                    ,{ "Value", lastTouchpoint }
                                } 
                            );

            ThenMyBindingShouldHaveTheFollowingObjects(tempTable);
        }

      



        [Then(@"the ""(.*)"" cosmos document should include CreatedBy")]
        public void ThenTheCosmosDocumentShouldIncludeCreatedBy(string p0)
        {
            string docJson = "";
            // retreive the cosmos document relating to the last request
            Console.WriteLine("CreatedBy check. Initialising cosmosdb connection object for: " + creatingTouchpoint);

            try
            {
                CosmosHelper.Initialise(envSettings.CosmosEndPoint, envSettings.CosmosAccountKey);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to initialise:  " + e.Message);
            }
            

            try
            {
                docJson = CosmosHelper.RetrieveDocument(p0, p0, id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to retrieve " + p0 + " document with id " + id + " from end point: " + envSettings.CosmosEndPoint);
                Console.WriteLine(e.Message);
            }

            docJson.Length.Should().BeGreaterThan(0, "Because zero length document means the call to CosmosDB was unsuccessful");
            // determine the touchpoint used in the post
            // check createdby field is present with expected value
            //JObject docJsonObj = JObject.Parse(docJson);
            JsonHelper.GetPropertyFromJsonString(docJson,"CreatedBy").Should().Be(creatingTouchpoint, "Because CreatedBy should exist in collection with value " + creatingTouchpoint);


        }



        [Then(@"the ""(.*)"" cosmos document should have ""(.*)"" with value ""(.*)""")]
        public void ThenTheCosmosDocumentShouldIncludeWithValue(string p0, string p1, string p2)
        {
            string docJson = "";
            // retreive the cosmos document relating to the last request
            Console.WriteLine("Cosmos value check (" + p1 + "). Initialising cosmosdb connection objet for: " + envSettings.CosmosEndPoint);

            try
            {
                CosmosHelper.Initialise(envSettings.CosmosEndPoint, envSettings.CosmosAccountKey);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to initialise:  " + e.Message);
            }


            try
            {
                docJson = CosmosHelper.RetrieveDocument(p0, p0, id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to retrieve " + p0 + " document with id " + id + " from end point: " + envSettings.CosmosEndPoint);
                Console.WriteLine(e.Message);
            }

            docJson.Length.Should().BeGreaterThan(0, "Because zero length document means the call to Cosmos was unsuccessful");
            // determine the touchpoint used in the post
            // check createdby field is present with expected value
            //JObject docJsonObj = JObject.Parse(docJson);
            JsonHelper.GetPropertyFromJsonString(docJson, p1).Should().Be(p2, "Because " + p1 + " should exist in collection with value " + p2);

        }



        public bool CompareX<TKey, TValue>(
        Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2, out string errorMessage)
        {
            errorMessage = "";
            if (dict1 == dict2) return true;
            if ((dict1 == null) || (dict2 == null))
            {
                Console.WriteLine("Compare Dictionary: FALSE - null dictionary");
                return false;
            }
     /*       if (dict1.Count != dict2.Count)
            {
                Console.WriteLine("Compare Dictionary: FALSE - different number of records");
                return false;
            }
*/
            var valueComparer = EqualityComparer<TValue>.Default;

            foreach (var kvp in dict1)
            {
                TValue value2;
                bool ret  = true;
                string returnMessage = "";
                DateTime tmpTime,tmpTime1;
                if (!dict2.TryGetValue(kvp.Key, out value2)) ret = false;
                switch (kvp.Value.ToString().ToLower())
                {
                    // don't care about case for boolean values
                    case "true":
                    case "false":
                        if ( !kvp.Value.ToString().ToLower().Equals(value2.ToString().ToLower())) ret = false;
                        break;
                    default:
                        if (DateTime.TryParse(kvp.Value.ToString(), out tmpTime))
                        {
                            if (DateTime.TryParse(value2.ToString(), out tmpTime1))
                            {
                                tmpTime = new DateTime(tmpTime.Ticks - (tmpTime.Ticks % TimeSpan.TicksPerSecond), tmpTime.Kind);
                                tmpTime1 = new DateTime(tmpTime1.Ticks - (tmpTime1.Ticks % TimeSpan.TicksPerSecond), tmpTime1.Kind);
                                ret = tmpTime.Equals(tmpTime1);
                                errorMessage = "Check " + kvp.Key + " Value1: " + tmpTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + " [" + tmpTime.Ticks + "] Value2: " + tmpTime1.ToString("yyyy-MM-dd HH:mm:ss.fff" + " [" + tmpTime1.Ticks + "]");


                            }
                            else
                            {
                                errorMessage = "Date parse failed on" + kvp.Key + " (" + value2.ToString() + ")";
                                ret = false;
                            }

                        }
                        else if ((kvp.Value == null || kvp.Value.ToString() == string.Empty)
                                && (value2 == null || value2.ToString() == string.Empty))
                        {
                            ret = true;
                        }
                        else if (!valueComparer.Equals(kvp.Value, value2))
                        {
                            ret = false;
                            errorMessage = "Check " + kvp.Key + " Value1: " + kvp.Value + " Value2: " + value2;
                        }
                        break;
    
                }
                
                //if (!valueComparer.Equals(kvp.Value, value2)) ret =  false;
                if (!ret)
                {
                    Console.WriteLine("Compare Dictionary: FALSE " + errorMessage);
                    return false;
                }
            }
            return true;
        }

        [Then(@"a new notification should be received for ""(.*)""")]
        public void ThenANewNotificationShouldBeReceivedFor(string p0)
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"there should be a record in the (.*) ChangeFeed table")]
        public bool ThenThereShouldBeARecordInTheChangeFeedTable(string table)
        {
//            table = "dss-" + table;
            bool found = false;
            bool addSubcontractorIdToCollection = false;
            bool addCreatedByToCollection = false;
            bool addSessionIdToCollection = false;
            bool addClaimedPriorityGroup = false;
            bool historyTable = table.ToLower().Contains("history");
            string recordId;
            string historyTableId = "";
            string primaryTableId = "";
            string resource = "";
            SQLServerHelper helper = new SQLServerHelper();

            string orderBy = ( historyTable ? "CosmosTimeStamp DESC" : "");
            string timestampField = "LastModifiedDate";
            string timestampValue = "";
            string timestampComparison = "";
      //      table = table.ToLower();
            // get time of last response

            Console.WriteLine("Set up the variables for this change feed check");
            switch ( table.ToLower() ) 
            {
                case "actions":
                case "actions-history":
                    recordId = actionId;
                    addSubcontractorIdToCollection = true;
                    addCreatedByToCollection = true;
                    primaryTableId = "ActionId";
                    historyTableId = "Actions-historyId";
                    resource = constants.Actions;
                    break;
                case "actionplans":
                case "actionplans-history":
                    recordId = actionPlanId;
                    addSessionIdToCollection = true;
                    addSubcontractorIdToCollection = true;
                    addCreatedByToCollection = true;
                    primaryTableId = "ActionPlanId";
                    historyTableId = "ActionPlans-historyId";
                    resource = constants.ActionPlans;
                    break;
                case "sessions":
                case "sessions-history":
                    recordId = sessionId;
                    addSubcontractorIdToCollection = true;
                    addCreatedByToCollection = true;
                    primaryTableId = "SessionId";
                    historyTableId = "Sessions-historyId";
                    resource = constants.Sessions;
                    break;
                case "goals":
                case "goals-history":
                    recordId = goalId;
                    addSubcontractorIdToCollection = true;
                    addCreatedByToCollection = true;
                    primaryTableId = "GoalId";
                    historyTableId = "Goals-historyId";
                    resource = constants.Goals;
                    break;
                case "contacts":
                case "contacts-history":
                case "contactdetails":
                case "contactdetails-history":
                    recordId = contactId;
                    addSubcontractorIdToCollection = false;
                    primaryTableId = "ContactId";
                    historyTableId = "Contacts-historyId";
                    resource = constants.Contacts;
                    break;
                case "customers":
                case "customers-history":
                    recordId = customerId;
                    addSubcontractorIdToCollection = true;
                    addCreatedByToCollection = true;
                    primaryTableId = "CustomerId";
                    historyTableId = "Customers-historyId";
                    resource = constants.Customers;
                    break;
                case "diversitydetails":
                case "diversitydetails-history":
                    recordId = diversityId;
                    addSubcontractorIdToCollection = false;
                    addCreatedByToCollection = true;
                    primaryTableId = "DiversityId";
                    historyTableId = "Diversitydetails-historyId";
                    resource = constants.DiversityDetails;
                    break;
                case "addresses":
                case "addresses-history":
                    recordId = addressId;
                    addSubcontractorIdToCollection = true;
                    addCreatedByToCollection = true;
                    primaryTableId = "AddressId";
                    historyTableId = "Addresses-historyId";
                    resource = constants.Addresses;
                    break;
                case "adviserdetails":
                case "adviserdetails-history":
                    recordId = adviserDetailId;
                    addSubcontractorIdToCollection = true;
                    addCreatedByToCollection = true;
                    primaryTableId = "AdviserDetailId";
                    historyTableId = "AdviserDetails-historyId";
                    resource = constants.AdviserDetails;
                    break;
                case "outcomes":
                case "outcomes-history":
                    recordId = outcomeId;
                    addSubcontractorIdToCollection = true;
                    addCreatedByToCollection = true;
                    addSessionIdToCollection = true;
                    addClaimedPriorityGroup = true;
                    primaryTableId = "OutcomeId";
                    historyTableId = "Outcomes-historyId";
                    resource = constants.Outcomes;
                    break;
                case "interactions":
                case "interactions-history":
                    recordId = interactionId;
                    primaryTableId = "InteractionId";
                    historyTableId = "Interactions-historyId";
                    resource = constants.Interactions;
                    break;
                case "subscriptions":
                case "subscriptions-history":
                    recordId = subscriptionId;
                    primaryTableId = "SubscriptionId";
                    historyTableId = "Subscriptions-historyId";
                    resource = constants.Subscriptions;
                    break;
                case "transfers":
                case "transfers-history":
                    recordId = transferId;
                    primaryTableId = "TransferId";
                    historyTableId = "Transfers-historyId";
                    resource = constants.Transfers;
                    break;
                case "webchats":
                case "webchats-history":
                    recordId = webChatId;
                    primaryTableId = "WebChatId";
                    historyTableId = "WebChats-historyId";
                    resource = constants.WebChats;
                    break;
                default:
                    recordId = "";
                    break;
            }
            Console.WriteLine("Check we have a record ID to work on");
            recordId.Should().NotBeNullOrEmpty();
            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(requestContext.GetResponseContent(resource));
            timestampValue = values[timestampField];
            timestampComparison = timestampValue.Substring(0, 10) + "%" + timestampValue.Substring(11, ( timestampValue.Contains(".")? 11 : 8 ) ) + "%";
            helper.SetConnection(envSettings.sqlConnectionString);
            //   found = helper.DoesResourceExist("dss-" + table, this.GetType().GetField(constants.IdFromResource(table)).GetValue(this).ToString() );
            System.Data.DataSet dataSet = null;
            DateTime loopUntil = new DateTime();
            loopUntil = DateTime.Now.AddSeconds(20);
            while ( !found && DateTime.Now < loopUntil)
            {
                Console.WriteLine("Attempt to retrieve SQL record from " + table + " for id " + recordId);
                Console.WriteLine("historyTable flag value :" + (historyTable ? "true":"false") );
                Console.WriteLine("lastRequestWasPatch flag value :" + (lastRequestWasPatch ? "true" : "false"));
                Console.WriteLine("GetRecordCount return :" + helper.GetRecordCount("dss-" + table, recordId));
                if (!historyTable || !lastRequestWasPatch || helper.GetRecordCount("dss-" + table, recordId) > 1)
                {
                    
                    dataSet = helper.GetRecord("dss-" + table, recordId, orderBy, timestampField + " like " + "'" + timestampComparison + "'");
                    found = (dataSet.Tables[0].Rows.Count > 0);
                }
                //found = helper.DoesResourceExist("dss-" + table, recordId);
                System.Threading.Thread.Sleep( (found ? 0 : 2000) );
            }

            Console.WriteLine("Get number of records in history table for analysis: " + helper.GetRecordCount("dss-"  + historyTableId.Substring(0,historyTableId.Length - 2), recordId));

            found.Should().BeTrue("Because a record should exist in SQL stage DB for resource: " + table);
            if ( found)
            {
                
                string PrimaryKeyId = constants.IdFromResource(table);
                string PrimaryKeyCap = PrimaryKeyId.Substring(0, 1).ToUpper() + PrimaryKeyId.Substring(1);
                var dict = helper.GetDataTableDictionaryList(dataSet, PrimaryKeyCap);
                //dict[0]["id"].Remove(.Remove();

                // various factors affect what is present in the response data and the sql table data.
                // some tweaks to the dictionaries are required to ensure a like for like comparision can be acheived

                if (addSubcontractorIdToCollection && !values.Keys.Contains("SubcontractorId") )
                {
                    values.Add("SubcontractorId", "");
                }

                if (addCreatedByToCollection )
                {
                    bool addValue = (scenarioContext.ScenarioInfo.Tags.Contains<string>("postV2") || FeatureContext.Current.FeatureInfo.Tags.Contains<string>("postV2")
                                       || scenarioContext.ScenarioInfo.Tags.Contains<string>("postV3") || FeatureContext.Current.FeatureInfo.Tags.Contains<string>("postV3"));
                    values.Add("CreatedBy", (/*GetVersion() == "v2" */ addValue ? envSettings.TestEndpoint01 : "" ) );
                }

                if (table.ToLower().Contains("session"))
                {
                    bool addValue = (dict[0].Keys.Contains("Longitude") && dict[0]["Longitude"].Length > 0);////(scenarioContext.ScenarioInfo.Tags.Contains<string>("postV2") || FeatureContext.Current.FeatureInfo.Tags.Contains<string>("postV2"));
                    values.Add("Longitude", (/*GetVersion() == "v2" */ addValue ? dict[0]["Longitude"] : ""));
                    addValue = (dict[0].Keys.Contains("Latitude") && dict[0]["Latitude"].Length > 0);
                    values.Add("Latitude", (/*GetVersion() == "v2" */ addValue ? dict[0]["Latitude"] : ""));
                }

                if (table.ToLower().Contains("webchats"))
                {
                    string newDuration = dict[0]["WebChatDuration"];
                    newDuration = newDuration.Substring(11, 8);
                    dict[0]["WebChatDuration"] = newDuration;
                }
                
                if (addSessionIdToCollection && !values.Keys.Contains("SessionId"))
                {
                    values.Add("SessionId", "");
                }
                if (addClaimedPriorityGroup && !values.Keys.Contains("ClaimedPriorityGroup"))
                {
                    values.Add("ClaimedPriorityGroup", "");
                }

                if (historyTable)
                {
                    values.Add("CosmosTimeStamp", dict[0]["CosmosTimeStamp"]);
                    values.Add("HistoryId", dict[0]["HistoryId"]);
                    values.Add(historyTableId, dict[0][historyTableId]);
                    values.Remove(primaryTableId);
                }

                if (table == "goals-history")
                {
                    // temp workaround
                    values.Remove("LastModifiedBy");
                    values.Add("LastModifiedTouchpointId", dict[0]["LastModifiedTouchpointId"]);
                }

                // check all values in response are matched in dataset

                string errorMessage;
                found = CompareX<string, string>(dict[0], values, out errorMessage);

                if (!found)
                {
                    //output the dictionaries
                    Console.WriteLine("SQL Data: ");
                    foreach ( var kv in dict[0])
                    {
                        Console.WriteLine("   " + kv.Key + " = " + kv.Value);
                    }
                    Console.WriteLine("API Data: ");
                    foreach (var kv in values)
                    {
                        Console.WriteLine("   " + kv.Key + " = "  + kv.Value);
                    }
                }
                found.Should().BeTrue("because " + errorMessage);

                sqlData.Clear();
                foreach ( var kv in dict[0])
                {
                    sqlData.Add(kv.Key, kv.Value);
                }
            }
            return found;
        }

        [Then(@"the captured table data should include key ""(.*)"" with value ""(.*)""")]
        public void ThenTheCapturedTableDataShouldIncludeKeyWithValue(string p0, string p1)
        {
            sqlData.Keys.Contains(p0).Should().BeTrue("Because key " + p0 + " should be present in the SQL table");
            sqlData[p0].Should().Be(p1);
        }

        [Then(@"the last updated time should be later than the request time")]
        public void ThenTheLastUpdatedTimeShouldBeLaterThanTheRequestTime()
        {
            var keyValuePairs = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            DateTime lastUpdatedTime = DateTimeOffset.Parse(keyValuePairs["LastModifiedDate"]).UtcDateTime;
            Console.WriteLine("Check request time is before last update time");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("requestTime: " + requestTime.ToLongTimeString());
            Console.WriteLine("lastUpdateTime: " + lastUpdatedTime.ToLongTimeString());
            Console.WriteLine("Difference: " + (lastUpdatedTime - requestTime));
            Console.WriteLine("-------------------------------------------");
            ( requestTime - PostUpdateTime).Should().BePositive("Because the last modified time should be greater than the time the request was made");
        }



        private bool CheckResults(Dictionary<string, string> expectedVals, Dictionary<string, string> actualVals, out string errMessage)
        {
            errMessage = "";
            foreach (KeyValuePair<string, string> entry in expectedVals)
            {
                //is it in the table?
                bool result = false;
                if ((actualVals[entry.Key] == null && entry.Value == "null"))
                    { result = true; }
                else if (actualVals.ContainsKey(entry.Key) && actualVals[entry.Key] == null && entry.Value == "" )
                    { result = true; }
                else if (actualVals.ContainsKey(entry.Key) && actualVals[entry.Key].Equals(entry.Value))
                    { result = true; }

                if (result == false)
                {
                    errMessage = "Value mismatch for " + entry.Key + " - Expected: " + entry.Value + " Actual: " + (actualVals.Keys.Contains(entry.Key) ? actualVals[entry.Key] : "N / A");
                    return false;
                }
            }
            return true;
        }

        public static Dictionary<string, string> ToDictionary(Table table)

        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }

        public static string CheckForSpaces(string s)
        {
            string[] words = s.Split('+');
            return words[0];
        }

        private static string GetKey(IReadOnlyDictionary<string, string> dictValues, string keyValue)
        {
            return dictValues.ContainsKey(keyValue) ? dictValues[keyValue] : "";
        }

        private string getTouchPoint(string touchPoint)
        {
            switch (touchPoint)
            {
                case "TouchPoint1":
                    return envSettings.TestEndpoint01;
                case "TouchPoint2":
                    return envSettings.TestEndpoint02;
                case "TouchPoint3":
                    return envSettings.TestEndpoint03;
                default:
                    return envSettings.TestEndpoint01;
            }
        }
        
        private string GetVersion()
        {
            return ScenarioContext.Current["version"] as String;
        }

        private void SetVersion(string method, bool allowV3 = false)
        {
            /* *****************************************************************  */
            /* Check for versio related tags in feature and scenario context tags */
            /* ****************************************************************** */
            /* scenario tag takes precedence over feature tag                     */
            /* Construct tag names from passed in string "method" which correspo  */
            /* nds to the http verb                                               */

            bool problem = true;
            if (scenarioContext.ScenarioInfo.Tags.Contains<string>(method + "V1"))
            {
                ScenarioContext.Current["version"] = "v1";
            }
            else if (scenarioContext.ScenarioInfo.Tags.Contains<string>(method + "V2"))
            {
                ScenarioContext.Current["version"] = "v2";
            }
            else if (scenarioContext.ScenarioInfo.Tags.Contains<string>(method + "V3"))
            {
                ScenarioContext.Current["version"] = (allowV3 ? "v3" : "v2" );
            }
            else if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>(method + "V1"))
            {
                ScenarioContext.Current["version"] = "v1";
            }
            else if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>(method + "V2"))
            {
                ScenarioContext.Current["version"] = "v2";
            }
            else if ( FeatureContext.Current.FeatureInfo.Tags.Contains<string>(method + "V3"))
            {
                ScenarioContext.Current["version"] = (allowV3 ?  "v3" : "v2");
            }
            else
            {
                problem.Should().BeFalse("Because the version tag has not been defined in this feature");
            }
        }
 

        private void ResetVersion()
        {
            ScenarioContext.Current["version"] = "v1";
        }
    }
}
