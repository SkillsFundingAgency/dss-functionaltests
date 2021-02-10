using NCS.DSS.FunctionSteps.Core;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NCS.DSS.FunctionalTests.Steps
{
    [Binding]
    public partial class Step
    {
        private HttpResponseMessage _response;
        private readonly ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;
        private readonly EnvironmentSettings _settings;
        private readonly HttpHelper _httpHelper;
        private readonly HttpResponseAssertionHelper _assertionHelper;

        public Step(ScenarioContext scenarioContext, FeatureContext featureContext, HttpHelper httphelper, EnvironmentSettings settings, HttpResponseAssertionHelper assertHelper)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
            _settings = settings;
            _httpHelper = httphelper;
            _assertionHelper = assertHelper;
        }

        [Then(@"there should be a (.*) response")]
        public void ThenThereShouldBeAResponse(int expectedResponseCode)
        {
            int numericStatusCode = (int)_response.StatusCode; ;
            Assert.AreEqual(expectedResponseCode, numericStatusCode);
        }

        [Then(@"the error message should be ""(.*)""")]
        public async Task ThenTheErrorMessageShouldBe(string expectedMessage)
        {
            var content = await _response.Content.ReadAsStringAsync();
            StringAssert.Contains(expectedMessage, content);
        }

        [Then(@"the response body should include (.*)")]
        public async Task ThenTheResponseBodyShouldinclude(string p0)
        {
            var content = await _response.Content.ReadAsStringAsync();
            StringAssert.Contains(p0, content);
        }

        [Then(@"the response body should contain:")]
        public async Task ThenMyBindingShouldHaveTheFollowingObjects(Table table)
        {
            Assert.True(await _assertionHelper.ResponseShouldContain(_response, table));
        }

        [Then(@"the response body should not contain the ""(.*)""")]
        public async Task ThenTheResponseBodyShouldNotContainThe(string p0)
        {
            var content = await _response.Content.ReadAsStringAsync();
            StringAssert.DoesNotContain(p0, content);
        }

        [Then(@"the response body should contain the SubContractorId")]
        public void ThenTheResponseBodyShouldContainTheSubContractorId()
        {
            //TODO: TO WIRE UP THIS.
            //response.Content.Should().Contain(ScenarioContext.Current.Get<string>("subcontractorId"));
        }

        [Given(@"I want to send (.*) with value (.*) in the following request")]
        public void GivenIAddAPropertyToScenarioContext(string propName, string propValue)
        {
            _scenarioContext.Add(propName, propValue);
        }

        /// <summary>
        /// prop value is generated using DateTransformation.cs
        /// </summary>
        /// <param name="propName"></param>
        /// <param name="propValue"></param>
        [Given(@"I want to send (.*) with value (Translate Date .*)")]
        public void GivenIAddAPropertyToScenarioContextTransformDate(string propName, string propValue)
        {
            _scenarioContext.Add(propName, propValue);
        }

        [Then(@"the date field (.*) should hold a recent value")]
        public void ThenTheDateFieldShouldHoldARecentValue(string p0)
        {
            //DateTime testDate;
            //DateTime.TryParse(JsonHelper.GetPropertyFromJsonString(response.Content, p0), out testDate).Should().BeTrue("Because a date is expected in " + p0);
            //testDate.Should().BeCloseTo(DateTime.Now, 60000, "Because " + JsonHelper.GetPropertyFromJsonString(response.Content, p0) + " should be a recent value");
            //// THIS CONVERTS ALL DATE TO LOCAL TIME RATHER THAN UTC, BUT AS COMPARIING THEM THIS SHOULD BE OK
        }

        [Then(@"the number of errors returned should be (.*)")]
        public async Task ThenTheNumberOfErrorsReturnedShouldBe(int p0)
        {
            var content = await _response.Content.ReadAsStringAsync();
            JToken token = JToken.Parse(content);
            if (token.Type == JTokenType.Array)
            {
                var array = JArray.Parse(content);
                Assert.AreEqual(p0, array.Count());
            }
        }

        [Then(@"the response body should have (.*) with value (.*)")]
        public async Task ResponseBodyShouldContainFieldWithValue(string field, string value)
        {
            var table = new Table("Field", "Value");
            table.AddRow(field, value);
            await _assertionHelper.ResponseShouldContain(_response, table);
        }
    }
}
