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
namespace NCS.DSS.FunctionalTests.Features.WebChat
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Get")]
    [NUnit.Framework.CategoryAttribute("postV1")]
    [NUnit.Framework.CategoryAttribute("getV1")]
    public partial class GetFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Get.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Get", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV1",
                        "getV1"});
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
        
        public virtual void FeatureBackground()
        {
#line 5
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
#line 6
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table2.AddRow(new string[] {
                        "Channel",
                        "2"});
            table2.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table2.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 10
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table3.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table3.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table3.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table3.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table3.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table3.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 16
 testRunner.And("I post a webchat with the following details:", ((string)(null)), table3, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get WebChat by ID")]
        [NUnit.Framework.CategoryAttribute("webchats")]
        public virtual void GetWebChatByID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get WebChat by ID", null, new string[] {
                        "webchats"});
#line 27
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 28
 testRunner.When("I get a WebChat by ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table4.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table4.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table4.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table4.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table4.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table4.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 30
 testRunner.And("the response body should contain:", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

