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
namespace NCS.DSS.FunctionalTests.Features.Session
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GetV2")]
    public partial class GetV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GetV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Session", "GetV2", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
            TechTalk.SpecFlow.Table table1161 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1161.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table1161.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table1161, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1162 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1162.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table1162.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table1162, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1163 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1163.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table1163.AddRow(new string[] {
                        "Channel",
                        "2"});
            table1163.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table1163.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 12
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table1163, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1164 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1164.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table1164.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
#line 18
 testRunner.And("I post a session with the following details:", ((string)(null)), table1164, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Session by ID")]
        [NUnit.Framework.CategoryAttribute("sessions")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void GetSessionByID()
        {
            string[] tagsOfScenario = new string[] {
                    "sessions",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Session by ID", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 24
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
#line 3
this.FeatureBackground();
#line hidden
#line 25
 testRunner.When("I get a Session by ID V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1165 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1165.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table1165.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
#line 27
 testRunner.And("the response body should contain:", ((string)(null)), table1165, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
