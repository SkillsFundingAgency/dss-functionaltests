using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Linq;

namespace NCS.DSS.FunctionalTests.Core
{
    public class CosmosHelper
    {
        private DocumentClient _client;
        private readonly EnvironmentSettings _settings;

        public CosmosHelper(EnvironmentSettings settings)
        {
            _settings = settings;
        }

        public string RetrieveDocument(string database, string collection, string id)
        {
            string doc = "";
            using (_client = new DocumentClient(new Uri(_settings.CosmosEndPoint), _settings.CosmosAccountKey))
            {
                try
                {
                    doc = _client.CreateDocumentQuery(
                    UriFactory.CreateDocumentCollectionUri(database, collection))
                                .Where(x => x.Id == id.ToString())
                                .AsEnumerable()
                                .First().ToString();
                }
                catch (DocumentClientException de)
                {
                    Exception baseException = de.GetBaseException();
                    Console.WriteLine("Failed to retrieve cosmos document: " + database + " id: " + id);
                    Console.WriteLine("{0} error occurred: {1}, Message: {2}", de.StatusCode, de.Message, baseException.Message);

                }
            }
            return doc;
        }
    }
}
