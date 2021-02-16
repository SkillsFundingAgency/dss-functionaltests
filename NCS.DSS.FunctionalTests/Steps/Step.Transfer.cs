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
        [Given(@"I post a Transfer with the following details:")]
        public async Task GivenIPostATransferWithTheFollowingDetails(Table table)
        {
            var transfer = table.CreateInstance<Transfer>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            transfer.CustomerId = customerId.ToString();
            transfer.InteractionId = interactionId.ToString();
            await PostTransfer(transfer, customerId, interactionId, "");
            _scenarioContext["TransferId"] = await _assertionHelper.GetKeyFromResponse("TransferId", _response);
        }

        [When(@"I get a Transfer by ID")]
        public async Task WhenIGetATransferChatByID()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var transferId = Guid.Parse(_scenarioContext["TransferId"] as string);
            await GetByTransferId(transferId, customerId, interactionId, "");
        }

        [Given(@"I patch a Transfer with the following details:")]
        public async Task GivenIPatchATransferWithTheFollowingDetails(Table table)
        {
            var transfer = table.CreateInstance<Transfer>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var transferId = Guid.Parse(_scenarioContext["TransferId"] as string);
            transfer.TransferId = transferId.ToString();
            transfer.CustomerId = customerId.ToString();
            transfer.InteractionId = interactionId.ToString();
            await PatchTransfer(transfer, customerId, interactionId, transferId, "");
        }

        #region private helper methods for get/post/patch/delete
        private async Task PatchTransfer<T>(T transfer, Guid customerId, Guid interactionId, Guid transferId, string version)
        {
            _response = await _httpHelper.Patch(transfer, string.Format(_settings.TRANSFER_PATCH_URL, customerId, interactionId, transferId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }

        private async Task GetByTransferId(Guid transferId, Guid customerId, Guid interactionId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.TRANSFER_GET_URL, customerId, interactionId, transferId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }

        private async Task PostTransfer<T>(T transfer, Guid customerId, Guid interactionId, string version)
        {
            _response = await _httpHelper.Post(transfer, string.Format(_settings.TRANSFER_POST_URL, customerId, interactionId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}
