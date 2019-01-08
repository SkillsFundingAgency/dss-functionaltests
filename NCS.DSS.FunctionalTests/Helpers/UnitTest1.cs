using FunctionalTests;
using FunctionalTests.Helpers;
using FunctionalTests.Models;
using Microsoft.Azure.Documents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RandomNameGenerator;
using RestSharp;
using System;
using System.IO;

namespace NCS.DSS.FunctionalTests.Helpers
{
    [TestClass]
    public class UnitTest1
    {

      //[TestMethod]
      //  public void TestDatabaseConnection()
      //  {
      //      DataHelper dataHelper = new DataHelper();

      //      dataHelper.GetStartedDemo();

      //  }

        //[TestMethod]
        //public void TestCreateRandomUsers()
        //{
        //    string firstName;
        //    using (StreamWriter writetext = new StreamWriter("C:\\Temp\\customerData.txt"))

        //        for (int i = 0; i < 5000; i++)
        //        {
        //            string part1 = RandomNumber(10000, 99999).ToString();
        //            string part2 = RandomNumber(00001, 99999).ToString();
        //            string uniqueLearnerNum = part1 + part2;

        //            if (i % 2 == 0)
        //            {
        //                firstName = RandomNameGenerator.NameGenerator.GenerateFirstName(Gender.Male);
        //            }
        //            else
        //            {
        //                firstName = RandomNameGenerator.NameGenerator.GenerateFirstName(Gender.Female);
        //            }

        //            string lastName = RandomNameGenerator.NameGenerator.GenerateLastName();

        //            Random r = new Random();
        //            DateTime rDate = new DateTime(r.Next(1960, 2004), r.Next(1, 12), r.Next(1, 28));
        //            String dateOfBirth = rDate.ToString().Replace("/", "-");

        //            string url = "https://test.api.nationalcareersservice.org.uk/customers/api/customers/";

        //            Customer customer = new Customer();
        //            customer.GivenName = firstName;
        //            customer.FamilyName = lastName;
        //            customer.DateofBirth = dateOfBirth;
        //            customer.UniqueLearnerNumber = uniqueLearnerNum;

        //            string json = JsonConvert.SerializeObject(customer);
        //            IRestResponse response = RestHelper.Post(url, json);
        //            if (response.IsSuccessful)
        //            {
        //                writetext.WriteLine(firstName + "," + lastName + "," + dateOfBirth + "" + uniqueLearnerNum);

        //            }
        //        }
        //}

        //[TestMethod]
        //public void TestCreateRandomUsersSameFirstName()
        //{
        //    string firstName;
        //    using (StreamWriter writetext = new StreamWriter("C:\\Temp\\customersGivenName.txt"))

        //        for (int i = 0; i < 50; i++)
        //        {

        //            string part1 = RandomNumber(10000, 99999).ToString();
        //            string part2 = RandomNumber(00001, 99999).ToString();
        //            string uniqueLearnerNum = part1 + part2;             
        //            firstName = "Bagpuss";//Zippo
        //            string lastName = RandomNameGenerator.NameGenerator.GenerateLastName();

        //            Random r = new Random();
        //            DateTime rDate = new DateTime(r.Next(1960, 2004), r.Next(1, 12), r.Next(1, 28));
        //            String dateOfBirth = rDate.ToString().Replace("/", "-");

        //            string url = "https://test.api.nationalcareersservice.org.uk/customers/api/customers/";

        //            Customer customer = new Customer();
        //            customer.GivenName = firstName;
        //            customer.FamilyName = lastName;
        //            customer.DateofBirth = dateOfBirth;
        //            customer.UniqueLearnerNumber = uniqueLearnerNum;

        //            string json = JsonConvert.SerializeObject(customer);
        //            IRestResponse response = RestHelper.Post(url, json);
        //            if (response.IsSuccessful)
        //            {
        //                writetext.WriteLine(firstName + " " + lastName + " " + dateOfBirth + " " + uniqueLearnerNum);
        //            }
        //        }
        //}

        //[TestMethod]
        //public void TestCreateRandomUsersSameLastName()
        //{
        //    string firstName;
        //    using (StreamWriter writetext = new StreamWriter("C:\\Temp\\customersFamilyName.txt"))

        //        for (int i = 0; i < 50; i++)
        //        {

        //            string part1 = RandomNumber(10000, 99999).ToString();
        //            string part2 = RandomNumber(00001, 99999).ToString();
        //            string uniqueLearnerNum = part1 + part2;

        //            if (i % 2 == 0)
        //            {
        //                firstName = RandomNameGenerator.NameGenerator.GenerateFirstName(Gender.Male);
        //            }
        //            else
        //            {
        //                firstName = RandomNameGenerator.NameGenerator.GenerateFirstName(Gender.Female);
        //            }

        //            string lastName = "Zebedee";

        //            Random r = new Random();
        //            DateTime rDate = new DateTime(r.Next(1960, 2004), r.Next(1, 12), r.Next(1, 28));
        //            String dateOfBirth = rDate.ToString().Replace("/", "-");

        //            string url = "https://test.api.nationalcareersservice.org.uk/customers/api/customers/";

        //            Customer customer = new Customer();
        //            customer.GivenName = firstName;
        //            customer.FamilyName = lastName;
        //            customer.DateofBirth = dateOfBirth;
        //            customer.UniqueLearnerNumber = uniqueLearnerNum;

        //            string json = JsonConvert.SerializeObject(customer);
        //            IRestResponse response = RestHelper.Post(url, json);
        //            if (response.IsSuccessful)
        //            {
        //                writetext.WriteLine(firstName + " " + lastName + " " + dateOfBirth + " " + uniqueLearnerNum);
        //            }
        //        }
        //}


        //[TestMethod]
        //public void TestCreateRandomUsersSameDoB()
        //{
        //    string firstName;
        //    using (StreamWriter writetext = new StreamWriter("C:\\Temp\\customersDateOfBirth.txt"))

        //        for (int i = 0; i < 40; i++)
        //        {

        //            string part1 = RandomNumber(10000, 99999).ToString();
        //            string part2 = RandomNumber(00001, 99999).ToString();
        //            string uniqueLearnerNum = part1 + part2;

        //            if (i % 2 == 0)
        //            {
        //                firstName = RandomNameGenerator.NameGenerator.GenerateFirstName(Gender.Male);
        //            }
        //            else
        //            {
        //                firstName = RandomNameGenerator.NameGenerator.GenerateFirstName(Gender.Female);
        //            }

        //            string lastName = RandomNameGenerator.NameGenerator.GenerateLastName();


        //            String dateOfBirth = "2005-11-01";

        //            string url = "https://test.api.nationalcareersservice.org.uk/customers/api/customers/";

        //            Customer customer = new Customer();
        //            customer.GivenName = firstName;
        //            customer.FamilyName = lastName;
        //            customer.DateofBirth = dateOfBirth;
        //            customer.UniqueLearnerNumber = uniqueLearnerNum;

        //            string json = JsonConvert.SerializeObject(customer);
        //            IRestResponse response = RestHelper.Post(url, json);
        //            if (response.IsSuccessful)
        //            {
        //                writetext.WriteLine(firstName + " " + lastName + " " + dateOfBirth + " " + uniqueLearnerNum);
        //            }
        //        }
        //}

        //[TestMethod]
        //public void TestDBConnection()
        //{

        //    try
        //    {
        //        DataHelper p = new DataHelper();
        //        p.GetStartedDemo().Wait();
        //    }
        //    catch (DocumentClientException de)
        //    {
        //        Exception baseException = de.GetBaseException();
        //        Console.WriteLine("{0} error occurred: {1}, Message: {2}", de.StatusCode, de.Message, baseException.Message);
        //    }
        //    catch (Exception e)
        //    {
        //        Exception baseException = e.GetBaseException();
        //        Console.WriteLine("Error: {0}, Message: {1}", e.Message, baseException.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("End of demo, press any key to exit.");
        //        Console.ReadKey();
        //    }






        //}




        //public int RandomNumber(int min, int max)
        //{
        //    Random random = new Random();
        //    return random.Next(min, max);
        //}

    }
}
