using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow.Assist;
using Newtonsoft.Json;
using FluentAssertions;
using System.Net;
using System.Collections.Generic;
using System.Dynamic;
using FunctionalTests.Helpers;
using FunctionalTests.Models;

namespace FunctionalTests.StepDefs
{
    [Binding]
    public class PostSteps
    {

        private Dictionary<int, Customer> MyObjects;
        private readonly RestHelper Rest = new RestHelper();
        private readonly RestRequest restRequest;
        private IRestResponse response;
        private string json;


        [Given(@"I post a Customer with the following details:")]
        public void GivenIPostACustomerWithTheFollowingDetails(Table table)
        {
            var customer = table.CreateInstance<Customer>();

            IEnumerable<dynamic> cust = table.CreateDynamicSet();

            //convert table to json object:
            //string json = new JavaScriptSerializer().Serialize(cust);

            string json2 = JsonConvert.SerializeObject(cust);

            //strip out unwanted fields fcx

            response = RestHelper.Post(json2);
        }
        
        [Then(@"there should be a (.*) response")]
        public void ThenThereShouldBeAResponse(int expectedResponseCode)
        {
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            numericStatusCode.Should().Be(expectedResponseCode);
        }
        
        [Then(@"the error message should be ""(.*)""")]
        public void ThenTheErrorMessageShouldBe(string expectedMessage)
        {
            response.ErrorMessage.Should().Contain(expectedMessage);
        }
    }
}
