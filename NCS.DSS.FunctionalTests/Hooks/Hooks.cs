using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using FunctionalTests;
using FunctionalTests.StepDefs;
using NCS.DSS.FunctionalTests.Models;
using NCS.DSS.FunctionalTests.Helpers;

namespace NCS.DSS.FunctionalTests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly ScenarioContext scenarioContext;
    //    private NCS.DSS.FunctionalTests.EnvironmentSettings envSettings = new EnvironmentSettings();

        public Hooks(ScenarioContext context)
        {
            scenarioContext = context;

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Console.WriteLine("After Scenario: Tear down disabled");
            Console.WriteLine("After Scenario: Teardown data if it is stored against scenario context");
            return ;
            EnvironmentSettings envSettings = new EnvironmentSettings();
            SQLServerHelper sqlHelper = new SQLServerHelper();
            bool returnValue;

            if (scenarioContext.ContainsKey("TestData"))
            {
                List<TestDataItem> cleanupData = (List<TestDataItem>)scenarioContext["TestData"];

                sqlHelper.SetConnection(envSettings.sqlConnectionString);
                sqlHelper.OpenConnection();
                foreach (var item in cleanupData)
                {
                    CosmosHelper.Initialise(envSettings.CosmosEndPoint, envSettings.CosmosAccountKey);
                    returnValue = CosmosHelper.DeleteDocument(constants.CollectionNameFromId(item.Key), constants.CollectionNameFromId(item.Key), item.Id);
                    Console.WriteLine("Attempt Cosmos teardown " + item.Key + ":" + item.Id + (returnValue ? "Success" : "Failure"));
                    returnValue = sqlHelper.DeleteRecord(constants.BackupTableNameFromId(item.Key), "id", item.Id);
                    Console.WriteLine("Attempt SQL teardown " + item.Key + ":" + item.Id + (returnValue ? "Success" : "Failure"));
                    returnValue = sqlHelper.DeleteRecord(constants.HistoryTableNameFromId(item.Key), "id", item.Id);
                    Console.WriteLine("Attempt SQL History teardown " + item.Key + ":" + item.Id + (returnValue ? "Success" : "Failure"));
                }

                sqlHelper.CloseConnection();
            }
        }
    }
}
