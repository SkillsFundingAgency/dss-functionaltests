﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
//using NCS.DSS.FunctionalTest
//using NCS.DSS.Customer.Cosmos.Client;
//using NCS.DSS.Customer.Cosmos.Helper;
//using NCS.DSS.Customer.Cosmos.Provider;
//using NCS.DSS.Customer.Models;

namespace NCS.DSS.FunctionalTests.Cosmos.Provider
{
    //public class DocumentDBProvider : IDocumentDBProvider
    //{
    //    private readonly DocumentDBHelper _documentDbHelper;
    //    private readonly DocumentDBClient _databaseClient;

    //    public DocumentDBProvider()
    //    {
    //        _documentDbHelper = new DocumentDBHelper();
    //        _databaseClient = new DocumentDBClient();
    //    }

    //    public bool DoesCustomerResourceExist(Guid customerId)
    //    {
    //        try
    //        {
    //            var collectionUri = _documentDbHelper.CreateDocumentCollectionUri();

    //            var client = _databaseClient.CreateDocumentClient();

    //            if (client == null)
    //                return false;

    //            var query = client.CreateDocumentQuery<Models.Customer>(collectionUri, new FeedOptions { MaxItemCount = 1 });
    //            var customerExists = query.Where(x => x.CustomerId == customerId).AsEnumerable().Any();

    //            return customerExists;
    //        }
    //        catch
    //        {
    //            return false;
    //        }
    //    }

    //    public async Task<List<Models.Customer>> SearchAllCustomer(string givenName = null, string familyName = null, string dateofBirth = null,
    //        string uniqueLearnerNumber = null)
    //    {
    //        var collectionUri = _documentDbHelper.CreateDocumentCollectionUri();

    //        var client = _databaseClient.CreateDocumentClient();

    //        if (client == null)
    //            return null;

    //        var queryForCustomers = "SELECT * FROM c WHERE ";

    //        var addAndToQuery = false;

    //        if (!string.IsNullOrWhiteSpace(givenName))
    //        {
    //            queryForCustomers += "CONTAINS (LOWER(c.GivenName), LOWER('" + givenName + "'))";
    //            addAndToQuery = true;
    //        }

    //        if (!string.IsNullOrWhiteSpace(familyName))
    //        {
    //            if (addAndToQuery)
    //                queryForCustomers += " AND ";

    //            queryForCustomers += "CONTAINS (LOWER(c.FamilyName), LOWER('" + familyName + "'))";
    //            addAndToQuery = true;
    //        }

    //        if (!string.IsNullOrWhiteSpace(dateofBirth))
    //        {
    //            if (addAndToQuery)
    //                queryForCustomers += " AND ";

    //            queryForCustomers += "CONTAINS (c.DateofBirth, '" + dateofBirth + "')";
    //            addAndToQuery = true;
    //        }

    //        if (!string.IsNullOrWhiteSpace(uniqueLearnerNumber))
    //        {
    //            if (addAndToQuery)
    //                queryForCustomers += " AND ";

    //            queryForCustomers += "CONTAINS (LOWER(c.UniqueLearnerNumber), LOWER('" + uniqueLearnerNumber + "'))";
    //        }

    //        var queryCust = client.CreateDocumentQuery<Models.Customer>(collectionUri, queryForCustomers).AsDocumentQuery();

    //        var customers = new List<Models.Customer>();

    //        while (queryCust.HasMoreResults)
    //        {
    //            var response = await queryCust.ExecuteNextAsync<Models.Customer>();
    //            customers.AddRange(response);
    //        }

    //        return customers.Any() ? customers : null;
    //    }

    //    public async Task<List<Models.Customer>> GetAllCustomer()
    //    {
    //        var collectionUri = _documentDbHelper.CreateDocumentCollectionUri();

    //        var client = _databaseClient.CreateDocumentClient();

    //        if (client == null)
    //            return null;

    //        var queryCust = client.CreateDocumentQuery<Models.Customer>(collectionUri).AsDocumentQuery();

    //        var customers = new List<Models.Customer>();

    //        while (queryCust.HasMoreResults)
    //        {
    //            var response = await queryCust.ExecuteNextAsync<Models.Customer>();
    //            customers.AddRange(response);
    //        }

    //        return customers.Any() ? customers : null;
    //    }


    //    public async Task<Models.Customer> GetCustomerByIdAsync(Guid customerId)
    //    {
    //        var collectionUri = _documentDbHelper.CreateDocumentCollectionUri();

    //        var client = _databaseClient.CreateDocumentClient();

    //        var CustomerByIdQuery = client
    //            ?.CreateDocumentQuery<Models.Customer>(collectionUri, new FeedOptions { MaxItemCount = 1 })
    //            .Where(x => x.CustomerId == customerId)
    //            .AsDocumentQuery();

    //        if (CustomerByIdQuery == null)
    //            return null;

    //        var Customer = await CustomerByIdQuery.ExecuteNextAsync<Models.Customer>();

    //        return Customer?.FirstOrDefault();
    //    }


    //    public async Task<ResourceResponse<Document>> CreateCustomerAsync(Models.Customer customer)
    //    {
    //        var collectionUri = _documentDbHelper.CreateDocumentCollectionUri();

    //        var client = _databaseClient.CreateDocumentClient();

    //        if (client == null)
    //            return null;

    //        var response = await client.CreateDocumentAsync(collectionUri, customer);

    //        return response;

    //    }

    //    public async Task<ResourceResponse<Document>> UpdateCustomerAsync(Models.Customer customer)
    //    {
    //        var documentUri = _documentDbHelper.CreateDocumentUri(customer.CustomerId);

    //        var client = _databaseClient.CreateDocumentClient();

    //        if (client == null)
    //            return null;

    //        var response = await client.ReplaceDocumentAsync(documentUri, customer);

    //        return response;
    //    }
    //}
}