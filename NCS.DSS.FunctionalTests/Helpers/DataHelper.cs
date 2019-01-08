using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace NCS.DSS.FunctionalTests.Helpers
{
    public class DataHelper
    {

        private const string EndpointUrl = "https://dss-at-shared-cdb.documents.azure.com:443";
        private const string PrimaryKey = "hbCu1uQMgFA8JzZ25afJj2r43X6CPzPHmpkA6yokoedvCVFj3D6iXyHTFa0l9W8WJudYW7xFvFT5JUZf9XJnow==";
        private DocumentClient client;


        public async Task GetStartedDemo()
        {
            this.client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
        }


    }
}
