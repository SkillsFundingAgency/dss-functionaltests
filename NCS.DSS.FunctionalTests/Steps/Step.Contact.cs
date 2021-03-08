using NCS.DSS.FunctionalTests.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        [Given(@"I post a Contact with the following details with unique email address:")]
        public async Task GivenIPostAContactWithTheFollowingDetails(Table table)
        {
            var contact = table.CreateInstance<Contact>();
            contact.EmailAddress = $"someEmail{DateTime.Now.Ticks}@sometest.com";
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PostContact(contact, customerId);
        }

        [Given(@"I post a Contact with the following details:")]
        public async Task GivenIPostAContactWithTheFollowingInvalidDetails(Table table)
        {
            var contact = table.CreateInstance<Contact>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PostContact(contact, customerId);
        }

        [When(@"I get a Contact by CustomerID")]
        public async Task WhenIGetAContactByCustomerID()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await GetContactByCustomerId(customerId);
        }

        [When(@"I get a Contact by CustomerID And ContactId")]
        public async Task WhenIGetAContactByCustomerIDAndContactId()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var contactId = Guid.Parse(_scenarioContext["ContactId"] as string);
            await GetContactByCustomerIdAndContactId(customerId, contactId);
        }

        [When(@"I patch the following Contact With RandomEmailAddress:")]
        public async Task WhenPatchTheFollowingContactWithRandomEmail()
        {
            var contact = new Contact();
            contact.EmailAddress = $"someEmail{DateTime.Now.Ticks}@sometest.com";
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var contactId = Guid.Parse(_scenarioContext["ContactId"] as string);
            await PatchContact(contact, customerId, contactId);
        }

        [When(@"I patch the following Contact:")]
        public async Task WhenPatchTheFollowingContact(Table table)
        {
            var contact = table.CreateInstance<Contact>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var contactId = Guid.Parse(_scenarioContext["ContactId"] as string);
            await PatchContact(contact, customerId, contactId);
        }

        #region private methods for posting/patching/get
        private async Task PostContact(Contact contact, Guid CustomerId)
        {
            _response = await _httpHelper.Post(contact, string.Format(_settings.CONTACT_POST_URL, CustomerId), _settings.TestEndpoint01, "", _settings.SubscriptionKey);
            _scenarioContext["ContactId"] = await _assertionHelper.GetKeyFromResponse("ContactId", _response);
        }

        private async Task GetContactByCustomerId(Guid customerId)
        {
            _response = await _httpHelper.Get(string.Format(_settings.CONTACT_GETBY_CUSTOMERID_URL, customerId), _settings.TestEndpoint01, "", _settings.SubscriptionKey);
        }
        private async Task GetContactByCustomerIdAndContactId(Guid customerId, Guid contactId)
        {
            _response = await _httpHelper.Get(string.Format(_settings.CONTACT_GETBY_CUSTOMERID_AND_CONTACTID_URL, customerId, contactId), _touchPointId, "", _settings.SubscriptionKey);
        }

        private async Task PatchContact(Contact contact, Guid customerId, Guid contactId)
        {
            _response = await _httpHelper.Patch(contact, string.Format(_settings.CONTACT_PATCH_URL, customerId, contactId), _touchPointId, "", _settings.SubscriptionKey);
        }
        #endregion;
    }
}
