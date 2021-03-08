using NCS.DSS.FunctionalTests.Models;

using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        #region V1
        #endregion

        #region V2
        [When(@"I post a DiversityDetail with the following details V2:")]
        public async Task GivenIPostDiversityDetailWithTheFollowingDetailsV2(Table table)
        {
            foreach (var item in _scenarioContext.Keys)
            {
                var value = _scenarioContext[item] as string;
                table.AddRow(item, value);
            }
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var dd = table.CreateInstance<Diversity>();
            await PostDiversityDetail(dd, customerId, "v2");
            _scenarioContext["DiversityId"] = await _assertionHelper.GetKeyFromResponse("DiversityId", _response);

            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-diversitydetails", "id", _scenarioContext["DiversityId"] as string);
        }

        [Given(@"I patch the following DiversityDetail V2:")]
        public async Task GivenIPatchDiversityDetailWithTheFollowingDetailsV2(Table table)
        {
            foreach (var item in _scenarioContext.Keys)
            {
                var value = _scenarioContext[item] as string;
                table.AddRow(item, value);
            }
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var diversityDetailId = Guid.Parse(_scenarioContext["DiversityId"] as string);
            var dd = table.CreateInstance<Diversity>();

            await PatchDiversityDetail(dd, customerId, diversityDetailId, "v2");
        }

        //I get a Diversity Details by ID V2
        #endregion

        #region V3
        #endregion

        #region private helper methods for get/post/patch/delete
        private async Task PatchDiversityDetail<T>(T diversityDetail, Guid customerId, Guid diversityDetailId, string version)
        {
            _response = await _httpHelper.Patch(diversityDetail, string.Format(_settings.DIVERSITYDETAIL_PATCH_URL, customerId, diversityDetailId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task GetDiversityDetails(Guid customerId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.DIVERSITYDETAIL_GET_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PostDiversityDetail<T>(T diversityDetail, Guid customerId, string version)
        {
            _response = await _httpHelper.Post(diversityDetail, string.Format(_settings.DIVERSITYDETAIL_POST_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}