using NCS.DSS.FunctionalTests.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        [Given(@"I post a Valid Interaction with the following details:")]
        public async Task GivenIPostAValidInteractionWithTheFollowingDetails(Table table)
        {
            var interaction = table.CreateInstance<Interaction>();
            interaction.AdviserDetailsId = _scenarioContext["AdviserDetailId"] as string;
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PostInteraction(interaction, customerId, "");
            _scenarioContext["InteractionId"] = await _assertionHelper.GetKeyFromResponse("InteractionId", _response);

            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-interactions", "id", _scenarioContext["InteractionId"] as string);
        }

        [Given(@"I post an Interaction with the following details:")]
        public async Task GivenIPostAnInteractionWithTheFollowingDetails(Table table)
        {
            var interaction = table.CreateInstance<Interaction>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PostInteraction(interaction, customerId, "");
            _scenarioContext["InteractionId"] = await _assertionHelper.GetKeyFromResponse("InteractionId", _response);
        }

        [When(@"I get an Interaction by Customer ID And InteractionId")]
        public async Task WhenIGetInteractionByCustomerAndInteractionId()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            await GetByInteractionId(customerId, interactionId, "");
        }

        [When(@"I patch the following Valid Interaction:")]
        public async Task WhenPatchTheFollowingValidInteraction(Table table)
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var interaction = table.CreateInstance<Interaction>();
            await PatchInteraction(interaction, customerId, interactionId, "");
        }

        [When(@"I patch the following Interaction:")]
        public async Task WhenPatchTheFollowingInteraction(Table table)
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var interaction = table.CreateInstance<Interaction>();
            await PatchInteraction(interaction, customerId, interactionId, "");
        }

        #region private methods for patch/post/get
        private async Task PatchInteraction<T>(T interaction, Guid customerId, Guid interactionId, string version)
        {
            _response = await _httpHelper.Patch(interaction, string.Format(_settings.INTERACTION_PATCH_URL, customerId, interactionId), _touchPointId, "", _settings.SubscriptionKey);
        }

        private async Task GetByInteractionId(Guid customerId, Guid interactionId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.INTERACTION_GETBY_CUSTOMERID_AND_INTERACTION_URL, customerId, interactionId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PostInteraction<T>(T interaction, Guid customerId, string version)
        {
            _response = await _httpHelper.Post(interaction, string.Format(_settings.INTERACTION_POST_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}
