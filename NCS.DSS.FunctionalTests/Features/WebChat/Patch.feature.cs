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
    [NUnit.Framework.DescriptionAttribute("Patch")]
    [NUnit.Framework.CategoryAttribute("postV1")]
    [NUnit.Framework.CategoryAttribute("patchV1")]
    public partial class PatchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Patch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Patch", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV1",
                        "patchV1"});
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
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch DigitalReference")]
        [NUnit.Framework.CategoryAttribute("webchats")]
        public virtual void PatchDigitalReference()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch DigitalReference", null, new string[] {
                        "webchats"});
#line 21
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
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
#line 22
 testRunner.Given("I post a webchat with the following details:", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "DigitalReference",
                        "abc12345"});
#line 31
 testRunner.When("I patch the following:", ((string)(null)), table4, "When ");
#line 34
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "DigitalReference",
                        "abc12345"});
            table5.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table5.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table5.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table5.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table5.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table5.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 35
  testRunner.And("the response body should contain:", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch WebChatStartDateandTime")]
        [NUnit.Framework.CategoryAttribute("webchats")]
        public virtual void PatchWebChatStartDateandTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch WebChatStartDateandTime", null, new string[] {
                        "webchats"});
#line 46
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table6.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table6.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table6.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table6.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table6.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table6.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 47
 testRunner.Given("I post a webchat with the following details:", ((string)(null)), table6, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-21T13:20:00Z"});
#line 56
 testRunner.When("I patch the following:", ((string)(null)), table7, "When ");
#line 59
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table8.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-21T13:20:00Z"});
            table8.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table8.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table8.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table8.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table8.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 60
  testRunner.And("the response body should contain:", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch WebChatEndDateandTime")]
        [NUnit.Framework.CategoryAttribute("webchats")]
        public virtual void PatchWebChatEndDateandTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch WebChatEndDateandTime", null, new string[] {
                        "webchats"});
#line 71
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table9.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table9.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table9.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table9.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table9.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table9.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 72
 testRunner.Given("I post a webchat with the following details:", ((string)(null)), table9, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-21T13:45:00Z"});
#line 81
 testRunner.When("I patch the following:", ((string)(null)), table10, "When ");
#line 84
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table11.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table11.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-21T13:45:00Z"});
            table11.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table11.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table11.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table11.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 85
  testRunner.And("the response body should contain:", ((string)(null)), table11, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch WebChatDuration")]
        [NUnit.Framework.CategoryAttribute("webchats")]
        public virtual void PatchWebChatDuration()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch WebChatDuration", null, new string[] {
                        "webchats"});
#line 96
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table12.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table12.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table12.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table12.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table12.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table12.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 97
 testRunner.Given("I post a webchat with the following details:", ((string)(null)), table12, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:01"});
#line 106
 testRunner.When("I patch the following:", ((string)(null)), table13, "When ");
#line 109
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table14.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table14.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table14.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:01"});
            table14.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table14.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table14.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 110
  testRunner.And("the response body should contain:", ((string)(null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch WebChatNarrative")]
        [NUnit.Framework.CategoryAttribute("webchats")]
        public virtual void PatchWebChatNarrative()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch WebChatNarrative", null, new string[] {
                        "webchats"});
#line 121
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table15.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table15.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table15.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table15.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table15.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table15.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 122
 testRunner.Given("I post a webchat with the following details:", ((string)(null)), table15, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "WebChatNarrative",
                        "updated text"});
#line 131
 testRunner.When("I patch the following:", ((string)(null)), table16, "When ");
#line 134
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table17.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table17.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table17.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table17.AddRow(new string[] {
                        "WebChatNarrative",
                        "updated text"});
            table17.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table17.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 135
  testRunner.And("the response body should contain:", ((string)(null)), table17, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch SentToCustomer")]
        [NUnit.Framework.CategoryAttribute("webchats")]
        public virtual void PatchSentToCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch SentToCustomer", null, new string[] {
                        "webchats"});
#line 146
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table18.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table18.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table18.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table18.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table18.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table18.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 147
 testRunner.Given("I post a webchat with the following details:", ((string)(null)), table18, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "SentToCustomer",
                        "false"});
#line 156
 testRunner.When("I patch the following:", ((string)(null)), table19, "When ");
#line 159
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table20.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table20.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table20.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table20.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table20.AddRow(new string[] {
                        "SentToCustomer",
                        "false"});
            table20.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 160
  testRunner.And("the response body should contain:", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch DateandTimeSentToCustomers")]
        [NUnit.Framework.CategoryAttribute("webchats")]
        public virtual void PatchDateandTimeSentToCustomers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch DateandTimeSentToCustomers", null, new string[] {
                        "webchats"});
#line 171
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table21.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table21.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table21.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table21.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table21.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table21.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-20T13:45:00Z"});
#line 172
 testRunner.Given("I post a webchat with the following details:", ((string)(null)), table21, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-21T13:45:00Z"});
#line 181
 testRunner.When("I patch the following:", ((string)(null)), table22, "When ");
#line 184
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table23.AddRow(new string[] {
                        "DigitalReference",
                        "abc1234"});
            table23.AddRow(new string[] {
                        "WebChatStartDateandTime",
                        "2018-07-20T13:20:00Z"});
            table23.AddRow(new string[] {
                        "WebChatEndDateandTime",
                        "2018-07-20T13:45:00Z"});
            table23.AddRow(new string[] {
                        "WebChatDuration",
                        "00:25:00"});
            table23.AddRow(new string[] {
                        "WebChatNarrative",
                        "some text here"});
            table23.AddRow(new string[] {
                        "SentToCustomer",
                        "true"});
            table23.AddRow(new string[] {
                        "DateandTimeSentToCustomers",
                        "2018-07-21T13:45:00Z"});
#line 185
  testRunner.And("the response body should contain:", ((string)(null)), table23, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

