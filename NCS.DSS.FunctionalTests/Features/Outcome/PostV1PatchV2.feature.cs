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
namespace NCS.DSS.FunctionalTests.Features.Outcome
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PostV1PatchV2")]
    [NUnit.Framework.CategoryAttribute("postV1")]
    [NUnit.Framework.CategoryAttribute("patchV2")]
    [NUnit.Framework.CategoryAttribute("getV2")]
    public partial class PostV1PatchV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PostV1PatchV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PostV1PatchV2", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV1",
                        "patchV2",
                        "getV2"});
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
#line 9
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table1.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 10
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table2.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 14
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table3.AddRow(new string[] {
                        "Channel",
                        "2"});
            table3.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table3.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 18
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table4.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table4.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table4.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table4.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table4.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table4.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table4.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table4.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 25
 testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-01-21T14:45:00Z"});
            table5.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
#line 35
 testRunner.And("I post a session with the following details:", ((string)(null)), table5, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid Patch OutcomeClaimedDate with ClaimedPriorityGroup")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        [NUnit.Framework.CategoryAttribute("SessionId")]
        public virtual void ValidPatchOutcomeClaimedDateWithClaimedPriorityGroup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Patch OutcomeClaimedDate with ClaimedPriorityGroup", null, new string[] {
                        "outcomes",
                        "SessionId"});
#line 42
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table6.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-20T21:45:00Z"});
            table6.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 43
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table6, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-20T21:45:00Z"});
            table7.AddRow(new string[] {
                        "ClaimedPriorityGroup",
                        "5"});
#line 48
  testRunner.When("I patch the following:", ((string)(null)), table7, "When ");
#line 52
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch OutcomeClaimedDate without ClaimedPriorityGroup")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void PatchOutcomeClaimedDateWithoutClaimedPriorityGroup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch OutcomeClaimedDate without ClaimedPriorityGroup", null, new string[] {
                        "outcomes"});
#line 55
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table8.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 56
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table8, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-20T21:45:00Z"});
#line 60
  testRunner.When("I patch the following:", ((string)(null)), table9, "When ");
#line 63
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch invalid OutcomeType")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void PatchInvalidOutcomeType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch invalid OutcomeType", null, new string[] {
                        "outcomes"});
#line 66
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table10.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 67
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "OutcomeType",
                        "7"});
#line 71
  testRunner.When("I patch the following:", ((string)(null)), table11, "When ");
#line 74
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Outcome effective date earlier than Session.DateandTimeOfSession")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void PatchOutcomeEffectiveDateEarlierThanSession_DateandTimeOfSession()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Outcome effective date earlier than Session.DateandTimeOfSession", null, new string[] {
                        "outcomes"});
#line 79
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table12.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 80
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table12, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2017-07-20T21:45:00Z"});
#line 84
  testRunner.When("I patch the following:", ((string)(null)), table13, "When ");
#line 87
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Outcome effective date less than Outcome claimed date")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void PatchOutcomeEffectiveDateLessThanOutcomeClaimedDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Outcome effective date less than Outcome claimed date", null, new string[] {
                        "outcomes"});
#line 90
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table14.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 91
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table14, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-19T21:45:00Z"});
            table15.AddRow(new string[] {
                        "ClaimedPriorityGroup",
                        "5"});
#line 95
  testRunner.When("I patch the following:", ((string)(null)), table15, "When ");
#line 99
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Outcome effective date greater than Session.DateandTimeOfSession + 12 month" +
            "s")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void PatchOutcomeEffectiveDateGreaterThanSession_DateandTimeOfSession12Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Outcome effective date greater than Session.DateandTimeOfSession + 12 month" +
                    "s", null, new string[] {
                        "outcomes"});
#line 102
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "OutcomeType",
                        "1"});
            table16.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 103
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table16, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2019-01-22T22:45:00Z"});
#line 107
  testRunner.When("I patch the following:", ((string)(null)), table17, "When ");
#line 110
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Outcome effective date greater than Session.DateandTimeOfSession + 13 month" +
            "s")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void PatchOutcomeEffectiveDateGreaterThanSession_DateandTimeOfSession13Months()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Outcome effective date greater than Session.DateandTimeOfSession + 13 month" +
                    "s", null, new string[] {
                        "outcomes"});
#line 113
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table18.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 114
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table18, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2019-02-22T22:45:00Z"});
#line 118
  testRunner.When("I patch the following:", ((string)(null)), table19, "When ");
#line 121
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

