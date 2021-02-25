using NCS.DSS.FunctionalTests.Core;
using NCS.DSS.FunctionalTests.Extensions;
using NCS.DSS.FunctionalTests.Hooks;
using NCS.DSS.FunctionSteps.Core;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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
        private readonly HttpResponseHelper _assertionHelper;
        private readonly SqlHelper _sqlHelper;
        private readonly CosmosHelper _cosmosHelper;

        private string _cosmosDocument;

        public Step(
            ScenarioContext scenarioContext,
            FeatureContext featureContext,
            HttpHelper httphelper,
            EnvironmentSettings settings,
            HttpResponseHelper assertHelper,
            SqlHelper sqlhelper,
            CosmosHelper cosmosHelper)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
            _settings = settings;
            _httpHelper = httphelper;
            _assertionHelper = assertHelper;
            _sqlHelper = sqlhelper;
            _cosmosHelper = cosmosHelper;
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

        [Then(@"the response should contain (.*) document\(s\)")]
        public async Task ThenTheResponseShouldContainDocumentS(int p0)
        {
            var count = await _assertionHelper.DocumentCount(_response);
            Assert.AreEqual(p0, count);
        }

        [Given(@"I want to send (.*) with value (.*) in the following request")]
        public void GivenIAddAPropertyToScenarioContext(string propName, string propValue)
        {
            _scenarioContext.Add(propName, propValue);
        }

        [Given(@"I fetch a (.*) cosmos document from (.*) database using key (.*)")]
        public void GivenIFetchACosmosDocumentFrom(string collectionName, string databaseName, string id)
        {
            _cosmosDocument = _cosmosHelper.RetrieveDocument(databaseName, collectionName, id);
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
            var result = await _assertionHelper.ResponseShouldContain(_response, table);
            Assert.True(result);
        }

        //[Then(@"the response body should have (.*) with value date (Translate Date .*)")]
        //public async Task ResponseBodyShouldContainFieldWithTranslatedValue(string field, string value)
        //{
        //    var table = new Table("Field", "Value");
        //    table.AddRow(field, value);
        //    var result = await _assertionHelper.ResponseShouldContain(_response, table);
        //    Assert.True(result);
        //}

        private void DeleteRowFromSql(string table, string primaryKey, string id)
        {
            if (_featureContext.ContainsKey("CleanupData"))
            {
                var cleanupData = _featureContext["CleanupData"] as CleanupData;
                if (cleanupData != null)
                {
                    cleanupData.Database.Add(new Tuple<string, string, string>(table, primaryKey, id));
                }
            }
            else
                _featureContext.Add("CleanupData", new CleanupData());
        }

        [Then(@"there should be a record in the (.*) table with (.*)")]
        public async Task RecordShouldExistInSqlWithDetails(string table, string contextField)
        {
            var sqlTable = new List<object>();

            if (_scenarioContext.ContainsKey(contextField))
            {
                var result = await SqlRecordMatchesResponseJson(contextField, table, null);
                Assert.True(result);
            }
        }

        [Then(@"there should be a record in the (.*) table Ignoring '(.*)' with (.*)")]
        public async Task RecordShouldExistInSqlWithDetailsIgnoringFields(string table, string fieldsToIgnore, string contextField)
        {
            var sqlTable = new List<object>();
            var fieldsToIgnoreArray = fieldsToIgnore?.Split(",")?.ToList();

            if (_scenarioContext.ContainsKey(contextField))
            {
                var result = await SqlRecordMatchesResponseJson(contextField, table, fieldsToIgnoreArray);
                Assert.True(result);
            }
        }

        [Then(@"there should be (.*) records in the (.*) table with (.*)")]
        public async Task RecordCountShouldBe(int recordCount, string table, string contextField)
        {
            var count = 0;
            if (_scenarioContext.ContainsKey(contextField))
            {
                var val = _scenarioContext[contextField] as string;
                count = await _sqlHelper.RecordCount(table, val, recordCount);
            }
            Assert.That(count, Is.EqualTo(recordCount));
        }

        [Given("I wait for (.*) Seconds")]
        public async Task IWaitForSeconds(int seconds)
        {
            var milliSeconds = seconds * 1000;
            await Task.Delay(milliSeconds);
        }

        #region private scenario helpers
        private async Task<bool> SqlRecordMatchesResponseJson(string contextField, string table, List<string> fieldsToIgnoreArray)
        {
            var val = _scenarioContext[contextField] as string;
            var dataTable = await _sqlHelper.Query(table, val, 5, 5);
            var sqlTable = dataTable.AsListOfObjects();
            var contentString = await _assertionHelper.ResponseAsJson(_response);
            contentString = JsonHelper.RenameProperty(contentString, contextField, "id");
            var sqlJson = JsonHelper.ToSerializedObjectArray(sqlTable);
            var sqlRecordMatchesResponseResult = JsonHelper.JsonContains(sqlJson, contentString, fieldsToIgnoreArray);
            return sqlRecordMatchesResponseResult;
        }
        #endregion
    }
}
