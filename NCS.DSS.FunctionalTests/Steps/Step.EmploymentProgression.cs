using NCS.DSS.FunctionalTests.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    partial class Step
    {
        #region V3
        [Given(@"I post a Employment Progression record with the following details V3:")]
        public async Task GivenIPostAValidEmploymentProgressionWithTheFollowingDetailsV3(Table table)
        {
            foreach(var item in _scenarioContext.Keys)
            {
                var value = _scenarioContext[item] as string;
                table.AddRow(item, value);
            }
            var ep = table.CreateInstance<EmploymentProgressionV3>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await PostEmploymentProgression(ep, customerId, "v3");
            _scenarioContext["EmploymentProgressionId"] = await _assertionHelper.GetKeyFromResponse("EmploymentProgressionId", _response);

            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-employmentprogressions", "id", _scenarioContext["EmploymentProgressionId"] as string);
        }

        [Given(@"I patch the following EmploymentProgression V3:")]
        public async Task GivenIPatchAValidEmploymentProgressionWithTheFollowingDetailsV3(Table table)
        {
            foreach (var item in _scenarioContext.Keys)
            {
                var value = _scenarioContext[item] as string;
                table.AddRow(item, value);
            }
            var ep = table.CreateInstance<EmploymentProgressionV3>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var employmentProgressionId = Guid.Parse(_scenarioContext["EmploymentProgressionId"] as string);
            await PatchEmploymentProgression(ep, customerId, employmentProgressionId,"v3");
        }

        [When(@"I get all Employment Progression records for a customer V3")]
        public async Task GivenIGetAllEmploymentProgressionForCustomerV3()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            await GetAllEmploymentProgressionsByCustomerId(customerId, "v3");
        }

        [When(@"I get a Employment Progression by ID V3")]
        public async Task GivenIGetEmploymentProgressionByCustomerIdV3()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);

            Guid.TryParse(_scenarioContext["EmploymentProgressionId"] as string, out Guid employmentProgressionId);
            await GetEmploymentProgressionById(customerId, employmentProgressionId, "v3");
        }
        #endregion

        #region private helper methods for posting/patching/get



        private async Task PatchEmploymentProgression<T>(T employmentProgression, Guid customerId,Guid employmentProgressionId, string version)
        {
            _response = await _httpHelper.Patch(employmentProgression, string.Format(_settings.EMPLOYMENTPROGRESSION_PATCH_URL, customerId,employmentProgressionId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task GetAllEmploymentProgressionsByCustomerId(Guid customerId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.EMPLOYMENTPROGRESSION_GETBY_CUSTOMERID_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task GetEmploymentProgressionById(Guid customerId, Guid employmentProgression, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.EMPLOYMENTPROGRESSION_GETBY_CUSTOMERID_AND_EMPLOYMENTPROGRESSIONID_URL, customerId, employmentProgression), _touchPointId, version, _settings.SubscriptionKey);
        }


        private async Task PostEmploymentProgression<T>(T employmentProgression, Guid customerId, string version)
        {
            _response = await _httpHelper.Post(employmentProgression, string.Format(_settings.EMPLOYMENTPROGRESSION_POST_URL,customerId), _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}
