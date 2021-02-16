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
    [NUnit.Framework.DescriptionAttribute("PostTransfer")]
    public partial class PostTransferFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Post.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Transfer", "PostTransfer", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Post Transfer")]
        [NUnit.Framework.CategoryAttribute("transfers")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PostTransfer()
        {
            string[] tagsOfScenario = new string[] {
                    "transfers",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Transfer", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
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
                TechTalk.SpecFlow.Table table1063 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1063.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table1063.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 8
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table1063, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table1064 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1064.AddRow(new string[] {
                            "DateandTimeOfInteraction",
                            "2018-06-25T11:21:00Z"});
                table1064.AddRow(new string[] {
                            "Channel",
                            "2"});
                table1064.AddRow(new string[] {
                            "InteractionType",
                            "2"});
                table1064.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-06-22T16:52:10Z"});
#line 12
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table1064, "And ");
#line hidden
                TechTalk.SpecFlow.Table table1065 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1065.AddRow(new string[] {
                            "OriginatingTouchpointId",
                            "9000000001"});
                table1065.AddRow(new string[] {
                            "TargetTouchpointId",
                            "9111111111"});
                table1065.AddRow(new string[] {
                            "Context",
                            "Some context text"});
                table1065.AddRow(new string[] {
                            "DateandTimeOfTransfer",
                            "2018-06-22T16:52:10Z"});
                table1065.AddRow(new string[] {
                            "RequestedCallbackTime",
                            "2018-06-22T16:52:10Z"});
#line 18
 testRunner.Given("I post a Transfer with the following details:", ((string)(null)), table1065, "Given ");
#line hidden
#line 25
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1066 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1066.AddRow(new string[] {
                            "OriginatingTouchpointId",
                            "9000000001"});
                table1066.AddRow(new string[] {
                            "TargetTouchpointId",
                            "9111111111"});
                table1066.AddRow(new string[] {
                            "Context",
                            "Some context text"});
#line 26
 testRunner.And("the response body should contain:", ((string)(null)), table1066, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
