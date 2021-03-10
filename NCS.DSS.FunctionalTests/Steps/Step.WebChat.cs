using NCS.DSS.FunctionalTests.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        [Given(@"I post a webchat with the following details:")]
        public async Task GivenIPostAWebchatWithTheFollowingDetails(Table table)
        {
            var webchat = table.CreateInstance<WebChat>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            await PostWebChat(webchat, customerId, interactionId, Constants.API_VERSION_1);
            _scenarioContext["WebChatId"] = await _assertionHelper.GetKeyFromResponse("WebChatId", _response);
            if (_response.IsSuccessStatusCode)
            {
                DeleteRowFromSql("dss-webchats", "id", _scenarioContext["WebChatId"] as string);
            }
        }

        [When(@"I get a WebChat by ID")]
        public async Task WhenIGetAWebChatByID()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var webchatId = Guid.Parse(_scenarioContext["WebChatId"] as string);
            await GetByWebChatId(webchatId, customerId, interactionId, Constants.API_VERSION_1);
        }

        [When(@"I patch the following:")]
        public async Task GivenIPatchAWebChatWithTheFollowingDetails(Table table)
        {
            var webchat = table.CreateInstance<WebChat>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var webchatId = Guid.Parse(_scenarioContext["WebChatId"] as string);
            await PatchWebChat(webchat, customerId, interactionId, webchatId, Constants.API_VERSION_1);
        }

        #region private helper methods for get/post/patch/delete
        private async Task PatchWebChat<T>(T webchat, Guid customerId, Guid interactionId, Guid webchatId, string version)
        {
            _response = await _httpHelper.Patch(webchat, string.Format(_settings.WEBCHAT_PATCH_URL, customerId, interactionId, webchatId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task GetByWebChatId(Guid webchatId, Guid customerId, Guid interactionId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.WEBCHAT_GET_URL, customerId, interactionId, webchatId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PostWebChat<T>(T webchat, Guid customerId, Guid interactionId, string version)
        {
            _response = await _httpHelper.Post(webchat, string.Format(_settings.WEBCHAT_POST_URL, customerId, interactionId), _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion

    }
}
