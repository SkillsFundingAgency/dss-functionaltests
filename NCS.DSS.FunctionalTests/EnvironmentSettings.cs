﻿using System;
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
        public string TouchPointId => Configuration["RestService:TouchPointId"];
        public string SubscriptionKey => Configuration["RestService:SubscriptionKey"];
        public string CosmosEndPoint => Configuration["CosmosDB:EndPoint"];
        public string CosmosAccountKey => Configuration["CosmosDB:Key"];
    }
}
