using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NCS.DSS.FunctionalTests.Hooks
{
    [Binding]
    public sealed class CleanupHook
    {
        [AfterFeature]
        public static async Task AfterFeature(FeatureContext featureContext, EnvironmentSettings settings)
        {
            if (featureContext.ContainsKey("CleanupData"))
            {
                var cleanupData = featureContext["CleanupData"] as CleanupData;
                if (cleanupData != null)
                {
                    // remote cosmos rows
                    foreach (var dataItem in cleanupData.Documents)
                    {

                    }

                    // Remove sql rows from both history tables
                    using (var sqlConnection = new SqlConnection(settings.sqlConnectionString))
                    {
                        await sqlConnection.OpenAsync();
                        foreach (var sqlRow in cleanupData.Database)
                        {
                            var deleteRecordCommand = new SqlCommand($"DELETE FROM [dbo].[{sqlRow.Item1}] where {sqlRow.Item2} = '{sqlRow.Item3.ToString()}'", sqlConnection);
                            await deleteRecordCommand.ExecuteNonQueryAsync();

                            var deleteHistoryCommand = new SqlCommand($"DELETE FROM [dbo].[{sqlRow.Item1}-history] where {sqlRow.Item2} = '{sqlRow.Item3.ToString()}'", sqlConnection);
                            await deleteHistoryCommand.ExecuteNonQueryAsync();
                        }
                        await sqlConnection.CloseAsync();
                    }
                }
            }
        }

        [AfterScenario]
        public static async Task AfterEachScenario(EnvironmentSettings settings)
        {
            //Investigate putting an artificial delay between each scenario, because cos
        }
    }


    public class CleanupData
    {
        public List<Tuple<string, string, string>> Database;
        public List<Tuple<string, string>> Documents;

        public CleanupData()
        {
            Database = new List<Tuple<string, string, string>>();
            Documents = new List<Tuple<string, string>>();
        }
    }
}

