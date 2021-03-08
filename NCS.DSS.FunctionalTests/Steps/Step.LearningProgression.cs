using NCS.DSS.FunctionalTests.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    partial class Step
    {
        #region v3
        [Given(@"I post a Learning Progression record with the following details V3:")]
        public async Task GivenIPostALearningProgressionWithTheFollowingDetailsV2(Table table)
        {
            foreach (var item in _scenarioContext.Keys)
            {
                var value = _scenarioContext[item] as string;
                table.AddRow(item, value);
            }
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var learningProgression = table.CreateInstance<LearningProgression>();
            await PostLearningProgression(learningProgression, customerId, "v3");
            if (_response.IsSuccessStatusCode)
            {
                _scenarioContext["LearningProgressionId"] = await _assertionHelper.GetKeyFromResponse("LearningProgressionId", _response);
                DeleteRowFromSql("dss-learningprogressions", "id", _scenarioContext["LearningProgressionId"] as string);
            }
        }

        [When(@"I get a Learning Progression by ID V3")]
        public async Task WhenIGetAnEmploymentProgressionByID()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var learningProgressionId = Guid.Parse(_scenarioContext["LearningProgressionId"] as string);
            await GetLearningProgressionById(customerId, learningProgressionId, "v3");
        }

        [When(@"I get all Learning Progression records for a customer V3")]
        public async Task WhenIGetAllEmploymentProgressionByCustomerID()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var learningProgressionId = Guid.Parse(_scenarioContext["LearningProgressionId"] as string);
            await GetAllLearningProgressionById(customerId, "v3");
        }

        [When(@"I patch the following LearningProgression V3:")]
        public async Task WhenPatchTheFollowingLearningProgression(Table table)
        {
            foreach (var item in _scenarioContext.Keys)
            {
                var value = _scenarioContext[item] as string;
                table.AddRow(item, value);
            }
            var learningProgression = table.CreateInstance<LearningProgression>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var learningProgressionId = Guid.Parse(_scenarioContext["LearningProgressionId"] as string);
            await PatchLearningProgression(learningProgression, customerId, learningProgressionId, "v3");
        }
        #endregion

        #region private get/set/patch

        private async Task GetAllLearningProgressionById(Guid customerId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.LEARNINGPROGRESSION_GETALL_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PatchLearningProgression<T>(T learningProgression, Guid customerId, Guid learningProgressionId, string version)
        {
            _response = await _httpHelper.Patch(learningProgression, string.Format(_settings.LEARNINGPROGRESSION_PATCH_URL, customerId, learningProgressionId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task GetLearningProgressionById(Guid customerId, Guid learningProgressionId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.LEARNINGPROGRESSION_GET_URL, customerId, learningProgressionId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PostLearningProgression<T>(T learningProgression, Guid customerId, string version)
        {
            _response = await _httpHelper.Post(learningProgression, string.Format(_settings.LEARNINGPROGRESSION_POST_URL, customerId), _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}
