using FunctionalTests.Models;
using NCS.DSS.FunctionalTests.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        #region v1
        [Given(@"I post a Customer with the following details:")]
        public async Task GivenIPostACustomerWithTheFollowingDetails(Table table)
        {
            var customer = table.CreateInstance<Customer>();
            await PostCustomer(customer, Constants.API_VERSION_1);
            _scenarioContext["CustomerId"] = await _assertionHelper.GetKeyFromResponse("CustomerId", _response);

            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-customers", "id", _scenarioContext["CustomerId"] as string);
        }

        [Given(@"I post a customer with the given name '(.*)'")]
        public async Task GivenIPostACustomerWithTheGivenName(string givenName)
        {
            var customer = new Customer();
            customer.GivenName = givenName;
            customer.FamilyName = "Smith";
            await PostCustomer(customer, Constants.API_VERSION_1);
            _scenarioContext["CustomerId"] = await _assertionHelper.GetKeyFromResponse("CustomerId", _response);

            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-customers", "id", _scenarioContext["CustomerId"] as string);
        }

        [When(@"I get a Customer by ID")]
        public async Task WhenIGetACustomerByID()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await GetByCustomerId(customerId, Constants.API_VERSION_1);
        }

        [When(@"I patch the following Customer:")]
        public async Task WhenPatchTheFollowingCustomer(Table table)
        {
            var customer = table.CreateInstance<CustomerV2>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PatchCustomer(customer, customerId, Constants.API_VERSION_1);
        }
        #endregion

        #region V2
        [Given(@"I post a Customer with the following details V2:")]
        public async Task GivenIPostACustomerWithTheFollowingDetailsV2(Table table)
        {
            var customer = table.CreateInstance<CustomerV2>();
            await PostCustomer(customer, Constants.API_VERSION_2);
            if (_response.IsSuccessStatusCode)
                _scenarioContext["CustomerId"] = await _assertionHelper.GetKeyFromResponse("CustomerId", _response);

            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-customers", "id", _scenarioContext["CustomerId"] as string);
        }

        [When(@"I get a Customer by ID V2")]
        public async Task WhenIGetACustomerByIDV2()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await GetByCustomerId(customerId, Constants.API_VERSION_2);
        }

        [Given(@"I post a customer with the given name '(.*)' V2")]
        public async Task GivenIPostACustomerWithTheGivenNameV2(string givenName)
        {
            var customer = new CustomerV2();
            customer.GivenName = givenName;
            customer.FamilyName = "Smith";
            await PostCustomer(customer, Constants.API_VERSION_2);
            _scenarioContext["CustomerId"] = await _assertionHelper.GetKeyFromResponse("CustomerId", _response);

            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-customers", "id", _scenarioContext["CustomerId"] as string);
        }

        [When(@"I patch the following Customer V2:")]
        public async Task WhenPatchTheFollowingCustomerV2(Table table)
        {
            var customer = table.CreateInstance<CustomerV2>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PatchCustomer(customer, customerId, Constants.API_VERSION_2);
        }
        #endregion

        #region V3
        [Given(@"I post a Customer with the following details V3:")]
        public async Task GivenIPostACustomerWithTheFollowingDetailsV3(Table table)
        {
            var customer = table.CreateInstance<CustomerV3>();
            await PostCustomer(customer, Constants.API_VERSION_3);
            if (_response.IsSuccessStatusCode)
                _scenarioContext["CustomerId"] = await _assertionHelper.GetKeyFromResponse("CustomerId", _response);

            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-customers", "id", _scenarioContext["CustomerId"] as string);
        }

        [Given(@"I post a customer with the given name '(.*)' V3")]
        public async Task GivenIPostACustomerWithTheGivenNameV3(string givenName)
        {
            var customer = new CustomerV3();
            customer.GivenName = givenName;
            customer.FamilyName = "Smith";
            customer.PriorityGroups = new List<int> { 1, 3 };
            await PostCustomer(customer, Constants.API_VERSION_3);
            if (_response.IsSuccessStatusCode)
                _scenarioContext["CustomerId"] = await _assertionHelper.GetKeyFromResponse("CustomerId", _response);


            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-customers", "id", _scenarioContext["CustomerId"] as string);
        }

        [When(@"I get a Customer by ID V3")]
        public async Task WhenIGetACustomerByIDV3()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await GetByCustomerId(customerId, Constants.API_VERSION_3);
        }

        [When(@"I patch the following Customer V3:")]
        public async Task WhenPatchTheFollowingCustomerV3(Table table)
        {
            var customer = table.CreateInstance<CustomerV3>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PatchCustomer(customer, customerId, Constants.API_VERSION_3);
        }

        [When(@"I patch the following Customer With a different touchpoint V3:")]
        public async Task WhenPatchTheFollowingCustomerWithDifferentTouchPointV3(Table table)
        {
            var customer = table.CreateInstance<CustomerV3>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PatchCustomer(customer, customerId, Constants.API_VERSION_3);

        }
        #endregion

        #region private helper methods for get/post/patch/delete
        private async Task PatchCustomer<T>(T customer, Guid customerId, string version)
        {
            _response = await _httpHelper.Patch(customer, string.Format(_settings.CUSTOMER_PATCH_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task GetByCustomerId(Guid customerId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.CUSTOMER_GET_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PostCustomer<T>(T customer, string version)
        {
            _response = await _httpHelper.Post(customer, _settings.CUSTOMER_POST_URL, _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion

    }
}
