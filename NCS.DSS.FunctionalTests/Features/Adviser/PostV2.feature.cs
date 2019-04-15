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
namespace NCS.DSS.FunctionalTests.Features.Adviser
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
        [NUnit.Framework.DescriptionAttribute("Create Valid Adviser")]
        [NUnit.Framework.CategoryAttribute("adviserdetails")]
        public virtual void CreateValidAdviser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Valid Adviser", null, new string[] {
                        "adviserdetails"});
#line 8
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table1.AddRow(new string[] {
                        "AdviserEmailAddress",
                        "billy@bill.com"});
            table1.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 9
  testRunner.Given("I post an adviser with the following details:", ((string)(null)), table1, "Given ");
#line 14
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table2.AddRow(new string[] {
                        "AdviserEmailAddress",
                        "billy@bill.com"});
            table2.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 15
  testRunner.And("the response body should contain:", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Valid Adviser with SubcontractorId")]
        [NUnit.Framework.CategoryAttribute("adviserdetails")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void CreateValidAdviserWithSubcontractorId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Valid Adviser with SubcontractorId", null, new string[] {
                        "adviserdetails",
                        "subcontractorId"});
#line 22
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table3.AddRow(new string[] {
                        "AdviserEmailAddress",
                        "billy@bill.com"});
            table3.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 23
  testRunner.Given("I post an adviser with the following details:", ((string)(null)), table3, "Given ");
#line 28
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table4.AddRow(new string[] {
                        "AdviserEmailAddress",
                        "billy@bill.com"});
            table4.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 29
  testRunner.And("the response body should contain:", ((string)(null)), table4, "And ");
#line 34
  testRunner.And("the response body should contain the SubContractorId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change feed for Post Adviser")]
        [NUnit.Framework.CategoryAttribute("adviserdetails")]
        public virtual void ChangeFeedForPostAdviser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change feed for Post Adviser", null, new string[] {
                        "adviserdetails"});
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table5.AddRow(new string[] {
                        "AdviserEmailAddress",
                        "billy@bill.com"});
#line 38
  testRunner.Given("I post an adviser with the following details:", ((string)(null)), table5, "Given ");
#line 42
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
  testRunner.And("there should be a record in the adviserDetails ChangeFeed table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Missing AdviserName")]
        [NUnit.Framework.CategoryAttribute("adviserdetails")]
        public virtual void MissingAdviserName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Missing AdviserName", null, new string[] {
                        "adviserdetails"});
#line 46
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "AdviserEmailAddress",
                        "billy@bill.com"});
            table6.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 47
  testRunner.Given("I post an adviser with the following details:", ((string)(null)), table6, "Given ");
#line 51
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

