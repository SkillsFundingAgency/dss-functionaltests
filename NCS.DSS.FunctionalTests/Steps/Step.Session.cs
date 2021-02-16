using NCS.DSS.FunctionalTests.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        #region v1
        [Given(@"I post a session with the following details:")]
        public async Task GivenIPostASessionWithTheFollowingDetails(Table table)
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var session = table.CreateInstance<Session>();
            await PostSession(session, customerId, interactionId, "");
            _scenarioContext["SessionId"] = await _assertionHelper.GetKeyFromResponse("SessionId", _response);
            if (_response.IsSuccessStatusCode)
            {
                DeleteRowFromSql("dss-sessions", "id", _scenarioContext["SessionId"] as string);
            }
        }

        //[Given(@"I post a customer with the given name '(.*)'")]
        //public async Task GivenIPostACustomerWithTheGivenName(string givenName)
        //{
        //    var customer = new Customer();
        //    customer.GivenName = givenName;
        //    customer.FamilyName = "Smith";
        //    await PostCustomer(customer, "");
        //    _scenarioContext["CustomerId"] = await _assertionHelper.GetKeyFromResponse("CustomerId", _response);
        //}

        //[When(@"I get a Customer by ID")]
        //public async Task WhenIGetACustomerByID()
        //{
        //    var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
        //    await GetByCustomerId(customerId, "");
        //}

        [When(@"I patch the following Session:")]
        public async Task WhenPatchTheFollowingSession(Table table)
        {
            var session = table.CreateInstance<Session>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var sessionId = Guid.Parse(_scenarioContext["SessionId"] as string);
            await PatchSession(session, customerId, interactionId, sessionId, "");
        }
        #endregion

        #region v2
        [Given(@"I post a session with the following details V2:")]
        public async Task GivenIPostASessionWithTheFollowingDetailsV2(Table table)
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var session = table.CreateInstance<Session>();
            await PostSession(session, customerId, interactionId, "v2");
            _scenarioContext["SessionId"] = await _assertionHelper.GetKeyFromResponse("SessionId", _response);
        }
        #endregion

        #region private methods for post/patch/get
        private async Task PatchSession<T>(T session, Guid customerId, Guid interactionId, Guid sessionId, string version)
        {
            _response = await _httpHelper.Patch(session, string.Format(_settings.SESSION_PATCH_URL, customerId, interactionId, sessionId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }

        private async Task GetBySessionId(Guid customerId, Guid interactionId, Guid sessionId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.SESSION_GET_URL, customerId, interactionId, sessionId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }

        private async Task PostSession<T>(T session, Guid customerId, Guid interactionId, string version)
        {
            _response = await _httpHelper.Post(session, string.Format(_settings.SESSION_POST_URL, customerId, interactionId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}