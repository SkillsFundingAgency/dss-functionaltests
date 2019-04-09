using System;
using System.Collections;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace FunctionalTests
{
    public class EnvironmentSettings 
    {
        private static readonly IConfiguration Configuration =
            new EnvironmentSettingsConfigurationBuilder(nameof(NCS.DSS.FunctionalTests)).BuildConfiguration();

        public string BaseUrl => Configuration["RestService:BaseUrl"];
        public string TestEndpoint01 => Configuration["RestService:TestEndpoint01"];
        public string TestEndpoint02 => Configuration["RestService:TestEndpoint02"];
        public string TestEndpoint03 => Configuration["RestService:TestEndpoint03"];
        public string SubscriptionKey => Configuration["RestService:SubscriptionKey"];
        public string sqlConnectionString => Configuration["SQLDataStore:ConnectionString"];
        public string CosmosEndPoint => Configuration["CosmosDB:EndPoint"];
        public string CosmosAccountKey => Configuration["CosmosDB:Key"];
    }
}
