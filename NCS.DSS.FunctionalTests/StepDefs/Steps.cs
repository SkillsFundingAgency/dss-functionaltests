using FluentAssertions;
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
using Newtonsoft.Json.Linq;
using System.Threading;

namespace FunctionalTests.StepDefs
{
    [Binding]
    public class Steps
    {
        private EnvironmentSettings envSettings = new EnvironmentSettings();
        private IRestResponse response;
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
        private List<TestDataItem> loadedData = new List<TestDataItem>();
        Dictionary<string, string> sqlData = new Dictionary<string, string>();

        public string actionId { get; set; }
        private readonly ScenarioContext scenarioContext;

        public Steps(ScenarioContext context)
        {
            scenarioContext = context;
            
        }
        string AssertAndExtract(string key, IRestResponse response)
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
                loadedData.Add(new TestDataItem(key, extractedValue));
                scenarioContext["TestData"] = loadedData;
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

        [Given(@"I post a Customer with the following details:")]
        public void GivenIPostACustomerWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            var customer = new object();
            url = envSettings.BaseUrl + "customers/api/customers/";
            if (ScenarioContext.Current["version"].Equals("v2"))
            {
                customer = table.CreateInstance<CustomerV2>();
            }
            else
            {
                customer = table.CreateInstance<Customer>();
            }

            json = JsonConvert.SerializeObject(customer);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            customerId = AssertAndExtract("CustomerId", response);
            /*if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                customerId = actualVals["CustomerId"];
            }

            url = envSettings.BaseUrl + "customers/api/customers/";
            var customer = table.CreateInstance<Customer>();
            json2 = JsonConvert.SerializeObject(customer);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            customerId = AssertAndExtract("CustomerId", response);*/

            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    customerId = actualVals["CustomerId"];
            //    Console.WriteLine("Storing context information:" + customerId + " - " + customerId);
            //}
            //else
            //{
            //    Console.WriteLine("Request was unsuccessful" );
            //    Console.WriteLine("response status: " + response.StatusCode);
            //    Console.WriteLine("response message: " + response.ErrorMessage);
            //    Console.WriteLine("response expection: " + response.ErrorException);
            //}
            

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
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            customerId = AssertAndExtract("CustomerId", response);
            /*if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                customerId = actualVals["CustomerId"];
            }*/
        }


        [Given(@"I post an adviser with the following details:")]
        public void GivenIPostAnAdviserWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            url = envSettings.BaseUrl + "adviserdetails/api/AdviserDetails/";
            var adviser = table.CreateInstance<Adviser>();
            json2 = JsonConvert.SerializeObject(adviser);
            response = RestHelper.Post(url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            adviserDetailId = AssertAndExtract("AdviserDetailId", response);
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    adviserDetailId = actualVals["AdviserDetailId"];
            //    Console.WriteLine("Storing context information:" + adviserDetailId + " - " + adviserDetailId);
            //}
            //else
            //{
            //    Console.WriteLine("Request was unsuccessful");
            //    Console.WriteLine("response status: " + response.StatusCode);
            //    Console.WriteLine("response message: " + response.ErrorMessage);
            //    Console.WriteLine("response expection: " + response.ErrorException);
            //}
        }

        [Given(@"I post an Interaction with the following details:")]
        public void GivenIPostAnInteractionWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "interactions/api/Customers/" + customerId + "/Interactions/";
            var interaction = table.CreateInstance<Interaction>();

  //          if (interaction.AdviserDetailsId is null && adviserDetailId.Length > 0 )
  //            {
  //              interaction.AdviserDetailsId = adviserDetailId;
  //          }
            json2 = JsonConvert.SerializeObject(interaction);
            response = RestHelper.Post(url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            interactionId = AssertAndExtract("InteractionId", response);
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> interactionDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    interactionId = interactionDictionary["InteractionId"];
            //}
        }


        [Given(@"I post an Address with the following details:")]
        public void GivenIPostAnAddressWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            url = envSettings.BaseUrl + "addresses/api/Customers/" + customerId + "/Addresses/";
            var address = table.CreateInstance<Address>();
            json2 = JsonConvert.SerializeObject(address);
            response = RestHelper.Post(url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            addressId = AssertAndExtract("AddressId", response);
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> addressDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    addressId = addressDictionary["AddressId"];
            //}
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
            url = envSettings.BaseUrl + "contactDetails/api/Customers/" + customerId + "/contactDetails/";
            var contact = table.CreateInstance<Contact>();
            json2 = JsonConvert.SerializeObject(contact);
            response = RestHelper.Post(url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            contactId = AssertAndExtract("ContactId", response);
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> contactDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    contactId = contactDictionary["ContactId"];
            //}
        }


        [Given(@"I post an ActionPlan with the following details:")]
        public void GivenIPostAnActionPlanWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            var actionPlan = new Object();
            url = envSettings.BaseUrl + "actionplans/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/";

            if (ScenarioContext.Current["version"].Equals("v2"))
            {
                actionPlan = table.CreateInstance<ActionPlanV2>();
                actionPlan.As<ActionPlanV2>().SessionId = sessionId;
            }
            else
            {
                actionPlan = table.CreateInstance<ActionPlan>();
            }

            json = JsonConvert.SerializeObject(actionPlan);

            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            actionPlanId = AssertAndExtract("ActionPlanId", response);
            id = actionPlanId;
            /*if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionPlanId = dict["ActionPlanId"];
            }

            var actionPlan = table.CreateInstance<ActionPlan>();
            json2 = JsonConvert.SerializeObject(actionPlan);
            response = RestHelper.Post(url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            actionPlanId = AssertAndExtract("ActionPlanId", response);*/
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    actionPlanId = dict["ActionPlanId"];
            //}
        }






        [Given(@"I post an Action with the following details:")]
        public void GivenIPostAnActionWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            var action = new object();
            url = envSettings.BaseUrl + "actions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/actions/";
            if (ScenarioContext.Current["version"].Equals("v2"))
            {
                action = table.CreateInstance<ActionV2>();
            }
            else
            {
                action = table.CreateInstance<NCS.DSS.FunctionalTests.Models.Action>();
            }

            json = JsonConvert.SerializeObject(action);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            actionId = AssertAndExtract("ActionId", response);
            id = actionId;
            /*
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionId = dict["ActionId"];
            }

            var action = table.CreateInstance<NCS.DSS.FunctionalTests.Models.Action>();
            json2 = JsonConvert.SerializeObject(action);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            actionId = AssertAndExtract("ActionId", response);*/
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    actionId = dict["ActionId"];
            //}
        }


        [When(@"I post a DiversityDetail with the following details:")]
        public void WhenIPostADiversityDetailWithTheFollowingDetails(Table table)
        {
            ScenarioContext.Current["version"] = "";
            url = envSettings.BaseUrl + "diversitydetails/api/Customers/" + customerId + "/DiversityDetails/";
            var diversity = table.CreateInstance<Diversity>();
            json2 = JsonConvert.SerializeObject(diversity);
            response = RestHelper.Post(url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            diversityId = AssertAndExtract("DiversityId", response);
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    actionId = dict["DiversityId"];
            //}
        }


        [Given(@"I post a session with the following details:")]
            public void GivenIPostASessionWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            url = envSettings.BaseUrl + "sessions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/sessions/";

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
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            sessionId = AssertAndExtract("SessionId", response);
            id = sessionId;
            /*
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                sessionId = dict["SessionId"];
            }
        
            var session = table.CreateInstance<Session>();
            json2 = JsonConvert.SerializeObject(session);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            sessionId = AssertAndExtract("SessionId", response);*/
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    sessionId = dict["SessionId"];
            //}
        }


        [Given(@"I post a goal with the following details:")]
        public void GivenIPostAGoalWithTheFollowingDetails(Table table)
        {
            SetVersion("post");

            url = envSettings.BaseUrl + "goals/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/goals/";

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
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            goalId = AssertAndExtract("GoalId", response);

            /*
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                goalId = dict["GoalId"];
            }
            var goal = table.CreateInstance<Goal>();
            json2 = JsonConvert.SerializeObject(goal);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            goalId = AssertAndExtract("GoalId", response);*/
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    goalId = dict["GoalId"];
            //}

        }

        [Given(@"I post a webchat with the following details:")]
        public void GivenIPostAWebchatWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "webchats/api/Customers/" + customerId + "/Interactions/" + interactionId + "/webchats/";
            var webchat = table.CreateInstance<WebChat>();
            json2 = JsonConvert.SerializeObject(webchat);
            response = RestHelper.Post(url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            webChatId = AssertAndExtract("WebChatId", response);
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    webChatId = dict["WebChatId"];
            //}
        }

        [Given(@"I post an outcome with the following details:")]
        public void GivenIPostAnOutcomeWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            var outcome = new object();
            url = envSettings.BaseUrl + "outcomes/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/outcomes/";

            if (ScenarioContext.Current["version"].Equals("v2"))
            {
                outcome = table.CreateInstance<OutcomeV2>();
                outcome.As<OutcomeV2>().SessionId = sessionId;
            }
            else
            {
                outcome = table.CreateInstance<Outcome>();
            }

            json = JsonConvert.SerializeObject(outcome);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            outcomeId = AssertAndExtract("OutcomeId", response);
            id = outcomeId;
            /*
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                outcomeId = dict["OutcomeId"];
            }
            var outcome = table.CreateInstance<Outcome>();
            json2 = JsonConvert.SerializeObject(outcome);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            outcomeId = AssertAndExtract("OutcomeId", response);*/
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    outcomeId = dict["OutcomeId"];
            //}
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
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            transferId = AssertAndExtract("TransferId", response);
            /*if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                transferId = dict["TransferId"];
            }*/

        }

        [Given(@"I post a new subscription request")]
        public void GivenIPostANewSubscriptionRequest()
        {
            url = envSettings.BaseUrl + "subscriptions/api/Customers/" + customerId + "/subscriptions/";
            json2 = "{ \"subscribe\": true }";
            response = RestHelper.Post(url, json2, envSettings.TestEndpoint02, envSettings.SubscriptionKey);
            subscriptionId = AssertAndExtract("SubscriptionId", response);
        }


        [Given(@"I post an subscription with the following details:")]
        public void GivenIPostASubscriptionWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "subscriptions/api/Customers/" + customerId + "/subscriptions/";
            var subscription = table.CreateInstance<Subscription>();
            json2 = JsonConvert.SerializeObject(subscription);
            response = RestHelper.Post(url, json2, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            subscriptionId = AssertAndExtract("SubscriptionId", response);
            //if (response.IsSuccessful)
            //{
            //    Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            //    goalId = dict["SubscriptionId"];
            //}
        }




        [When(@"I patch the following:")]
        public void WhenIPatchTheFollowing(Table table)
        {
            SetVersion("patch");    
            Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            id = dict.FirstOrDefault().Value;
            Dictionary<string, string> patchVals = table.Rows.ToDictionary(r => r["Field"], r => r["Value"]);
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("SessionId"))
            {
                patchVals.Add("SessionId", sessionId);
            }
            json = JsonConvert.SerializeObject(patchVals);
            response = RestHelper.Patch(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey, id);

        }



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
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);

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

        [Then(@"the response body should not contain the ""(.*)""")]
        public void ThenTheResponseBodyShouldNotContainThe(string p0)
        {
            response.Content.Should().NotContain(p0);
        }




        [Then(@"the ""(.*)"" cosmos document should include CreatedBy")]
        public void ThenTheCosmosDocumentShouldIncludeCreatedBy(string p0)
        {
            string docJson = "";
            // retreive the cosmos document relating to the last request
            CosmosHelper.Initialise(envSettings.CosmosEndPoint, envSettings.CosmosAccountKey);

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
            JsonHelper.GetPropertyFromJsonString(docJson,"CreatedBy").Should().Be(envSettings.TestEndpoint01,"Because CreatedBy should exist in collection with value " + envSettings.TestEndpoint01);


        }



        [Then(@"the ""(.*)"" cosmos document should include ""(.*)"" with value ""(.*)""")]
        public void ThenTheCosmosDocumentShouldIncludeWithValue(string p0, string p1, string p2)
        {
            string docJson = "";
            // retreive the cosmos document relating to the last request
            CosmosHelper.Initialise(envSettings.CosmosEndPoint, envSettings.CosmosAccountKey);

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
                                returnMessage = "Check " + kvp.Key + " Value1: " + tmpTime + " Value2: " + tmpTime1;
                                
                            }
                            else
                            {
                                returnMessage = "Date parse failed on" + kvp.Key + " (" + value2.ToString() + ")";
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
            SQLServerHelper helper = new SQLServerHelper();

            string orderBy = ( historyTable ? "CosmosTimeStamp DESC" : "");
            string timestampField = "LastModifiedDate";
            string timestampValue = "";
            string timestampComparison = "";
            // get time of last response

            Console.WriteLine("Set up the variables for this change feed check");
            switch ( table ) 
            {
                case "actions":
                case "actions-history":
                    recordId = actionId;
                    addSubcontractorIdToCollection = true;
                    primaryTableId = "ActionId";
                    historyTableId = "Actions-historyId";
                    break;
                case "actionPlans":
                case "actionPlans-history":
                    recordId = actionPlanId;
                    addSessionIdToCollection = true;
                    addSubcontractorIdToCollection = true;
                    addCreatedByToCollection = true;
                    primaryTableId = "ActionPlanId";
                    historyTableId = "ActionPlans-historyId";
                    break;
                case "sessions":
                case "sessions-history":
                    recordId = sessionId;
                    addSubcontractorIdToCollection = true;
                    addCreatedByToCollection = true;
                    primaryTableId = "SessionId";
                    historyTableId = "Sessions-historyId";
                    break;
                case "goals":
                case "goals-history":
                    recordId = goalId;
                    addSubcontractorIdToCollection = true;
                    primaryTableId = "GoalId";
                    historyTableId = "Goals-historyId";
                    break;
                case "contacts":
                case "contacts-history":
                    recordId = contactId;
                    addSubcontractorIdToCollection = false;
                    primaryTableId = "ContactId";
                    historyTableId = "Contacts-historyId";
                    break;
                case "customers":
                case "customers-history":
                    recordId = customerId;
                    addSubcontractorIdToCollection = true;
                    primaryTableId = "CustomerId";
                    historyTableId = "Customers-historyId";
                    break;
                case "diversitydetails":
                case "diversitydetails-history":
                    recordId = diversityId;
                    addSubcontractorIdToCollection = false;
                    primaryTableId = "DiversityId";
                    historyTableId = "Diversitydetails-historyId";
                    break;
                case "addresses":
                case "addresses-history":
                    recordId = addressId;
                    addSubcontractorIdToCollection = true;
                    primaryTableId = "AddressId";
                    historyTableId = "Addresses-historyId";
                    break;
                case "adviserDetails":
                case "adviserDetails-history":
                    recordId = adviserDetailId;
                    addSubcontractorIdToCollection = true;
                    primaryTableId = "AdviserDetailId";
                    historyTableId = "AdviserDetails-historyId";
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
                    break;
                case "interactions":
                case "interactions-history":
                    recordId = interactionId;
                    primaryTableId = "InteractionId";
                    historyTableId = "Interactions-historyId";
                    break;
                case "subscriptions":
                case "subscriptions-history":
                    recordId = subscriptionId;
                    primaryTableId = "SubscriptionId";
                    historyTableId = "Subscriptions-historyId";
                    break;
                case "transfers":
                case "transfers-history":
                    recordId = transferId;
                    primaryTableId = "TransferId";
                    historyTableId = "Transfers-historyId";
                    break;
                case "webchats":
                case "webchats-history":
                    recordId = webChatId;
                    primaryTableId = "WebChatId";
                    historyTableId = "Webchats-historyId";
                    break;
                default:
                    recordId = "";
                    break;
            }
            Console.WriteLine("Check we have a record ID to work on");
            recordId.Should().NotBeNullOrEmpty();
            //var f = this.GetType();
            //var fff = this.;
            //var ff = f.GetField("actionId").GetValue(this).ToString();
            //var g = f.GetField("actionId",  BindingFlags.Instance).GetValue(this).ToString(); 

            //var field = this.GetType().GetField(constants.IdFromResource(table)).GetValue(this);

            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
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
                dataSet = helper.GetRecord("dss-" + table, recordId, orderBy, timestampField + " like " + "'" + timestampComparison + "'");
                found = ( dataSet.Tables[0].Rows.Count > 0 );
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
                    bool addValue = (scenarioContext.ScenarioInfo.Tags.Contains<string>("postV2") || FeatureContext.Current.FeatureInfo.Tags.Contains<string>("postV2"));
                    values.Add("CreatedBy", (/*GetVersion() == "v2" */ addValue ? envSettings.TestEndpoint01 : "" ) );
                }

                if (table.Contains("session"))
                {
                    bool addValue = (dict[0].Keys.Contains("Longitude") && dict[0]["Longitude"].Length > 0);////(scenarioContext.ScenarioInfo.Tags.Contains<string>("postV2") || FeatureContext.Current.FeatureInfo.Tags.Contains<string>("postV2"));
                    values.Add("Longitude", (/*GetVersion() == "v2" */ addValue ? dict[0]["Longitude"] : ""));
                    addValue = (dict[0].Keys.Contains("Latitude") && dict[0]["Latitude"].Length > 0);
                    values.Add("Latitude", (/*GetVersion() == "v2" */ addValue ? dict[0]["Latitude"] : ""));
                }

                if (table.Contains("webchats"))
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
            else if (allowV3 && scenarioContext.ScenarioInfo.Tags.Contains<string>(method + "V3"))
            {
                ScenarioContext.Current["version"] = "v3";
            }
            else if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>(method + "V1"))
            {
                ScenarioContext.Current["version"] = "v1";
            }
            else if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>(method + "V2"))
            {
                ScenarioContext.Current["version"] = "v2";
            }
            else if (allowV3 && FeatureContext.Current.FeatureInfo.Tags.Contains<string>(method + "V3"))
            {
                ScenarioContext.Current["version"] = "v3";
            }
            else
            {
                problem.Should().BeFalse("Because the version tag has not been defined in this feature");
            }

/*
            
            switch (method)
            {
                case "post":
                    if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>("postV1"))
                    {
                        ScenarioContext.Current["version"] = "v1";
                    }
                    else if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>("postV2"))
                    {
                        ScenarioContext.Current["version"] = "v2";
                    }
                    else if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>("postV3"))
                    {
                        ScenarioContext.Current["version"] = "v3";
                    }
                    else
                    {
                        problem.Should().BeFalse("Because the version tag has not been defined in this feature");
                    }
                    break;

                case "patch":
                    if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>("patchV1"))
                    {
                        ScenarioContext.Current["version"] = "v1";
                    }
                    else if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>("patchV2"))
                    {
                        ScenarioContext.Current["version"] = "v2";
                    }
                    else
                    {
                        problem.Should().BeFalse("Because the version tag has not been defined in this feature");
                    }
                    break;

                case "get":
                    if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>("getV1"))
                    {
                        ScenarioContext.Current["version"] = "v1";
                    }
                    else if (FeatureContext.Current.FeatureInfo.Tags.Contains<string>("getV2"))
                    {
                        ScenarioContext.Current["version"] = "v2";
                    }
                    else
                    {
                        problem.Should().BeFalse("Because the version tag has not been defined in this feature");
                    }
                    break;
                default:
                    break;
            }
            */
        }
 

        private void ResetVersion()
        {
            ScenarioContext.Current["version"] = "v1";
        }


    
    }
}