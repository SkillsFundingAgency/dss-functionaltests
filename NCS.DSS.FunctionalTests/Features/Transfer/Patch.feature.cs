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
    [NUnit.Framework.DescriptionAttribute("TransferPatch")]
    public partial class TransferPatchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Patch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Transfer", "TransferPatch", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table1274 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1274.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table1274.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 4
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table1274, "Given ");
#line hidden
#line 8
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1275 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1275.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table1275.AddRow(new string[] {
                        "Channel",
                        "2"});
            table1275.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table1275.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 9
 testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table1275, "Given ");
#line hidden
#line 15
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1276 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1276.AddRow(new string[] {
                        "OriginatingTouchpointId",
                        "9000000001"});
            table1276.AddRow(new string[] {
                        "TargetTouchpointId",
                        "9111111111"});
            table1276.AddRow(new string[] {
                        "Context",
                        "Some context text"});
            table1276.AddRow(new string[] {
                        "DateandTimeOfTransfer",
                        "2018-06-22T16:52:10Z"});
            table1276.AddRow(new string[] {
                        "RequestedCallbackTime",
                        "2018-06-22T16:52:10Z"});
#line 16
 testRunner.Given("I post a Transfer with the following details:", ((string)(null)), table1276, "Given ");
#line hidden
#line 23
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Minimum")]
        [NUnit.Framework.CategoryAttribute("transfers")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchMinimum()
        {
            string[] tagsOfScenario = new string[] {
                    "transfers",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Minimum", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 26
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
                TechTalk.SpecFlow.Table table1277 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1277.AddRow(new string[] {
                            "TargetTouchpointId",
                            "9000000001"});
                table1277.AddRow(new string[] {
                            "Context",
                            "Some context min"});
#line 27
 testRunner.Given("I patch a Transfer with the following details:", ((string)(null)), table1277, "Given ");
#line hidden
#line 31
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1278 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1278.AddRow(new string[] {
                            "OriginatingTouchpointId",
                            "9000000001"});
                table1278.AddRow(new string[] {
                            "Context",
                            "Some context min"});
#line 32
 testRunner.And("the response body should contain:", ((string)(null)), table1278, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch All")]
        [NUnit.Framework.CategoryAttribute("transfers")]
        public virtual void PatchAll()
        {
            string[] tagsOfScenario = new string[] {
                    "transfers"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch All", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 38
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
                TechTalk.SpecFlow.Table table1279 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1279.AddRow(new string[] {
                            "OriginatingTouchpointId",
                            "9000000001"});
                table1279.AddRow(new string[] {
                            "TargetTouchpointId",
                            "9222222222"});
                table1279.AddRow(new string[] {
                            "Context",
                            "Some context min"});
                table1279.AddRow(new string[] {
                            "DateandTimeOfTransfer",
                            "2018-06-25T11:21:00Z"});
                table1279.AddRow(new string[] {
                            "DateandTimeofTransferAccepted",
                            "2018-06-25T11:21:00Z"});
                table1279.AddRow(new string[] {
                            "RequestedCallbackTime",
                            "2018-06-25T11:21:00Z"});
                table1279.AddRow(new string[] {
                            "ActualCallbackTime",
                            "2018-06-25T11:21:00Z"});
                table1279.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-06-25T11:21:00Z"});
                table1279.AddRow(new string[] {
                            "LastModifiedTouchpointId",
                            "9000000001"});
#line 39
 testRunner.Given("I patch a Transfer with the following details:", ((string)(null)), table1279, "Given ");
#line hidden
#line 50
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1280 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1280.AddRow(new string[] {
                            "OriginatingTouchpointId",
                            "9000000001"});
                table1280.AddRow(new string[] {
                            "TargetTouchpointId",
                            "9222222222"});
                table1280.AddRow(new string[] {
                            "Context",
                            "Some context min"});
                table1280.AddRow(new string[] {
                            "DateandTimeOfTransfer",
                            "2018-06-25T11:21:00Z"});
                table1280.AddRow(new string[] {
                            "DateandTimeofTransferAccepted",
                            "2018-06-25T11:21:00Z"});
                table1280.AddRow(new string[] {
                            "RequestedCallbackTime",
                            "2018-06-25T11:21:00Z"});
                table1280.AddRow(new string[] {
                            "ActualCallbackTime",
                            "2018-06-25T11:21:00Z"});
                table1280.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-06-25T11:21:00Z"});
                table1280.AddRow(new string[] {
                            "LastModifiedTouchpointId",
                            "9000000001"});
#line 51
 testRunner.And("the response body should contain:", ((string)(null)), table1280, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
