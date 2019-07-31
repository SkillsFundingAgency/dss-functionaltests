﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace NCS.DSS.FunctionalTests.Features.Customer
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PostV2")]
    [NUnit.Framework.CategoryAttribute("postV2")]
    public partial class PostV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PostV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PostV2", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV2"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Missing GivenName")]
        [NUnit.Framework.CategoryAttribute("customers")]
        public virtual void PostMissingGivenName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Missing GivenName", null, new string[] {
                        "customers"});
#line 7
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table1.AddRow(new string[] {
                        "DateOfRegistration",
                        "2018-07-27T16:11:00Z"});
            table1.AddRow(new string[] {
                        "Title",
                        "2"});
            table1.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table1.AddRow(new string[] {
                        "DateofBirth",
                        "2005-07-26T13:45:00Z"});
            table1.AddRow(new string[] {
                        "Gender",
                        "1"});
            table1.AddRow(new string[] {
                        "UniqueLearnerNumber",
                        "9876543210"});
            table1.AddRow(new string[] {
                        "OptInUserResearch",
                        "true"});
            table1.AddRow(new string[] {
                        "OptInMarketResearch",
                        "false"});
            table1.AddRow(new string[] {
                        "DateOfTermination",
                        "2018-07-27T14:45:00Z"});
            table1.AddRow(new string[] {
                        "ReasonForTermination",
                        "1"});
            table1.AddRow(new string[] {
                        "IntroducedBy",
                        "1"});
            table1.AddRow(new string[] {
                        "IntroducedByAdditionalInfo",
                        "additional info"});
            table1.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-21T14:45:00Z"});
#line 8
  testRunner.Given("I post a Customer with the following details:", ((string)(null)), table1, "Given ");
#line 23
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
  testRunner.And("the error message should be \"Given Name is a required field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Missing FamilyName")]
        [NUnit.Framework.CategoryAttribute("customers")]
        public virtual void PostMissingFamilyName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Missing FamilyName", null, new string[] {
                        "customers"});
#line 27
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table2.AddRow(new string[] {
                        "DateOfRegistration",
                        "2018-07-27T16:11:00Z"});
            table2.AddRow(new string[] {
                        "Title",
                        "13"});
            table2.AddRow(new string[] {
                        "GivenName",
                        "Customer"});
            table2.AddRow(new string[] {
                        "DateofBirth",
                        "2005-07-26T13:45:00Z"});
            table2.AddRow(new string[] {
                        "Gender",
                        "1"});
            table2.AddRow(new string[] {
                        "UniqueLearnerNumber",
                        "9876543210"});
            table2.AddRow(new string[] {
                        "OptInUserResearch",
                        "true"});
            table2.AddRow(new string[] {
                        "OptInMarketResearch",
                        "false"});
            table2.AddRow(new string[] {
                        "DateOfTermination",
                        "2018-07-27T14:45:00Z"});
            table2.AddRow(new string[] {
                        "ReasonForTermination",
                        "1"});
            table2.AddRow(new string[] {
                        "IntroducedBy",
                        "1"});
            table2.AddRow(new string[] {
                        "IntroducedByAdditionalInfo",
                        "additional info"});
#line 28
  testRunner.Given("I post a Customer with the following details:", ((string)(null)), table2, "Given ");
#line 42
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Valid Customer")]
        [NUnit.Framework.CategoryAttribute("customers")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PostValidCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Valid Customer", null, new string[] {
                        "customers",
                        "smoke"});
#line 45
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "DateOfRegistration",
                        "2018-07-27T16:11:00Z"});
            table3.AddRow(new string[] {
                        "Title",
                        "1"});
            table3.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table3.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table3.AddRow(new string[] {
                        "DateofBirth",
                        "2005-07-26T13:45:00Z"});
            table3.AddRow(new string[] {
                        "Gender",
                        "1"});
            table3.AddRow(new string[] {
                        "UniqueLearnerNumber",
                        "9876543210"});
            table3.AddRow(new string[] {
                        "OptInUserResearch",
                        "true"});
            table3.AddRow(new string[] {
                        "OptInMarketResearch",
                        "false"});
            table3.AddRow(new string[] {
                        "DateOfTermination",
                        "2018-07-27T14:45:00Z"});
            table3.AddRow(new string[] {
                        "ReasonForTermination",
                        "1"});
            table3.AddRow(new string[] {
                        "IntroducedBy",
                        "1"});
            table3.AddRow(new string[] {
                        "IntroducedByAdditionalInfo",
                        "additional info"});
            table3.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-21T14:45:00Z"});
#line 46
  testRunner.Given("I post a Customer with the following details:", ((string)(null)), table3, "Given ");
#line 62
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
     testRunner.And("the \"customers\" cosmos document should include CreatedBy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
  testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "DateOfRegistration",
                        "2018-07-27T16:11:00Z"});
            table4.AddRow(new string[] {
                        "Title",
                        "1"});
            table4.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table4.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table4.AddRow(new string[] {
                        "DateofBirth",
                        "2005-07-26T13:45:00Z"});
            table4.AddRow(new string[] {
                        "Gender",
                        "1"});
            table4.AddRow(new string[] {
                        "UniqueLearnerNumber",
                        "9876543210"});
            table4.AddRow(new string[] {
                        "OptInUserResearch",
                        "true"});
            table4.AddRow(new string[] {
                        "OptInMarketResearch",
                        "false"});
            table4.AddRow(new string[] {
                        "DateOfTermination",
                        "2018-07-27T14:45:00Z"});
            table4.AddRow(new string[] {
                        "ReasonForTermination",
                        "1"});
            table4.AddRow(new string[] {
                        "IntroducedBy",
                        "1"});
            table4.AddRow(new string[] {
                        "IntroducedByAdditionalInfo",
                        "additional info"});
            table4.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-21T14:45:00Z"});
#line 65
  testRunner.And("the response body should contain:", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Valid Customer with subcontractorId")]
        [NUnit.Framework.CategoryAttribute("customers")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void PostValidCustomerWithSubcontractorId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Valid Customer with subcontractorId", null, new string[] {
                        "customers",
                        "subcontractorId"});
#line 83
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "DateOfRegistration",
                        "2018-07-27T16:11:00Z"});
            table5.AddRow(new string[] {
                        "Title",
                        "1"});
            table5.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table5.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table5.AddRow(new string[] {
                        "DateofBirth",
                        "2005-07-26T13:45:00Z"});
            table5.AddRow(new string[] {
                        "Gender",
                        "1"});
            table5.AddRow(new string[] {
                        "UniqueLearnerNumber",
                        "9876543210"});
            table5.AddRow(new string[] {
                        "OptInUserResearch",
                        "true"});
            table5.AddRow(new string[] {
                        "OptInMarketResearch",
                        "false"});
            table5.AddRow(new string[] {
                        "DateOfTermination",
                        "2018-07-27T14:45:00Z"});
            table5.AddRow(new string[] {
                        "ReasonForTermination",
                        "1"});
            table5.AddRow(new string[] {
                        "IntroducedBy",
                        "1"});
            table5.AddRow(new string[] {
                        "IntroducedByAdditionalInfo",
                        "additional info"});
            table5.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-21T14:45:00Z"});
#line 84
  testRunner.Given("I post a Customer with the following details:", ((string)(null)), table5, "Given ");
#line 100
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
     testRunner.And("the \"customers\" cosmos document should include CreatedBy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
  testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "DateOfRegistration",
                        "2018-07-27T16:11:00Z"});
            table6.AddRow(new string[] {
                        "Title",
                        "1"});
            table6.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table6.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table6.AddRow(new string[] {
                        "DateofBirth",
                        "2005-07-26T13:45:00Z"});
            table6.AddRow(new string[] {
                        "Gender",
                        "1"});
            table6.AddRow(new string[] {
                        "UniqueLearnerNumber",
                        "9876543210"});
            table6.AddRow(new string[] {
                        "OptInUserResearch",
                        "true"});
            table6.AddRow(new string[] {
                        "OptInMarketResearch",
                        "false"});
            table6.AddRow(new string[] {
                        "DateOfTermination",
                        "2018-07-27T14:45:00Z"});
            table6.AddRow(new string[] {
                        "ReasonForTermination",
                        "1"});
            table6.AddRow(new string[] {
                        "IntroducedBy",
                        "1"});
            table6.AddRow(new string[] {
                        "IntroducedByAdditionalInfo",
                        "additional info"});
            table6.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-21T14:45:00Z"});
#line 103
  testRunner.And("the response body should contain:", ((string)(null)), table6, "And ");
#line 119
  testRunner.And("the response body should contain the SubContractorId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Valid Customer with maximum field lengths")]
        [NUnit.Framework.CategoryAttribute("customers")]
        public virtual void PostValidCustomerWithMaximumFieldLengths()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Valid Customer with maximum field lengths", null, new string[] {
                        "customers"});
#line 122
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table7.AddRow(new string[] {
                        "DateOfRegistration",
                        "2018-07-27T16:11:00Z"});
            table7.AddRow(new string[] {
                        "Title",
                        "1"});
            table7.AddRow(new string[] {
                        "GivenName",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table7.AddRow(new string[] {
                        "FamilyName",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table7.AddRow(new string[] {
                        "DateofBirth",
                        "2005-07-26T13:45:00Z"});
            table7.AddRow(new string[] {
                        "Gender",
                        "1"});
            table7.AddRow(new string[] {
                        "UniqueLearnerNumber",
                        "9876543210"});
            table7.AddRow(new string[] {
                        "OptInUserResearch",
                        "true"});
            table7.AddRow(new string[] {
                        "OptInMarketResearch",
                        "false"});
            table7.AddRow(new string[] {
                        "DateOfTermination",
                        "2018-07-27T14:45:00Z"});
            table7.AddRow(new string[] {
                        "ReasonForTermination",
                        "1"});
            table7.AddRow(new string[] {
                        "IntroducedBy",
                        "1"});
            table7.AddRow(new string[] {
                        "IntroducedByAdditionalInfo",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table7.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-21T14:45:00Z"});
#line 123
  testRunner.Given("I post a Customer with the following details:", ((string)(null)), table7, "Given ");
#line 139
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table8.AddRow(new string[] {
                        "DateOfRegistration",
                        "2018-07-27T16:11:00Z"});
            table8.AddRow(new string[] {
                        "Title",
                        "1"});
            table8.AddRow(new string[] {
                        "GivenName",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table8.AddRow(new string[] {
                        "FamilyName",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table8.AddRow(new string[] {
                        "DateofBirth",
                        "2005-07-26T13:45:00Z"});
            table8.AddRow(new string[] {
                        "Gender",
                        "1"});
            table8.AddRow(new string[] {
                        "UniqueLearnerNumber",
                        "9876543210"});
            table8.AddRow(new string[] {
                        "OptInUserResearch",
                        "true"});
            table8.AddRow(new string[] {
                        "OptInMarketResearch",
                        "false"});
            table8.AddRow(new string[] {
                        "DateOfTermination",
                        "2018-07-27T14:45:00Z"});
            table8.AddRow(new string[] {
                        "ReasonForTermination",
                        "1"});
            table8.AddRow(new string[] {
                        "IntroducedBy",
                        "1"});
            table8.AddRow(new string[] {
                        "IntroducedByAdditionalInfo",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table8.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-21T14:45:00Z"});
#line 140
  testRunner.And("the response body should contain:", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Customer with only Mandatory fields")]
        [NUnit.Framework.CategoryAttribute("customers")]
        public virtual void PostCustomerWithOnlyMandatoryFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Customer with only Mandatory fields", null, new string[] {
                        "customers"});
#line 158
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table9.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table9.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 159
  testRunner.Given("I post a Customer with the following details:", ((string)(null)), table9, "Given ");
#line 163
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 164
  testRunner.And("the \"customers\" cosmos document should include CreatedBy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
  testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table10.AddRow(new string[] {
                        "Title",
                        "99"});
            table10.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table10.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table10.AddRow(new string[] {
                        "DateofBirth",
                        "null"});
            table10.AddRow(new string[] {
                        "Gender",
                        "99"});
            table10.AddRow(new string[] {
                        "UniqueLearnerNumber",
                        "null"});
            table10.AddRow(new string[] {
                        "OptInUserResearch",
                        "false"});
            table10.AddRow(new string[] {
                        "OptInMarketResearch",
                        "false"});
            table10.AddRow(new string[] {
                        "DateOfTermination",
                        "null"});
            table10.AddRow(new string[] {
                        "ReasonForTermination",
                        "null"});
            table10.AddRow(new string[] {
                        "IntroducedBy",
                        "99"});
            table10.AddRow(new string[] {
                        "IntroducedByAdditionalInfo",
                        "null"});
#line 166
  testRunner.And("the response body should contain:", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change Feed for Post Customer")]
        [NUnit.Framework.CategoryAttribute("customers")]
        public virtual void ChangeFeedForPostCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change Feed for Post Customer", null, new string[] {
                        "customers"});
#line 182
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table11.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table11.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 183
  testRunner.Given("I post a Customer with the following details:", ((string)(null)), table11, "Given ");
#line 187
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 188
     testRunner.And("the \"customers\" cosmos document should include CreatedBy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 189
  testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 190
  testRunner.And("there should be a record in the customers ChangeFeed table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 191
  testRunner.And("there should be a record in the customers-history ChangeFeed table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Invalid DateOfRegistration")]
        [NUnit.Framework.CategoryAttribute("customers")]
        public virtual void PostInvalidDateOfRegistration()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Invalid DateOfRegistration", null, new string[] {
                        "customers"});
#line 194
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table12.AddRow(new string[] {
                        "DateOfRegistration",
                        "2048-07-27T16:11:00Z"});
            table12.AddRow(new string[] {
                        "Title",
                        "13"});
            table12.AddRow(new string[] {
                        "GivenName",
                        "Customer"});
            table12.AddRow(new string[] {
                        "DateofBirth",
                        "2005-07-26T13:45:00Z"});
            table12.AddRow(new string[] {
                        "Gender",
                        "1"});
            table12.AddRow(new string[] {
                        "UniqueLearnerNumber",
                        "9876543210"});
            table12.AddRow(new string[] {
                        "OptInUserResearch",
                        "true"});
            table12.AddRow(new string[] {
                        "OptInMarketResearch",
                        "false"});
            table12.AddRow(new string[] {
                        "DateOfTermination",
                        "2018-07-27T14:45:00Z"});
            table12.AddRow(new string[] {
                        "ReasonForTermination",
                        "1"});
            table12.AddRow(new string[] {
                        "IntroducedBy",
                        "1"});
            table12.AddRow(new string[] {
                        "IntroducedByAdditionalInfo",
                        "additional info"});
#line 195
  testRunner.Given("I post a Customer with the following details:", ((string)(null)), table12, "Given ");
#line 209
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 210
  testRunner.And("the error message should be \"Family Name is a required field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Given names with spaces")]
        [NUnit.Framework.CategoryAttribute("customers")]
        [NUnit.Framework.TestCaseAttribute("Sammy Jo", null)]
        [NUnit.Framework.TestCaseAttribute("Sara-Jane", null)]
        [NUnit.Framework.TestCaseAttribute("Sarah - Jane", null)]
        public virtual void GivenNamesWithSpaces(string givenName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "customers"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Given names with spaces", null, @__tags);
#line 213
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 214
  testRunner.Given(string.Format("I post a customer with the given name \'{0}\'", givenName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 215
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Family names with spaces")]
        [NUnit.Framework.CategoryAttribute("customers")]
        [NUnit.Framework.TestCaseAttribute("Da Silva", null)]
        [NUnit.Framework.TestCaseAttribute("De La Cruz", null)]
        [NUnit.Framework.TestCaseAttribute("Cohen Il", null)]
        [NUnit.Framework.TestCaseAttribute("Smith-Jones", null)]
        [NUnit.Framework.TestCaseAttribute("Smith - Jones", null)]
        public virtual void FamilyNamesWithSpaces(string familyName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "customers"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Family names with spaces", null, @__tags);
#line 226
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 227
  testRunner.Given(string.Format("I post a customer with the given name \'{0}\'", familyName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 228
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

