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
namespace NCS.DSS.FunctionalTests.Features.Address
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
        [NUnit.Framework.DescriptionAttribute("Get Address by ID")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void GetAddressByID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Address by ID", null, new string[] {
                        "subcontractorId"});
#line 7
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table1.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
  testRunner.Given("I post a Customer with the following details:", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "Address1",
                        "1"});
            table2.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table2.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table2.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table2.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table2.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table2.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table2.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table2.AddRow(new string[] {
                        "Latitude",
                        "52.40121"});
            table2.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table2.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table2.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 12
  testRunner.And("I post an Address with the following details:", ((string)(null)), table2, "And ");
#line 26
  testRunner.When("I get an Address by ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Address1",
                        "1"});
            table3.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table3.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table3.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table3.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table3.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table3.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table3.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table3.AddRow(new string[] {
                        "Latitude",
                        "52.40121"});
            table3.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table3.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table3.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 28
  testRunner.And("the response body should contain:", ((string)(null)), table3, "And ");
#line 42
  testRunner.And("the response body should contain the SubContractorId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

