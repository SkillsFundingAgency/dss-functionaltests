using Polly;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace NCS.DSS.FunctionalTests.Core
{
    public class SqlHelper
    {
        private readonly EnvironmentSettings _settings;

        public SqlHelper(EnvironmentSettings settings)
        {
            _settings = settings;
        }

        private async Task<DataTable> Query(string sql)
        {
            var dataTable = new DataTable();
            using (var sqlConnection = new SqlConnection(_settings.sqlConnectionString))
            {
                await sqlConnection.OpenAsync();
                var command = new SqlCommand(sql, sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dataTable);
                await sqlConnection.CloseAsync();
            }
            return dataTable;
        }

        public async Task<DataTable> Query(string table, string id, int retries = 3, int waitTime = 5)
        {
            var sql = $"SELECT * FROM [dbo].[{table}] where id = '{id}'";
            var retryPolicy = Policy
                .Handle<Exception>()
                .OrResult<DataTable>(r => r?.Rows?.Count == 0)
                .WaitAndRetryAsync(retries, (time) =>
                {
                    return TimeSpan.FromSeconds(waitTime * time);
                });

            var response = await retryPolicy.ExecuteAndCaptureAsync(() =>
            {
                return Query(sql);
            });
            return response.FaultType.HasValue ? response.FinalHandledResult : response.Result;
        }

        public async Task<int> RecordCount(string table, string id, int expectedRowCount, int retries = 3, int waitTime = 5)
        {
            var sql = $"SELECT * FROM [dbo].[{table}] where id = '{id}'";
            var retryPolicy = Policy
                .Handle<Exception>()
                .OrResult<DataTable>(r => r?.Rows?.Count != expectedRowCount)
                .WaitAndRetryAsync(retries, (time) =>
                {
                    return TimeSpan.FromSeconds(waitTime * time);
                });

            var response = await retryPolicy.ExecuteAndCaptureAsync(() =>
            {
                return Query(sql);
            });

            return response.Result?.Rows?.Count ?? 0;
        }
    }
}


