﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.6.0.0
//      SpecFlow Generator Version:3.6.0.0
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
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CustomerGetV2")]
    public partial class CustomerGetV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GetV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Customer", "CustomerGetV2", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void TestTearDown()
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
            string[] tagsOfScenario = new string[] {
                    "customers",
                    "smoke",
                    "subcontractorId"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Customer by ID", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table258 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table258.AddRow(new string[] {
                            "DateOfRegistration",
                            "2018-07-27T16:11:00Z"});
                table258.AddRow(new string[] {
                            "Title",
                            "1"});
                table258.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table258.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
                table258.AddRow(new string[] {
                            "DateofBirth",
                            "2005-07-26T13:45:00Z"});
                table258.AddRow(new string[] {
                            "Gender",
                            "1"});
                table258.AddRow(new string[] {
                            "UniqueLearnerNumber",
                            "9876543210"});
                table258.AddRow(new string[] {
                            "OptInUserResearch",
                            "true"});
                table258.AddRow(new string[] {
                            "OptInMarketResearch",
                            "false"});
                table258.AddRow(new string[] {
                            "DateOfTermination",
                            "2018-07-27T14:45:00Z"});
                table258.AddRow(new string[] {
                            "ReasonForTermination",
                            "1"});
                table258.AddRow(new string[] {
                            "IntroducedBy",
                            "1"});
                table258.AddRow(new string[] {
                            "IntroducedByAdditionalInfo",
                            "additional info"});
                table258.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-06-21T14:45:00Z"});
#line 5
 testRunner.Given("I post a Customer with the following details V2:", ((string)(null)), table258, "Given ");
#line hidden
#line 21
 testRunner.When("I get a Customer by ID V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table259 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table259.AddRow(new string[] {
                            "DateOfRegistration",
                            "2018-07-27T16:11:00Z"});
                table259.AddRow(new string[] {
                            "Title",
                            "1"});
                table259.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table259.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
                table259.AddRow(new string[] {
                            "DateofBirth",
                            "2005-07-26T13:45:00Z"});
                table259.AddRow(new string[] {
                            "Gender",
                            "1"});
                table259.AddRow(new string[] {
                            "UniqueLearnerNumber",
                            "9876543210"});
                table259.AddRow(new string[] {
                            "OptInUserResearch",
                            "true"});
                table259.AddRow(new string[] {
                            "OptInMarketResearch",
                            "false"});
                table259.AddRow(new string[] {
                            "DateOfTermination",
                            "2018-07-27T14:45:00Z"});
                table259.AddRow(new string[] {
                            "ReasonForTermination",
                            "1"});
                table259.AddRow(new string[] {
                            "IntroducedBy",
                            "1"});
                table259.AddRow(new string[] {
                            "IntroducedByAdditionalInfo",
                            "additional info"});
                table259.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-06-21T14:45:00Z"});
#line 23
 testRunner.And("the response body should contain:", ((string)(null)), table259, "And ");
#line hidden
#line 39
 testRunner.And("the response body should contain the SubContractorId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
