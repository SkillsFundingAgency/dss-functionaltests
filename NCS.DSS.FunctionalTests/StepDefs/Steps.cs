using FluentAssertions;
using FunctionalTests.Helpers;
using FunctionalTests.Models;
using NCS.DSS.FunctionalTests.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Configuration;
using Newtonsoft.Json.Linq;



namespace FunctionalTests.StepDefs
{
    [Binding]
    public class Steps
    {
        private EnvironmentSettings envSettings = new EnvironmentSettings();
        private readonly RestHelper Rest = new RestHelper();
        private IRestResponse response;
        private string url;
        private string json2;
        private string customerId;
        private string adviserDetailId;
        private string addressId;
        private string contactId;
        private string interactionId;
        private string actionPlanId;
        private string actionId;
        private string sessionId;
        private string goalId;
        private string outcomeId;
        private string webChatId;



        [Given(@"I post a Customer with the following details:")]
        public void GivenIPostACustomerWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "customers/api/customers/";
            var customer = table.CreateInstance<Customer>();
            json2 = JsonConvert.SerializeObject(customer);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                customerId = actualVals["CustomerId"];
            }
        }




        [Given(@"I post an adviser with the following details:")]
        public void GivenIPostAnAdviserWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "adviserdetails/api/AdviserDetails";
            var adviser = table.CreateInstance<Adviser>();
            json2 = JsonConvert.SerializeObject(adviser);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
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
            json2 = JsonConvert.SerializeObject(interaction);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> interactionDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                interactionId = interactionDictionary["InteractionId"];
            }
        }

        [Given(@"I post an Address with the following details:")]
        public void GivenIPostAnAddressWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "addresses/api/Customers/" + customerId + "/Addresses/";
            var address = table.CreateInstance<Address>();
            json2 = JsonConvert.SerializeObject(address);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> addressDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                addressId = addressDictionary["AddressId"];
            }
        }

        [Given(@"I post a Contact with the following details:")]
        public void GivenIPostAContactWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "contactDetails/api/Customers/" + customerId + "/contactDetails/";
            var contact = table.CreateInstance<Contact>();
            json2 = JsonConvert.SerializeObject(contact);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> contactDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                contactId = contactDictionary["ContactId"];
            }
        }


        [Given(@"I post an ActionPlan with the following details:")]
        public void GivenIPostAnActionPlanWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "actionplans/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/";
            var actionPlan = table.CreateInstance<ActionPlan>();
            json2 = JsonConvert.SerializeObject(actionPlan);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionPlanId = dict["ActionPlanId"];
            }
        }

        [Given(@"I post an Action with the following details:")]
        public void GivenIPostAnActionWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "actions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/actions/";
            var action = table.CreateInstance<NCS.DSS.FunctionalTests.Models.Action>();
            json2 = JsonConvert.SerializeObject(action);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionId = dict["ActionId"];
            }
        }


        [When(@"I post a DiversityDetail with the following details:")]
        public void WhenIPostADiversityDetailWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "diversitydetails/api/Customers/" + customerId + "/DiversityDetails/";
            var diversity = table.CreateInstance<Diversity>();
            json2 = JsonConvert.SerializeObject(diversity);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionId = dict["DiversityId"];
            }
        }


        [Given(@"I post a session with the following details:")]
        public void GivenIPostASessionWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "sessions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/sessions/";
            var session = table.CreateInstance<Session>();
            json2 = JsonConvert.SerializeObject(session);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                sessionId = dict["SessionId"];
            }
        }


        [Given(@"I post a goal with the following details:")]
        public void GivenIPostAGoalWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "goals/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/goals/";
            var goal = table.CreateInstance<Goal>();
            json2 = JsonConvert.SerializeObject(goal);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
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
            json2 = JsonConvert.SerializeObject(webchat);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                webChatId = dict["WebChatId"];
            }
        }

        [Given(@"I post an outcome with the following details:")]
        public void GivenIPostAnOutcomeWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "outcomes/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/outcomes/";
            var outcome = table.CreateInstance<Outcome>();
            json2 = JsonConvert.SerializeObject(outcome);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                outcomeId = dict["OutcomeId"];
            }
        }

        [Given(@"I post an subscription with the following details:")]
        public void GivenIPostASubscriptionWithTheFollowingDetails(Table table)
        {
            url = envSettings.BaseUrl + "subscriptions/api/Customers/" + customerId + "/subscriptions/";
            var subscription = table.CreateInstance<Subscription>();
            json2 = JsonConvert.SerializeObject(subscription);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                goalId = dict["SubscriptionId"];
            }
        }




        [When(@"I patch the following:")]
        public void WhenIPatchTheFollowing(Table table)
        {
            Dictionary<string, string> customer = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            customerId = customer.FirstOrDefault().Value;
            Dictionary<string, string> x = table.Rows.ToDictionary(r => r["Field"], r => r["Value"]);
            json2 = JsonConvert.SerializeObject(x);
            response = RestHelper.Patch(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey, customerId);

        }



        //[When(@"I get a Customer by ID")]
        //public async void WhenIGetACustomerByID()
        //{
        //    url = baseUrl + "customers/api/customers/" + customerId;
        //    response = await RestHelper.GetAsync(url);
        //}

        [When(@"I get a Customer by ID")]
        public void WhenIGetACustomerByID()
        {
            url = envSettings.BaseUrl + "customers/api/customers/" + customerId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
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

            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
        }


        [When(@"I get an Action by ID")]
        public void WhenIGetAnActionByID()
        {
            url = envSettings.BaseUrl + "actions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/actions/" + actionId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
        }


        [When(@"I get an ActionPlan by ID")]
        public void WhenIGetAnActionPlanByID()
        {
            url = envSettings.BaseUrl + "actionplans/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
        }

        [When(@"I get an Address by ID")]
        public void WhenIGetAnAddressByID()
        {
            url = envSettings.BaseUrl + "addresses/api/Customers/" + customerId + "/Addresses/" + addressId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
        }

        [When(@"I get an Adviser by ID")]
        public void WhenIGetAnAdviserByID()
        {
            url = envSettings.BaseUrl + "adviserdetails/api/AdviserDetails/" + adviserDetailId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
        }

        [When(@"I get a Contact by ID")]
        public void WhenIGetAContactByID()
        {
            url = envSettings.BaseUrl + "contactDetails/api/Customers/" + customerId + "/contactDetails/" + contactId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
        }

        [When(@"I get a Goal by ID")]
        public void WhenIGetAGoalByID()
        {
            url = envSettings.BaseUrl + "goals/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/goals/" + goalId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
        }

        [When(@"I get an Interaction by ID")]
        public void WhenIGetAnInteractionByID()
        {
            url = envSettings.BaseUrl + "interactions/api/Customers/" + customerId + "/Interactions/" + interactionId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
        }

        [When(@"I get an Outcome by ID")]
        public void WhenIGetAnOutcomeByID()
        {
            url = envSettings.BaseUrl + "outcomes/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/outcomes/" + outcomeId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
        }

        [When(@"I get a Session by ID")]
        public void WhenIGetASessionByID()
        {
            url = envSettings.BaseUrl + "sessions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/sessions/" + sessionId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
        }

        [When(@"I get a WebChat by ID")]
        public void WhenIGetAWebChatByID()
        {
            url = envSettings.BaseUrl + "webchats/api/Customers/" + customerId + "/Interactions/" + interactionId + "/webchats/" + webChatId;
            response = RestHelper.Get(url, envSettings.TouchPointId, envSettings.SubscriptionKey);
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
            checkResults(expectedVals, actualVals).Should().Be(true);
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

        public bool CheckFamilyName(string name)
        {
            return true;
        }



        [Then(@"the error message should be ""(.*)""")]
        public void ThenTheErrorMessageShouldBe(string expectedMessage)
        {
            response.Content.Should().Contain(expectedMessage);
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
            json2 = JsonConvert.SerializeObject(customer);
            response = RestHelper.Post(url, json2, envSettings.TouchPointId, envSettings.SubscriptionKey);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                customerId = actualVals["CustomerId"];
            }
        }


        private bool checkResults(Dictionary<string, string> expectedVals, Dictionary<string, string> actualVals)
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
    }
}