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
namespace NCS.DSS.FunctionalTests.Features.Webchat
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Webchat", "Get", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table1298 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1298.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table1298.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 4
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table1298, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1299 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1299.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table1299.AddRow(new string[] {
                        "Channel",
                        "2"});
            table1299.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table1299.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 8
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table1299, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1300 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1300.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table1300.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table1300.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table1300.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table1300.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table1300.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table1300.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 14
 testRunner.And("I post a webchat with the following details:", ((string)(null)), table1300, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get a WebChat by ID")]
        [NUnit.Framework.CategoryAttribute("webchats")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void GetAWebChatByID()
        {
            string[] tagsOfScenario = new string[] {
                    "webchats",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get a WebChat by ID", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.When("I get a WebChat by ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1301 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1301.AddRow(new string[] {
                            "DigitalReference",
                            "abc1234"});
                table1301.AddRow(new string[] {
                            "WebChatStartDateandTime",
                            "2018-07-20T13:20:00Z"});
                table1301.AddRow(new string[] {
                            "WebChatEndDateandTime",
                            "2018-07-20T13:45:00Z"});
                table1301.AddRow(new string[] {
                            "WebChatDuration",
                            "00:25:00"});
                table1301.AddRow(new string[] {
                            "WebChatNarrative",
                            "some text here"});
                table1301.AddRow(new string[] {
                            "SentToCustomer",
                            "true"});
                table1301.AddRow(new string[] {
                            "DateandTimeSentToCustomers",
                            "2018-07-20T13:45:00Z"});
#line 28
 testRunner.And("the response body should contain:", ((string)(null)), table1301, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
