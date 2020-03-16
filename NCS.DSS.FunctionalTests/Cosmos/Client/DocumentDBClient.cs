﻿using System;
using System.Configuration;
// Added using statement back in
using Microsoft.Azure.Documents.Client;

namespace NCS.DSS.Action.Cosmos.Client
{
    public static class DocumentDBClient
    {
        private static DocumentClient _documentClient;

        public static DocumentClient CreateDocumentClient()
        {
            if (_documentClient != null)
                return _documentClient;

            _documentClient = new DocumentClient(new Uri(
                ConfigurationManager.AppSettings["Endpoint"]),
                ConfigurationManager.AppSettings["Key"]);

            return _documentClient;
        }
    }
}
