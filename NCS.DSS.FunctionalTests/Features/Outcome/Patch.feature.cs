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
#line 8
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
#line 9
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
#line 13
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
#line 17
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
#line 23
 testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table4, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch OutcomeType")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void PatchOutcomeType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch OutcomeType", null, new string[] {
                        "outcomes"});
#line 37
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table5.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-20T21:45:00Z"});
            table5.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 38
 testRunner.Given("I post an outcome with the following details:", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "OutcomeType",
                        "2"});
#line 43
  testRunner.When("I patch the following:", ((string)(null)), table6, "When ");
#line 46
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "OutcomeType",
                        "2"});
            table7.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-20T21:45:00Z"});
            table7.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 47
  testRunner.And("the response body should contain:", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch OutcomeClaimedDate")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void PatchOutcomeClaimedDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch OutcomeClaimedDate", null, new string[] {
                        "outcomes"});
#line 54
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table8.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-20T21:45:00Z"});
            table8.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 55
 testRunner.Given("I post an outcome with the following details:", ((string)(null)), table8, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-21T21:45:00Z"});
#line 60
  testRunner.When("I patch the following:", ((string)(null)), table9, "When ");
#line 63
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table10.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-21T21:45:00Z"});
            table10.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 64
  testRunner.And("the response body should contain:", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch OutcomeEffectiveDate")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void PatchOutcomeEffectiveDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch OutcomeEffectiveDate", null, new string[] {
                        "outcomes"});
#line 71
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table11.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-20T21:45:00Z"});
            table11.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 72
 testRunner.Given("I post an outcome with the following details:", ((string)(null)), table11, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T22:45:00Z"});
#line 77
  testRunner.When("I patch the following:", ((string)(null)), table12, "When ");
#line 80
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table13.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-20T21:45:00Z"});
            table13.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T22:45:00Z"});
#line 81
  testRunner.And("the response body should contain:", ((string)(null)), table13, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

