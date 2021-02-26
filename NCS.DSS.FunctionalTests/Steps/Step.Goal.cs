using NCS.DSS.FunctionalTests.Models;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {
        #region V1
        [When(@"I get a Goal by ID")]
        public async Task WhenGetTheFollowingGoal()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            var goalId = Guid.Parse(_scenarioContext["GoalId"] as string);
            await GetByGoalId(customerId, interactionId, actionPlanId, goalId, "");
        }

        [Given(@"I post a goal with the following details:")]
        public async Task WhenPostTheFollowingGoal(Table table)
        {
            var goal = table.CreateInstance<Goal>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);

            await PostGoal(goal, customerId, interactionId, actionPlanId, "");

            if (_response.IsSuccessStatusCode)
                _scenarioContext["GoalId"] = await _assertionHelper.GetKeyFromResponse("GoalId", _response);


            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-goals", "id", _scenarioContext["GoalId"] as string);
        }

        [When(@"I patch the following Goal:")]
        public async Task WhenPatchTheFollowingGoal(Table table)
        {
            var goal = table.CreateInstance<Goal>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            var goalId = Guid.Parse(_scenarioContext["GoalId"] as string);
            await PatchGoal(goal, customerId, interactionId, actionPlanId, goalId, "");
        }
        #endregion

        #region V2
        [When(@"I get a Goal by ID V2")]
        public async Task WhenGetTheFollowingGoalV2()
        {
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            var goalId = Guid.Parse(_scenarioContext["GoalId"] as string);
            await GetByGoalId(customerId, interactionId, actionPlanId, goalId, "v2");
        }

        [Given(@"I post a goal with the following details V2:")]
        public async Task WhenPostTheFollowingGoalV2(Table table)
        {
            var goal = table.CreateInstance<GoalV2>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            goal.CustomerId = _scenarioContext["CustomerId"] as string;
            goal.ActionPlanId = _scenarioContext["ActionPlanId"] as string;
            await PostGoal(goal, customerId, interactionId, actionPlanId, "v2");

            if (_response.IsSuccessStatusCode)
                _scenarioContext["GoalId"] = await _assertionHelper.GetKeyFromResponse("GoalId", _response);


            if (_response.IsSuccessStatusCode)
                DeleteRowFromSql("dss-goals", "id", _scenarioContext["GoalId"] as string);
        }

        [When(@"I patch the following Goal V2:")]
        public async Task WhenPatchTheFollowingGoalV2(Table table)
        {
            var goal = table.CreateInstance<GoalV2>();
            var customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);
            var interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);
            var actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);
            var goalId = Guid.Parse(_scenarioContext["GoalId"] as string);
            await PatchGoal(goal, customerId,interactionId, actionPlanId, goalId, "v2");
        }
        #endregion

        #region private get/set/post
        private async Task PatchGoal<T>(T goal, Guid customerId, Guid interactionId, Guid actionPlanId, Guid goalId, string version)
        {
            _response = await _httpHelper.Patch(goal, string.Format(_settings.GOAL_PATCH_URL, customerId, interactionId, actionPlanId, goalId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }

        private async Task GetByGoalId(Guid customerId, Guid interactionId, Guid actionPlanId, Guid goalId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.GOAL_GET_URL, customerId, interactionId, actionPlanId, goalId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }

        private async Task PostGoal<T>(T goal, Guid customerId, Guid interactionId, Guid actionPlanId, string version)
        {
            _response = await _httpHelper.Post(goal, string.Format(_settings.GOAL_POST_URL, customerId, interactionId, actionPlanId), _settings.TestEndpoint01, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}
