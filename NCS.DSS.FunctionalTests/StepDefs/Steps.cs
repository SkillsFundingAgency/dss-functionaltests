using FluentAssertions;
using FunctionalTests.Helpers;
using FunctionalTests.Models;
using NCS.DSS.FunctionalTests.Helpers;
using NCS.DSS.FunctionalTests.Models;
using Newtonsoft.Json;
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
        private string transferId;

        public string actionId { get; set; }


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
            if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                customerId = actualVals["CustomerId"];
            }
        }

        [Given(@"I post a customer with the given name '(.*)'")]
        public void GivenIPostACustomerWithTheGivenName(string givenName)
        {
            SetVersion("post");
            url = envSettings.BaseUrl + "customers/api/customers/";
            var customer = new Customer();
            customer.GivenName = givenName;
            customer.FamilyName = "Smith";
            json = JsonConvert.SerializeObject(customer);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                customerId = actualVals["CustomerId"];
            }
        }


        [Given(@"I post an adviser with the following details:")]
        public void GivenIPostAnAdviserWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            url = envSettings.BaseUrl + "adviserdetails/api/AdviserDetails/";
            var adviser = table.CreateInstance<Adviser>();
            json = JsonConvert.SerializeObject(adviser);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                adviserDetailId = actualVals["AdviserDetailId"];
            }
        }

        [Given(@"I post an Interaction with the following details:")]
        public void GivenIPostAnInteractionWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "interactions/api/Customers/" + customerId + "/Interactions/";
            var interaction = table.CreateInstance<Interaction>();
            json = JsonConvert.SerializeObject(interaction);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> interactionDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                interactionId = interactionDictionary["InteractionId"];
            }
        }


        [Given(@"I post an Address with the following details:")]
        public void GivenIPostAnAddressWithTheFollowingDetails(Table table)
        {
            SetVersion("post");
            url = envSettings.BaseUrl + "addresses/api/Customers/" + customerId + "/Addresses/";
            var address = table.CreateInstance<Address>();
            json = JsonConvert.SerializeObject(address);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> addressDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                addressId = addressDictionary["AddressId"];
            }
        }

        [Given(@"I post a Contact with the following details:")]
        public void GivenIPostAContactWithTheFollowingDetails(Table table)
        {
            ScenarioContext.Current["version"] = "";
            url = envSettings.BaseUrl + "contactDetails/api/Customers/" + customerId + "/contactDetails/";
            var contact = table.CreateInstance<Contact>();
            json = JsonConvert.SerializeObject(contact);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> contactDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                contactId = contactDictionary["ContactId"];
            }

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
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionPlanId = dict["ActionPlanId"];
            }
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
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionId = dict["ActionId"];
            }
        }


        [When(@"I post a DiversityDetail with the following details:")]
        public void WhenIPostADiversityDetailWithTheFollowingDetails(Table table)
        {
            ScenarioContext.Current["version"] = "";
            url = envSettings.BaseUrl + "diversitydetails/api/Customers/" + customerId + "/DiversityDetails/";
            var diversity = table.CreateInstance<Diversity>();
            json = JsonConvert.SerializeObject(diversity);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionId = dict["DiversityId"];
            }
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
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                sessionId = dict["SessionId"];
            }
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
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                goalId = dict["GoalId"];
            }

        }

        [Given(@"I post a webchat with the following details:")]
        public void GivenIPostAWebchatWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "webchats/api/Customers/" + customerId + "/Interactions/" + interactionId + "/webchats/";
            var webchat = table.CreateInstance<WebChat>();
            json = JsonConvert.SerializeObject(webchat);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                webChatId = dict["WebChatId"];
            }
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
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                outcomeId = dict["OutcomeId"];
            }
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
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                transferId = dict["TransferId"];
            }

        }



        [Given(@"I post an subscription with the following details:")]
        public void GivenIPostASubscriptionWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "subscriptions/api/Customers/" + customerId + "/subscriptions/";
            var subscription = table.CreateInstance<Subscription>();
            json = JsonConvert.SerializeObject(subscription);
            response = RestHelper.Post(url, json, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                goalId = dict["SubscriptionId"];
            }
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

            response = RestHelper.Get(url, envSettings.TestEndpoint01, envSettings.SubscriptionKey);
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
            CheckResults(expectedVals, actualVals).Should().Be(true);
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
            if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                id = actualVals["CustomerId"];
            }
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


        public bool CompareX<TKey, TValue>(
        Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2)
        {
            if (dict1 == dict2) return true;
            if ((dict1 == null) || (dict2 == null)) return false;
            if (dict1.Count != dict2.Count) return false;

            var valueComparer = EqualityComparer<TValue>.Default;

            foreach (var kvp in dict1)
            {
                TValue value2;
                bool ret  = true;
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
                            }
                            else ret = false;

                        }
                        else if ( (kvp.Value == null || kvp.Value.ToString() == string.Empty )
                                && ( value2 == null || value2.ToString() == string.Empty ) ) 
                        {
                            ret = true;
                        }
                        else if (!valueComparer.Equals(kvp.Value, value2 ) ) ret = false;
                        break;
    
                }
                
                //if (!valueComparer.Equals(kvp.Value, value2)) ret =  false;
                if (!ret)
                {
                    return false;
                }
            }
            return true;
        }


        [Then(@"there should be a record in the (.*) ChangeFeed table")]
        public bool ThenThereShouldBeARecordInTheChangeFeedTable(string table)
        {
//            table = "dss-" + table;
            bool found = false;
            string recordId;
            SQLServerHelper helper = new SQLServerHelper();

            switch( table)
            {
                case "actions":
                    recordId = actionId;
                    break;
                case "actionPlans":
                    recordId = actionPlanId;
                    break;
                case "sessions":
                    recordId = sessionId;
                    break;
                case "goals":
                    recordId = goalId;
                    break;
                case "customers":
                    recordId = customerId;
                    break;
                case "addresses":
                    recordId = addressId;
                    break;
                case "adviserDetails":
                    recordId = adviserDetailId;
                    break;
                case "outcomes":
                    recordId = outcomeId;
                    break;
                default:
                    recordId = "";
                    break;
            }

            recordId.Should().NotBeNullOrEmpty();
            //var f = this.GetType();
            //var fff = this.;
            //var ff = f.GetField("actionId").GetValue(this).ToString();
            //var g = f.GetField("actionId",  BindingFlags.Instance).GetValue(this).ToString(); 
            
            //var field = this.GetType().GetField(constants.IdFromResource(table)).GetValue(this);
            helper.SetConnection(envSettings.sqlConnectionString);
            //   found = helper.DoesResourceExist("dss-" + table, this.GetType().GetField(constants.IdFromResource(table)).GetValue(this).ToString() );
            System.Data.DataSet dataSet = null;
            DateTime loopUntil = new DateTime();
            loopUntil = DateTime.Now.AddSeconds(8);
            while ( !found && DateTime.Now < loopUntil)
            {
                dataSet = helper.GetRecord("dss-" + table, recordId);
                found = ( dataSet.Tables[0].Rows.Count > 0 );
                //found = helper.DoesResourceExist("dss-" + table, recordId);
                System.Threading.Thread.Sleep( (found ? 0 : 2000) );
            }
            found.Should().BeTrue("Because a record should exist in SQL stage DB for this resource");
            if ( found)
            {
           //     var ds = helper.GetRecord("dss-" + table, recordId);
                string PrimaryKeyId = constants.IdFromResource(table);
                string PrimaryKeyCap = PrimaryKeyId.Substring(0, 1).ToUpper() + PrimaryKeyId.Substring(1);
                var dict = helper.GetDataTableDictionaryList(dataSet, PrimaryKeyCap);
                //dict[0]["id"].Remove(.Remove();
                // check all values in response are matched in dataset
                var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);

                found = CompareX<string, string>(dict[0], values);
                found.Should().BeTrue("because all SQL fields should match cosmos resource");
            }
            return found;
        }



        private bool CheckResults(Dictionary<string, string> expectedVals, Dictionary<string, string> actualVals)
        {
            foreach (KeyValuePair<string, string> entry in expectedVals)
            {
                //is it in the table?
                bool result = false;
                if ((actualVals[entry.Key] == null && entry.Value == "null") ||
                     (actualVals.ContainsKey(entry.Key) && actualVals[entry.Key].Equals(entry.Value))) { result = true; }
                if (result == false)
                {
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

        private void SetVersion(string method)
        {
            bool problem = true;
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

        }
 

        private void ResetVersion()
        {
            ScenarioContext.Current["version"] = "v1";
        }


    
    }
}