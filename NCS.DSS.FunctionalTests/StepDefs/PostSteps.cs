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

namespace FunctionalTests.StepDefs
{
    [Binding]
    public class PostSteps
    {

        private readonly RestHelper Rest = new RestHelper();
        private IRestResponse response;
        private string baseUrl = "https://pp.api.nationalcareersservice.org.uk/";
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

         

        [Given(@"I post a Customer with the following details:")]
        public void GivenIPostACustomerWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "customers/api/customers/";
            var customer = table.CreateInstance<Customer>();
            json2 = JsonConvert.SerializeObject(customer);
            response = RestHelper.Post(url,json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                customerId = actualVals["CustomerId"];
            }
        }

        [Given(@"I post an adviser with the following details:")]
        public void GivenIPostAnAdviserWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "adviserdetails/api/AdviserDetails";
            var adviser = table.CreateInstance<Adviser>();
            json2 = JsonConvert.SerializeObject(adviser);
            response = RestHelper.Post(url,json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                adviserDetailId = actualVals["AdviserDetailId"];
            }
        }

        [Given(@"I post an Interaction with the following details:")]
        public void GivenIPostAnInteractionWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "interactions/api/Customers/" + customerId +  "/Interactions/";
            var interaction = table.CreateInstance<Interaction>();
            json2 = JsonConvert.SerializeObject(interaction);
            response = RestHelper.Post(url, json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> interactionDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                interactionId = interactionDictionary["InteractionId"];
            }
        }

        [Given(@"I post an Address with the following details:")]
        public void GivenIPostAnAddressWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "addresses/api/Customers/" + customerId + "/Addresses/";
            var address = table.CreateInstance<Address>();
            json2 = JsonConvert.SerializeObject(address);
            response = RestHelper.Post(url, json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> addressDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                addressId = addressDictionary["AddressId"];
            }
        }

        [Given(@"I post a Contact with the following details:")]
        public void GivenIPostAContactWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "contactDetails/api/Customers/" + customerId + "/contactDetails/";
            var contact = table.CreateInstance<Contact>();
            json2 = JsonConvert.SerializeObject(contact);
            response = RestHelper.Post(url, json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> contactDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                contactId = contactDictionary["ContactId"];
            }
        }


        [Given(@"I post an ActionPlan with the following details:")]
        public void GivenIPostAnActionPlanWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "actionplans/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/";
            var actionPlan = table.CreateInstance<ActionPlan>();
            json2 = JsonConvert.SerializeObject(actionPlan);
            response = RestHelper.Post(url, json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionPlanId = dict["ActionPlanId"];
            }
        }

        [Given(@"I post an Action with the following details:")]
        public void GivenIPostAnActionWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "actions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/actions/";
            var action = table.CreateInstance<NCS.DSS.FunctionalTests.Models.Action>();
            json2 = JsonConvert.SerializeObject(action);
            response = RestHelper.Post(url, json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionId = dict["ActionId"];
            }
        }


        [When(@"I post a DiversityDetail with the following details:")]
        public void WhenIPostADiversityDetailWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "diversitydetails/api/Customers/" + customerId + "/DiversityDetails/";
            var diversity = table.CreateInstance<Diversity>();
            json2 = JsonConvert.SerializeObject(diversity);
            response = RestHelper.Post(url, json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                actionId = dict["DiversityId"];
            }
        }


        [Given(@"I post a session with the following details:")]
        public void GivenIPostASessionWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "sessions/api/Customers/" + customerId + "/Interactions/" + interactionId + "/sessions/";
            var session = table.CreateInstance<Session>();
            json2 = JsonConvert.SerializeObject(session);
            response = RestHelper.Post(url, json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                sessionId = dict["SessionId"];
            }
        }


        [Given(@"I post a goal with the following details:")]
        public void GivenIPostAGoalWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "goals/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/goals/";
            var goal = table.CreateInstance<Goal>();
            json2 = JsonConvert.SerializeObject(goal);
            response = RestHelper.Post(url, json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                goalId = dict["GoalId"];
            }

        }

        [Given(@"I post a webchat with the following details:")]
        public void GivenIPostAWebchatWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "webchats/api/Customers/" + customerId + "/Interactions/" + interactionId + "/webchats/";
            var webchat = table.CreateInstance<WebChat>();
            json2 = JsonConvert.SerializeObject(webchat);
            response = RestHelper.Post(url, json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                goalId = dict["WebChatId"];
            }
        }

        [Given(@"I post an outcome with the following details:")]
        public void GivenIPostAnOutcomeWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "outcomes/api/Customers/" + customerId + "/Interactions/" + interactionId + "/ActionPlans/" + actionPlanId + "/outcomes/";
            var outcome = table.CreateInstance<Outcome>();
            json2 = JsonConvert.SerializeObject(outcome);
            response = RestHelper.Post(url, json2);
            if (response.IsSuccessful)
            {
                Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                goalId = dict["OutcomeId"];
            }
        }

        [Given(@"I post an subscription with the following details:")]
        public void GivenIPostASubscriptionWithTheFollowingDetails(Table table)
        {
            url = baseUrl + "subscriptions/api/Customers/" + customerId + "/subscriptions/";
            var subscription = table.CreateInstance<Subscription>();
            json2 = JsonConvert.SerializeObject(subscription);
            response = RestHelper.Post(url, json2);
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
            var x = table.Rows.ToDictionary(r => r["Field"], r => r["Value"]);
            json2 = JsonConvert.SerializeObject(x);
            response = RestHelper.Patch(url,json2,customerId);

        }

        [When(@"I patch the address:")]
        public void WhenIPatchTheAddress(Table table)
        {
            Dictionary<string, string> address = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            addressId = address.FirstOrDefault().Value;
            var x = table.Rows.ToDictionary(r => r["Field"], r => r["Value"]);
            json2 = JsonConvert.SerializeObject(x);
            response = RestHelper.Patch(url, json2, addressId);
        }

        [When(@"I patch the ActionPlan:")]
        public void WhenIPatchTheActionPlan(Table table)
        {
            Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            actionPlanId = dict.FirstOrDefault().Value;
            var x = table.Rows.ToDictionary(r => r["Field"], r => r["Value"]);
            json2 = JsonConvert.SerializeObject(x);
            response = RestHelper.Patch(url, json2, actionPlanId);
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
            Dictionary<string, string> actualVals = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            var expectedVals = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                expectedVals.Add(row[0], row[1]);
            }
            checkResults(expectedVals,actualVals).Should().Be(true);
        }

  

        [Then(@"the error message should be ""(.*)""")]
        public void ThenTheErrorMessageShouldBe(string expectedMessage)
        {
            response.Content.Should().Contain(expectedMessage);
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

    }
}
