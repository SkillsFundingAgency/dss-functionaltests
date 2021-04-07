using NCS.DSS.FunctionalTests.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        //#region V1
        //[Given(@"I post an adviser with the following details:")]
        //public async Task GivenIPostAAdviserWithTheFollowingDetails(Table table)
        //{
        //    var adviser = table.CreateInstance<Adviser>();
        //    await PostAdviserDetail(adviser, Constants.API_VERSION_1);
        //    _scenarioContext["AdviserDetailId"] = await _assertionHelper.GetKeyFromResponse("AdviserDetailId", _response);
        //    if (_response.IsSuccessStatusCode)
        //    {
        //        DeleteRowFromSql("dss-adviserdetails", "id", _scenarioContext["AdviserDetailId"] as string);
        //    }
        //}

        //[When(@"I get an Adviser by ID")]
        //public async Task WhenIGetAnAdviserByID()
        //{
        //    var adviserDetailId = Guid.Parse(_scenarioContext["AdviserDetailId"] as string);
        //    await GetAdviserDetailById(adviserDetailId, Constants.API_VERSION_1);
        //}

        //[When(@"I patch the following Adviser:")]
        //public async Task WhenPatchTheFollowingAdviser(Table table)
        //{
        //    var adviserDetailId = Guid.Parse(_scenarioContext["AdviserDetailId"] as string);
        //    var adviser = table.CreateInstance<Adviser>();
        //    await PatchAdviserDetail(adviser, adviserDetailId, Constants.API_VERSION_1);
        //}
        //#endregion

        #region V2
        [Given(@"I post an adviser with the following details V2:")]
        public async Task GivenIPostAAdviserWithTheFollowingDetailsV2(Table table)
        {
            var adviser = table.CreateInstance<AdviserV2>();
            await PostAdviserDetail(adviser, Constants.API_VERSION_2);
            _scenarioContext["AdviserDetailId"] = await _assertionHelper.GetKeyFromResponse("AdviserDetailId", _response);
            if (_response.IsSuccessStatusCode)
            {
                DeleteRowFromSql("dss-adviserdetails", "id", _scenarioContext["AdviserDetailId"] as string);
            }
        }

        [When(@"I get an Adviser by ID V2")]
        public async Task WhenIGetAnAdviserByIDV2()
        {
            var adviserDetailId = Guid.Parse(_scenarioContext["AdviserDetailId"] as string);
            await GetAdviserDetailById(adviserDetailId, Constants.API_VERSION_2);
        }

        [When(@"I patch the following Adviser V2:")]
        public async Task WhenPatchTheFollowingAdviserV2(Table table)
        {
            var adviserDetailId = Guid.Parse(_scenarioContext["AdviserDetailId"] as string);
            var adviser = table.CreateInstance<AdviserV2>();
            await PatchAdviserDetail(adviser, adviserDetailId, Constants.API_VERSION_2);
        }
        #endregion

        #region private methods for post/patch/get
        private async Task GetAdviserDetailById(Guid adviserDetailId, string version)
        {
            _response  = await _httpHelper.Get(string.Format(_settings.ADVISER_GET_URL, adviserDetailId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PatchAdviserDetail<T>(T adviserDetail, Guid adviserDetailId, string version)
        {
            _response = await _httpHelper.Patch(adviserDetail, string.Format(_settings.ADVISER_PATCH_URL, adviserDetailId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PostAdviserDetail<T>(T adviserDetail, string version)
        {
            _response = await _httpHelper.Post(adviserDetail, _settings.ADVISER_POST_URL, _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}
