﻿using NCS.DSS.FunctionalTests.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    partial class Step
    {
        #region v1
        [Given(@"I post an Address with the following details:")]
        public async Task GivenIPostAnAddressWithTheFollowingDetails(Table table)
        {
            var address = table.CreateInstance<Address>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PostAddress(address, customerId, Constants.API_VERSION_1);
            _scenarioContext["AddressId"] = await _assertionHelper.GetKeyFromResponse("AddressId", _response);

            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-addresses", "id", _scenarioContext["AddressId"] as string);
        }

        [When(@"I patch the following Address:")]
        public async Task WhenPatchTheFollowingAddress(Table table)
        {
            var address = table.CreateInstance<Address>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var addressId = Guid.Parse(_scenarioContext["AddressId"] as string);
            await PatchAddress(address, customerId, addressId, Constants.API_VERSION_1);
        }

        [When(@"I get an Address by ID")]
        public async Task WhenIGetAAddressByID()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var addressId = Guid.Parse(_scenarioContext["AddressId"] as string);
            await GetAddressById(customerId,addressId, Constants.API_VERSION_1);
        }
        #endregion

        #region v2
        [Given(@"I post an Address with the following details V2:")]
        public async Task GivenIPostAnAddressWithTheFollowingDetailsV2(Table table)
        {
            var address = table.CreateInstance<AddressV2>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PostAddress(address, customerId, Constants.API_VERSION_2);
            _scenarioContext["AddressId"] = await _assertionHelper.GetKeyFromResponse("AddressId", _response);

            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-addresses", "id", _scenarioContext["AddressId"] as string);
        }

        [When(@"I patch the following Address V2:")]
        public async Task WhenPatchTheFollowingAddressV2(Table table)
        {
            var address = table.CreateInstance<AddressV2>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var addressId = Guid.Parse(_scenarioContext["AddressId"] as string);
            await PatchAddress(address, customerId, addressId, Constants.API_VERSION_2);
        }

        [When(@"I get an Address by ID V2")]
        public async Task WhenIGetAAddressByIDV2()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var addressId = Guid.Parse(_scenarioContext["AddressId"] as string);
            await GetAddressById(customerId, addressId, Constants.API_VERSION_2);
        }
        #endregion

        #region private helpers for post/patch/get
        private async Task PatchAddress<T>(T address, Guid customerId, Guid addressId, string version)
        {
            _response = await _httpHelper.Patch(address, string.Format(_settings.ADDRESS_PATCH_URL, customerId, addressId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task GetAddressById(Guid customerId, Guid addressId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.ADDRESS_GET_URL, customerId, addressId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PostAddress<T>(T address, Guid customerId, string version)
        {
            _response = await _httpHelper.Post(address, string.Format(_settings.ADDRESS_POST_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}
