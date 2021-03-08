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
namespace NCS.DSS.FunctionalTests.Features.Transfer
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Get")]
    public partial class GetFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Get.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Transfer", "Get", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table1283 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1283.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table1283.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 4
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table1283, "Given ");
#line hidden
#line 8
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1284 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1284.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table1284.AddRow(new string[] {
                        "Channel",
                        "2"});
            table1284.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table1284.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 9
 testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table1284, "Given ");
#line hidden
#line 15
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1285 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1285.AddRow(new string[] {
                        "OriginatingTouchpointId",
                        "9000000001"});
            table1285.AddRow(new string[] {
                        "TargetTouchpointId",
                        "9111111111"});
            table1285.AddRow(new string[] {
                        "Context",
                        "Some context text"});
            table1285.AddRow(new string[] {
                        "DateandTimeOfTransfer",
                        "2018-06-22T16:52:10Z"});
            table1285.AddRow(new string[] {
                        "RequestedCallbackTime",
                        "2018-06-22T16:52:10Z"});
#line 16
 testRunner.Given("I post a Transfer with the following details:", ((string)(null)), table1285, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get a Transfer by ID")]
        [NUnit.Framework.CategoryAttribute("webchats")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void GetATransferByID()
        {
            string[] tagsOfScenario = new string[] {
                    "webchats",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get a Transfer by ID", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 25
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
#line 26
 testRunner.When("I get a Transfer by ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1286 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1286.AddRow(new string[] {
                            "OriginatingTouchpointId",
                            "9000000001"});
                table1286.AddRow(new string[] {
                            "TargetTouchpointId",
                            "9111111111"});
                table1286.AddRow(new string[] {
                            "Context",
                            "Some context text"});
                table1286.AddRow(new string[] {
                            "DateandTimeOfTransfer",
                            "2018-06-22T16:52:10Z"});
                table1286.AddRow(new string[] {
                            "RequestedCallbackTime",
                            "2018-06-22T16:52:10Z"});
#line 28
 testRunner.And("the response body should contain:", ((string)(null)), table1286, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
