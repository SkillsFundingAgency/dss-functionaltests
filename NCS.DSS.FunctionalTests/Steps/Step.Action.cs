
using NCS.DSS.FunctionalTests.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        #region v2
        [Given(@"I post an Action with the following details V2:")]
        public async Task GivenIPostAnActionWithTheFollowingDetailsV2(Table table)
        {
            var action = table.CreateInstance<NCS.DSS.FunctionalTests.Models.Action>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);

            await PostAction(action, customerId, interactionId, actionPlanId, "v2");
            if (_response.IsSuccessStatusCode)
            {
                _scenarioContext["ActionId"] = await _assertionHelper.GetKeyFromResponse("ActionId", _response);
                DeleteRowFromSql("dss-actions", "id", _scenarioContext["ActionId"] as string);
            }

        }

        [Given(@"I get an Action by ID V2")]
        public async Task WhenIGetAnActionByIDV2()
        {
            var actionId = Guid.Parse(_scenarioContext["ActionId"] as string);
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            await GetByActionId(actionId, customerId, interactionId, actionPlanId, "v2");
        }

        [Given(@"I patch the following Action V2:")]
        public async Task GivenIPatchAnActionWithTheFollowingDetailsV2(Table table)
        {
            var action = table.CreateInstance<NCS.DSS.FunctionalTests.Models.Action>();
            var actionId = Guid.Parse(_scenarioContext["ActionId"] as string);
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            await PatchAction(action, customerId, interactionId, actionPlanId, actionId, "v2");
        }
        #endregion

        #region private helper methods for get/post/patch/delete
        private async Task PatchAction<T>(T action, Guid customerId, Guid interactionId, Guid actionPlanId, Guid actionId, string version)
        {
            _response = await _httpHelper.Patch(action, string.Format(_settings.ACTION_PATCH_URL, customerId, interactionId, actionPlanId, actionId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task GetByActionId(Guid actionId, Guid customerId, Guid interactionId, Guid actionPlanId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.ACTION_GET_URL, customerId, interactionId, actionPlanId, actionId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PostAction<T>(T action, Guid customerId, Guid interactionId, Guid actionPlanId, string version)
        {
            _response = await _httpHelper.Post(action, string.Format(_settings.ACTION_POST_URL, customerId, interactionId, actionPlanId), _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}
