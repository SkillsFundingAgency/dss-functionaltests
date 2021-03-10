using NCS.DSS.FunctionalTests.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        #region V2
        [Given(@"I Post a digital identity with the following details V2:")]
        public async Task GivenIPostADigitalIdentityWithTheFollowingDetailsV2(Table table)
        {
            var customerId = default(Guid?);
            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var di = table.CreateInstance<DigitalIdentity>();
            di.CustomerId = customerId;
            await PostDigitalIdentityDetail(di, Constants.API_VERSION_2);
            
            if (_response.IsSuccessStatusCode)
            {
                _scenarioContext["IdentityID"] = await _assertionHelper.GetKeyFromResponse("IdentityID", _response);
                DeleteRowFromSql("dss-digitalidentities", "id", _scenarioContext["IdentityID"] as string);
            }
        }

        [Given(@"I get a DigitalIdentity by CustomerID V2")]
        public async Task GivenIGetDigitalIdentityByCustomerId()
        {
            Guid customerId = Guid.Empty;
            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await GetDigitalIdentityByCustomerId(customerId, Constants.API_VERSION_2);
        }

        [Given(@"I get a DigitalIdentity by DigitalIdentityID V2")]
        public async Task GivenIGetDigitalIdentityByDigitalIdentityId()
        {
            Guid digitalIdentityId = Guid.Empty;
            if (_scenarioContext.ContainsKey("IdentityID"))
                digitalIdentityId = Guid.Parse(_scenarioContext["IdentityID"] as string);
            await GetDigitalIdentityByDigitalIdentityId(digitalIdentityId, Constants.API_VERSION_2);
        }

        [Given(@"I patch the following digitalIdentity By CustomerId V2:")]
        public async Task WhenPatchTheFollowingDigitalIdentityByCustomerIdV2(Table table)
        {
            var customerId = Guid.Empty;
            var di = table.CreateInstance<DigitalIdentity>();
            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            di.CustomerId = customerId;
            await PatchDigitalIdentitByCustomerId(di, customerId, Constants.API_VERSION_2);
        }

        [Given(@"I patch the following digitalIdentity By DigitalIdentityId V2:")]
        public async Task WhenPatchTheFollowingDigitalIdentityByDigitalIdentityIdV2(Table table)
        {
            var digitalIdentityId = Guid.Empty;
            var customerId = Guid.Empty;
            var di = table.CreateInstance<DigitalIdentity>();
            if (_scenarioContext.ContainsKey("IdentityID"))
                digitalIdentityId = Guid.Parse(_scenarioContext["IdentityID"] as string);

            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            di.IdentityID = digitalIdentityId;
            di.CustomerId = customerId;
            await PatchDigitalIdentitByDigitalIdentityId(di, digitalIdentityId, Constants.API_VERSION_2);
        }

        [Given(@"I Delete a Digital Identity V2")]
        public async Task GivenIDeleteADigitalIdentity()
        {
            var customerId = Guid.Empty;
            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await DeleteDigitalIdentityDetail(customerId, Constants.API_VERSION_2);
        }
        #endregion

        #region private methods for post/patch/get
        private async Task GetDigitalIdentityByCustomerId(Guid customerId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.DIGITALIDENTITY_GET__BYCUSTOMERID_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task GetDigitalIdentityByDigitalIdentityId(Guid digitalIdentityId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.DIGITALIDENTITY_GET_BYDIGITALIDENTITYID_URL, digitalIdentityId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PatchDigitalIdentitByCustomerId<T>(T digitalIdentity, Guid customerId, string version)
        {
            _response = await _httpHelper.Patch(digitalIdentity, string.Format(_settings.DIGITALIDENTITY_PATCH_BYCUSTOMERID_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PatchDigitalIdentitByDigitalIdentityId<T>(T digitalIdentity, Guid digitalIdentityId, string version)
        {
            _response = await _httpHelper.Patch(digitalIdentity, string.Format(_settings.DIGITALIDENTITY_PATCH_BYDIGITALIDENTITYID_URL, digitalIdentityId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PostDigitalIdentityDetail<T>(T digitalIdentity, string version)
        {
            _response = await _httpHelper.Post(digitalIdentity, _settings.DIGITALIDENTITY_POST_URL, _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task DeleteDigitalIdentityDetail(Guid customerId, string version)
        {
            _response = await _httpHelper.Delete(string.Format(_settings.DIGITALIDENTITY_DELETE_BYCUSTOMERID_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}