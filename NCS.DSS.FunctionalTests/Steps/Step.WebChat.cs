using NCS.DSS.FunctionalTests.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NCS.DSS.FunctionalTests.Steps
{
    public partial class Step
    {

        [Given(@"I post a webchat with the following details:")]
        public async Task GivenIPostAWebchatWithTheFollowingDetails(Table table)
        {
            var webchat = table.CreateInstance<WebChat>();
            _response = await _httpHelper.Post(webchat, _settings.WEBCHAT_POST_URL, _settings.TestEndpoint01, "", _settings.SubscriptionKey);
            _scenarioContext["WebchatId"] = await _assertionHelper.GetKeyFromResponse("WebchatId", _response);
        }

    }
}
