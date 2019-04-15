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
    [NUnit.Framework.DescriptionAttribute("PatchV2")]
    [NUnit.Framework.CategoryAttribute("postV2")]
    [NUnit.Framework.CategoryAttribute("patchV2")]
    public partial class PatchV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PatchV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PatchV2", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV2",
                        "patchV2"});
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
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-01-21T14:45:00Z"});
            table4.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
#line 24
 testRunner.And("I post a session with the following details:", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table5.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table5.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table5.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table5.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table5.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table5.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table5.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 28
 testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table5, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid Patch OutcomeClaimedDate with ClaimedPriorityGroup")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        [NUnit.Framework.CategoryAttribute("Cat1")]
        public virtual void ValidPatchOutcomeClaimedDateWithClaimedPriorityGroup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Patch OutcomeClaimedDate with ClaimedPriorityGroup", null, new string[] {
                        "outcomes",
                        "Cat1"});
#line 40
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
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 41
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table6, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-08-20T21:45:00Z"});
            table7.AddRow(new string[] {
                        "ClaimedPriorityGroup",
                        "5"});
#line 45
  testRunner.When("I patch the following:", ((string)(null)), table7, "When ");
#line 49
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid Patch remove value for OutcomeClaimedDate")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        [NUnit.Framework.CategoryAttribute("Cat1")]
        public virtual void ValidPatchRemoveValueForOutcomeClaimedDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Patch remove value for OutcomeClaimedDate", null, new string[] {
                        "outcomes",
                        "Cat1"});
#line 52
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
                        "2018-08-20T21:45:00Z"});
            table8.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-08-20T21:45:00Z"});
            table8.AddRow(new string[] {
                        "ClaimedPriorityGroup",
                        "5"});
#line 53
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table8, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        ""});
#line 59
  testRunner.When("I patch the following:", ((string)(null)), table9, "When ");
#line 62
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-08-20T21:45:00Z"});
            table10.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table10.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        ""});
            table10.AddRow(new string[] {
                        "ClaimedPriorityGroup",
                        "5"});
#line 63
  testRunner.And("the response body should contain:", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid Patch remove value for OutcomeClaimedDate and OutcomeEffectiveDate")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void ValidPatchRemoveValueForOutcomeClaimedDateAndOutcomeEffectiveDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Patch remove value for OutcomeClaimedDate and OutcomeEffectiveDate", null, new string[] {
                        "outcomes"});
#line 71
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table11.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-08-20T21:45:00Z"});
            table11.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-08-20T21:45:00Z"});
            table11.AddRow(new string[] {
                        "ClaimedPriorityGroup",
                        "5"});
#line 72
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table11, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        ""});
            table12.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        ""});
#line 78
  testRunner.When("I patch the following:", ((string)(null)), table12, "When ");
#line 82
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        ""});
            table13.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table13.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        ""});
            table13.AddRow(new string[] {
                        "ClaimedPriorityGroup",
                        "5"});
#line 83
  testRunner.And("the response body should contain:", ((string)(null)), table13, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid Patch add values for OutcomeClaimedDate and OutcomeEffectiveDate")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void ValidPatchAddValuesForOutcomeClaimedDateAndOutcomeEffectiveDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Patch add values for OutcomeClaimedDate and OutcomeEffectiveDate", null, new string[] {
                        "outcomes"});
#line 91
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
                        "ClaimedPriorityGroup",
                        "5"});
#line 92
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table14, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-08-20T21:45:00Z"});
            table15.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-08-20T21:46:00Z"});
#line 96
  testRunner.When("I patch the following:", ((string)(null)), table15, "When ");
#line 100
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-08-20T21:45:00Z"});
            table16.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table16.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-08-20T21:46:00Z"});
            table16.AddRow(new string[] {
                        "ClaimedPriorityGroup",
                        "5"});
#line 101
  testRunner.And("the response body should contain:", ((string)(null)), table16, "And ");
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
#line 109
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table17.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 110
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table17, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-20T21:45:00Z"});
#line 114
  testRunner.When("I patch the following:", ((string)(null)), table18, "When ");
#line 117
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
#line 120
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table19.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 121
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table19, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "OutcomeType",
                        "7"});
#line 125
  testRunner.When("I patch the following:", ((string)(null)), table20, "When ");
#line 128
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
#line 133
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table21.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 134
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table21, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2017-07-20T21:45:00Z"});
#line 138
  testRunner.When("I patch the following:", ((string)(null)), table22, "When ");
#line 141
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
#line 144
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table23.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table23.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 145
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table23, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-19T21:45:00Z"});
            table24.AddRow(new string[] {
                        "ClaimedPriorityGroup",
                        "5"});
#line 149
  testRunner.When("I patch the following:", ((string)(null)), table24, "When ");
#line 153
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
#line 156
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "OutcomeType",
                        "1"});
            table25.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 157
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table25, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2019-01-22T22:45:00Z"});
#line 161
  testRunner.When("I patch the following:", ((string)(null)), table26, "When ");
#line 164
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
#line 167
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table27.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 168
  testRunner.Given("I post an outcome with the following details:", ((string)(null)), table27, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table28.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2019-02-22T22:45:00Z"});
#line 172
  testRunner.When("I patch the following:", ((string)(null)), table28, "When ");
#line 175
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

