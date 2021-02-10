using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using FunctionalTests;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace NCS.DSS.FunctionalTests.Helpers
{
    public class DataHelper
    {
        EnvironmentSettings envSettings = new EnvironmentSettings();
        private DocumentClient client;


        public async Task GetStartedDemo()
        {
            this.client = new DocumentClient(new Uri(envSettings.CosmosEndPoint), envSettings.CosmosAccountKey);
        }


    }
}
