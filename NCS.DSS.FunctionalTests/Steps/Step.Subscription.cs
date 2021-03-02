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

        [Given(@"I post a new subscription request:")]
        public async Task GivenIPostANewSubsciptionRequest(Table table)
        {
            var subscription = table.CreateInstance<WebChat>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PostSubscription(subscription, customerId, "");
            _scenarioContext["SubscriptionId"] = await _assertionHelper.GetKeyFromResponse("SubscriptionId", _response);
        }

        //[When(@"I get a WebChat by ID")]
        //public async Task WhenIGetAWebChatByID()
        //{
        //    var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
        //    var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
        //    var webchatId = Guid.Parse(_scenarioContext["WebChatId"] as string);
        //    await GetByWebChatId(webchatId, customerId, interactionId, "");
        //}

        //[When(@"I patch the following:")]
        //public async Task GivenIPatchAWebChatWithTheFollowingDetails(Table table)
        //{
        //    var webchat = table.CreateInstance<WebChat>();
        //    var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
        //    var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
        //    var webchatId = Guid.Parse(_scenarioContext["WebChatId"] as string);
        //    await PatchWebChat(webchat, customerId, interactionId, webchatId, "");
        //}

        #region private helper methods for get/post/patch/delete
        private async Task PatchSubscription<T>(T subscription, Guid customerId, Guid subscriptionId, string version)
        {
            _response = await _httpHelper.Patch(subscription, string.Format(_settings.SUBSCRIPTION_PATCH_URL, customerId, subscriptionId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }

        private async Task GetSubscription(Guid webchatId, Guid customerId, Guid subscriptionId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.SUBSCRIPTION_GET_URL, customerId, subscriptionId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }

        private async Task PostSubscription<T>(T subscription, Guid customerId, string version)
        {
            _response = await _httpHelper.Post(subscription, string.Format(_settings.SUBSCRIPTION_POST_URL, customerId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }
        #endregion

    }
}
