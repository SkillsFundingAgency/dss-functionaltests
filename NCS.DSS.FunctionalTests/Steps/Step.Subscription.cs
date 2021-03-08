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
        [Given(@"I post a subscription with the following details:")]
        public async Task GivenIPostASubscriptionWithTheFollowingDetailsAsync(Table table)
        {
            var subscription = table.CreateInstance<Subscription>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PostSubscription(subscription, customerId, "");
            _scenarioContext["SubscriptionId"] = await _assertionHelper.GetKeyFromResponse("SubscriptionId", _response);
        }

        [When(@"I get a Subscription by ID")]
        public async Task WhenIGetASubscriptionByID()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var subscriptionId = Guid.Parse(_scenarioContext["SubscriptionId"] as string);
            await GetSubscription(subscriptionId, customerId, "");
        }

        [Given(@"I patch a subscription with the following details:")]
        public async Task GivenIPatchASubscriptionWithTheFollowingDetails(Table table)
        {
            var subscription = table.CreateInstance<Subscription>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var subscriptionId = Guid.Parse(_scenarioContext["SubscriptionId"] as string);
            await PatchSubscription(subscription, customerId, subscriptionId, "");
        }

        #region private helper methods for get/post/patch/delete
        private async Task PatchSubscription<T>(T subscription, Guid customerId, Guid subscriptionId, string version)
        {
            _response = await _httpHelper.Patch(subscription, string.Format(_settings.SUBSCRIPTION_PATCH_URL, customerId, subscriptionId), _settings.TestEndpoint02, version, _settings.SubscriptionKey);
        }

        private async Task GetSubscription(Guid subscriptionId, Guid customerId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.SUBSCRIPTION_GET_URL, customerId, subscriptionId), _settings.TestEndpoint02, version, _settings.SubscriptionKey);
        }

        private async Task PostSubscription<T>(T subscription, Guid customerId, string version)
        {
            _response = await _httpHelper.Post(subscription, string.Format(_settings.SUBSCRIPTION_POST_URL, customerId), _settings.TestEndpoint02, version, _settings.SubscriptionKey);
        }
        #endregion

    }
}
