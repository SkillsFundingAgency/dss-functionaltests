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
        [Given(@"I post an outcome with the following details:")]
        public async Task GivenIPostAOutcomeWithTheFollowingDetails(Table table)
        {
            var outcome = table.CreateInstance<Outcome>();
            var customerId = Guid.Empty;
            var interactionId = Guid.Empty;
            var actionPlanId = Guid.Empty;

            if (_scenarioContext.ContainsKey("InteractionId"))
                interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);


            if (_scenarioContext.ContainsKey("ActionPlanId"))
                actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);

            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);


            outcome.CustomerId = customerId.ToString();
            outcome.ActionPlanId = actionPlanId.ToString();

            await PostOutcome(outcome, customerId, interactionId, actionPlanId, Constants.API_VERSION_1);
            _scenarioContext["OutcomeId"] = await _assertionHelper.GetKeyFromResponse("OutcomeId", _response);
        }

        [When(@"I get an Outcome by ID")]
        public async Task WhenIGetAnOutcomeByID()
        {
            var customerId = Guid.Empty;
            var interactionId = Guid.Empty;
            var actionPlanId = Guid.Empty;
            var outcomeId = Guid.Empty;

            if (_scenarioContext.ContainsKey("InteractionId"))
                interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);

            if (_scenarioContext.ContainsKey("ActionPlanId"))
                actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);

            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);

            if (_scenarioContext.ContainsKey("OutcomeId"))
                outcomeId = Guid.Parse(_scenarioContext["OutcomeId"] as string);

            await GetOutcome(customerId, interactionId, actionPlanId, outcomeId, Constants.API_VERSION_1);
        }
        #endregion

        #region V2
        [Given(@"I post an outcome with the following details V2:")]
        public async Task GivenIPostAOutcomeWithTheFollowingDetailsV2(Table table)
        {
            var outcome = table.CreateInstance<OutcomeV2>();

            var customerId = Guid.Empty;
            var interactionId = Guid.Empty;
            var actionPlanId = Guid.Empty;
            var sessionId = Guid.Empty;

            if (_scenarioContext.ContainsKey("InteractionId"))
                interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);

            if (_scenarioContext.ContainsKey("ActionPlanId"))
                actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);

            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);

            if (_scenarioContext.ContainsKey("SessionId"))
                sessionId = Guid.Parse(_scenarioContext["SessionId"] as string);


            outcome.CustomerId = customerId.ToString();
            outcome.ActionPlanId = actionPlanId.ToString();
            outcome.SessionId = sessionId.ToString();
            await PostOutcome(outcome, customerId, interactionId, actionPlanId, Constants.API_VERSION_2);
            _scenarioContext["OutcomeId"] = await _assertionHelper.GetKeyFromResponse("OutcomeId", _response);
        }

        [When(@"I get an Outcome by ID V2")]
        public async Task WhenIGetAnOutcomeByIDV2()
        {
            var customerId = Guid.Empty;
            var interactionId = Guid.Empty;
            var actionPlanId = Guid.Empty;
            var outcomeId = Guid.Empty;

            if (_scenarioContext.ContainsKey("InteractionId"))
                interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);

            if (_scenarioContext.ContainsKey("ActionPlanId"))
                actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);

            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);

            if (_scenarioContext.ContainsKey("OutcomeId"))
                outcomeId = Guid.Parse(_scenarioContext["OutcomeId"] as string);

            await GetOutcome(customerId, interactionId, actionPlanId, outcomeId, Constants.API_VERSION_2);
        }
        #endregion

        #region V3
        [Given(@"I post an outcome with the following details V3:")]
        public async Task GivenIPostAOutcomeWithTheFollowingDetailsV3(Table table)
        {
            var outcome = table.CreateInstance<OutcomeV3>();

            var customerId = Guid.Empty;
            var interactionId = Guid.Empty;
            var actionPlanId = Guid.Empty;
            var sessionId = Guid.Empty;

            if (_scenarioContext.ContainsKey("InteractionId"))
                interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);


            if (_scenarioContext.ContainsKey("ActionPlanId"))
                actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);

            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);

            if (_scenarioContext.ContainsKey("SessionId"))
                sessionId = Guid.Parse(_scenarioContext["SessionId"] as string);


            outcome.CustomerId = customerId.ToString();
            outcome.ActionPlanId = actionPlanId.ToString();
            outcome.SessionId = sessionId.ToString();
            await PostOutcome(outcome, customerId, interactionId, actionPlanId, Constants.API_VERSION_3);
            _scenarioContext["OutcomeId"] = await _assertionHelper.GetKeyFromResponse("OutcomeId", _response);
        }

        [When(@"I get an Outcome by ID V3")]
        public async Task WhenIGetAnOutcomeByIDV3()
        {
            var customerId = Guid.Empty;
            var interactionId = Guid.Empty;
            var actionPlanId = Guid.Empty;
            var outcomeId = Guid.Empty;

            if (_scenarioContext.ContainsKey("InteractionId"))
                interactionId = Guid.Parse(_scenarioContext["InteractionId"] as string);

            if (_scenarioContext.ContainsKey("ActionPlanId"))
                actionPlanId = Guid.Parse(_scenarioContext["ActionPlanId"] as string);

            if (_scenarioContext.ContainsKey("CustomerId"))
                customerId = Guid.Parse(_scenarioContext["CustomerId"] as string);

            if (_scenarioContext.ContainsKey("OutcomeId"))
                outcomeId = Guid.Parse(_scenarioContext["OutcomeId"] as string);

            await GetOutcome(customerId, interactionId, actionPlanId, outcomeId, Constants.API_VERSION_3);
        }
        #endregion

        #region private methods for post/patch/get
        private async Task GetOutcome(Guid customerId, Guid interactionId, Guid actionPlan, Guid outcomeId, string version)
        {
            _response = await _httpHelper.Get(string.Format(_settings.OUTCOMES_GET_URL, customerId, interactionId, actionPlan, outcomeId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PatchOutcome<T>(T digitalIdentity, Guid customerId, Guid interactionId, Guid actionPlanId, Guid outcomeId, string version)
        {
            _response = await _httpHelper.Patch(digitalIdentity, string.Format(_settings.OUTCOMES_PATCH_URL, customerId, interactionId, actionPlanId, outcomeId), _touchPointId, version, _settings.SubscriptionKey);
        }

        private async Task PostOutcome<T>(T digitalIdentity, Guid customerId, Guid interactionId, Guid actionPlanId, string version)
        {
            _response = await _httpHelper.Post(digitalIdentity, string.Format(_settings.OUTCOMES_POST_URL, customerId, interactionId, actionPlanId), _touchPointId, version, _settings.SubscriptionKey);
        }
        #endregion
    }
}
