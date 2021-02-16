using functionaltests.Models;
using NCS.DSS.FunctionalTests.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        #region v1
        [Given(@"I post an ActionPlan with the following details:")]
        public async Task GivenIPostAnActionPlanWithTheFollowingDetails(Table table)
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlan = table.CreateInstance<ActionPlan>();
            await PostActionPlan(actionPlan, customerId, interactionId, "");
            _scenarioContext["ActionPlanId"] = await _assertionHelper.GetKeyFromResponse("ActionPlanId", _response);
            if (_response.IsSuccessStatusCode)
            {
                DeleteRowFromSql("dss-actionplans", "id", _scenarioContext["ActionPlanId"] as string);
            }
        }

        [When(@"I get an ActionPlan by ID")]
        public async Task WhenIGetAnActionPlanID()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            await GetByActionPlanId(customerId, interactionId, actionPlanId, "");
        }

        [When(@"I patch the following ActionPlan:")]
        public async Task WhenPatchTheFollowingActionPlan(Table table)
        {
            var actionPlan = table.CreateInstance<ActionPlan>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            await PatchActionPlan(actionPlan, customerId, interactionId, actionPlanId, "");
        }
        #endregion

        #region v2
        [Given(@"I post an ActionPlan with the following details V2:")]
        public async Task GivenIPostAnActionPlanWithTheFollowingDetailsV2(Table table)
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var sessionId = _scenarioContext["SessionId"] as string;
            var actionPlan = table.CreateInstance<ActionPlanV2>();
            actionPlan.SessionId = sessionId;
            await PostActionPlan(actionPlan, customerId, interactionId, "v2");
            _scenarioContext["ActionPlanId"] = await _assertionHelper.GetKeyFromResponse("ActionPlanId", _response);
            if (_response.IsSuccessStatusCode)
            {
                DeleteRowFromSql("dss-actionplans", "id", _scenarioContext["ActionPlanId"] as string);
            }
        }

        [When(@"I patch the following ActionPlan V2:")]
        public async Task WhenPatchTheFollowingActionPlanV2(Table table)
        {
            var actionPlan = table.CreateInstance<ActionPlanV2>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            await PatchActionPlan(actionPlan, customerId, interactionId, actionPlanId, "v2");
            if (_response.IsSuccessStatusCode)
            {
                DeleteRowFromSql("dss-actionplans", "id", _scenarioContext["ActionPlanId"] as string);
            }
        }

        [When(@"I get an ActionPlan by ID V2")]
        public async Task WhenIGetAnActionPlanIDV2()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            await GetByActionPlanId(customerId, interactionId, actionPlanId, "v2");
        }
        #endregion

        #region v3
        [When(@"I get an ActionPlan by ID V3")]
        public async Task WhenIGetAnActionPlanIDV3()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            await GetByActionPlanId(customerId, interactionId, actionPlanId, "v3");
        }

        [When(@"I patch the following ActionPlan V3:")]
        public async Task WhenPatchTheFollowingActionPlanV3(Table table)
        {
            var actionPlan = table.CreateInstance<ActionPlanV3>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            await PatchActionPlan(actionPlan, customerId, interactionId, actionPlanId, "v3");
        }

        [Given(@"I post an ActionPlan with the following details V3:")]
        public async Task GivenIPostAnActionPlanWithTheFollowingDetailsV3(Table table)
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var sessionId = _scenarioContext["SessionId"] as string;
            var actionPlan = table.CreateInstance<ActionPlanV3>();
            actionPlan.SessionId = sessionId;
            await PostActionPlan(actionPlan, customerId, interactionId, "v3");
            _scenarioContext["ActionPlanId"] = await _assertionHelper.GetKeyFromResponse("ActionPlanId", _response);
            if (_response.IsSuccessStatusCode)
            {
                DeleteRowFromSql("dss-actionplans", "id", _scenarioContext["ActionPlanId"] as string);
            }
        }
        #endregion

        #region private helper methods for get/post/patch/delete
        private async Task PatchActionPlan<T>(T actionPlan, Guid customerId, Guid interactionId, Guid actionPlanId, string version)
        {
            _response = await _httpHelper.Patch(actionPlan, string.Format(_settings.ACTIONPLAN_PATCH_URL, customerId, interactionId, actionPlanId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }

        private async Task GetByActionPlanId (Guid customerId, Guid interactionId, Guid actionPlanId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.ACTIONPLAN_GET_URL, customerId, interactionId, actionPlanId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }

        private async Task PostActionPlan<T>(T actionPlan, Guid customerId, Guid interactionId, string version)
        {
            _response = await _httpHelper.Post(actionPlan, string.Format(_settings.ACTIONPLAN_POST_URL, customerId, interactionId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}