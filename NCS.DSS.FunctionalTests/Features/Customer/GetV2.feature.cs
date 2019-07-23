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
    [NUnit.Framework.DescriptionAttribute("GetV2")]
    [NUnit.Framework.CategoryAttribute("postV2")]
    [NUnit.Framework.CategoryAttribute("getV2")]
    public partial class GetV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GetV2", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV2",
                        "getV2"});
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
        [NUnit.Framework.DescriptionAttribute("Get Customer by ID")]
        [NUnit.Framework.CategoryAttribute("customers")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void GetCustomerByID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Customer by ID", null, new string[] {
                        "customers",
                        "smoke",
                        "subcontractorId"});
#line 7
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "DateOfRegistration",
                        "2018-07-27T16:11:00Z"});
            table1.AddRow(new string[] {
                        "Title",
                        "1"});
            table1.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
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
#line 24
 testRunner.When("I get a Customer by ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "DateOfRegistration",
                        "2018-07-27T16:11:00Z"});
            table2.AddRow(new string[] {
                        "Title",
                        "1"});
            table2.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table2.AddRow(new string[] {
                        "FamilyName",
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
            table2.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-21T14:45:00Z"});
#line 26
 testRunner.And("the response body should contain:", ((string)(null)), table2, "And ");
#line 42
 testRunner.And("the response body should contain the SubContractorId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

