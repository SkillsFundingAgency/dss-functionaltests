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
            TechTalk.SpecFlow.Table table656 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table656.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table656.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table656.AddRow(new string[] {
                        "PriorityGroups",
                        "1,3"});
#line 4
 testRunner.Given("I post a Customer with the following details V3:", ((string)(null)), table656, "Given ");
#line hidden
#line 9
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table657 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table657.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table657.AddRow(new string[] {
                        "Channel",
                        "2"});
            table657.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table657.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 10
 testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table657, "Given ");
#line hidden
#line 16
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table658 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table658.AddRow(new string[] {
                        "OriginatingTouchpointId",
                        "9000000001"});
            table658.AddRow(new string[] {
                        "TargetTouchpointId",
                        "9111111111"});
            table658.AddRow(new string[] {
                        "Context",
                        "Some context text"});
            table658.AddRow(new string[] {
                        "DateandTimeOfTransfer",
                        "2018-06-22T16:52:10Z"});
            table658.AddRow(new string[] {
                        "RequestedCallbackTime",
                        "2018-06-22T16:52:10Z"});
#line 17
 testRunner.Given("I post a Transfer with the following details:", ((string)(null)), table658, "Given ");
#line hidden
#line 24
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
#line 27
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
                TechTalk.SpecFlow.Table table659 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table659.AddRow(new string[] {
                            "TargetTouchpointId",
                            "9000000001"});
                table659.AddRow(new string[] {
                            "Context",
                            "Some context min"});
#line 28
 testRunner.Given("I patch a Transfer with the following details:", ((string)(null)), table659, "Given ");
#line hidden
#line 32
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table660 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table660.AddRow(new string[] {
                            "OriginatingTouchpointId",
                            "9000000001"});
                table660.AddRow(new string[] {
                            "Context",
                            "Some context min"});
#line 33
 testRunner.And("the response body should contain:", ((string)(null)), table660, "And ");
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
#line 39
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
                TechTalk.SpecFlow.Table table661 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table661.AddRow(new string[] {
                            "OriginatingTouchpointId",
                            "9000000001"});
                table661.AddRow(new string[] {
                            "TargetTouchpointId",
                            "9222222222"});
                table661.AddRow(new string[] {
                            "Context",
                            "Some context min"});
                table661.AddRow(new string[] {
                            "DateandTimeOfTransfer",
                            "2018-06-25T11:21:00Z"});
                table661.AddRow(new string[] {
                            "DateandTimeofTransferAccepted",
                            "2018-06-25T11:21:00Z"});
                table661.AddRow(new string[] {
                            "RequestedCallbackTime",
                            "2018-06-25T11:21:00Z"});
                table661.AddRow(new string[] {
                            "ActualCallbackTime",
                            "2018-06-25T11:21:00Z"});
                table661.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-06-25T11:21:00Z"});
                table661.AddRow(new string[] {
                            "LastModifiedTouchpointId",
                            "9000000001"});
#line 40
 testRunner.Given("I patch a Transfer with the following details:", ((string)(null)), table661, "Given ");
#line hidden
#line 51
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table662 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table662.AddRow(new string[] {
                            "OriginatingTouchpointId",
                            "9000000001"});
                table662.AddRow(new string[] {
                            "TargetTouchpointId",
                            "9222222222"});
                table662.AddRow(new string[] {
                            "Context",
                            "Some context min"});
                table662.AddRow(new string[] {
                            "DateandTimeOfTransfer",
                            "2018-06-25T11:21:00Z"});
                table662.AddRow(new string[] {
                            "DateandTimeofTransferAccepted",
                            "2018-06-25T11:21:00Z"});
                table662.AddRow(new string[] {
                            "RequestedCallbackTime",
                            "2018-06-25T11:21:00Z"});
                table662.AddRow(new string[] {
                            "ActualCallbackTime",
                            "2018-06-25T11:21:00Z"});
                table662.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-06-25T11:21:00Z"});
                table662.AddRow(new string[] {
                            "LastModifiedTouchpointId",
                            "9000000001"});
#line 52
 testRunner.And("the response body should contain:", ((string)(null)), table662, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
