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
namespace NCS.DSS.FunctionalTests.Features.ActionPlan
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Patch")]
    public partial class PatchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Patch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Patch", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        "AdviserName",
                        "BillyAdviser"});
            table1.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 6
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
#line 10
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
#line 14
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table3, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch CustomerCharterShownToCustomer")]
        public virtual void PatchCustomerCharterShownToCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch CustomerCharterShownToCustomer", null, ((string[])(null)));
#line 29
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
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
#line 30
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "false"});
#line 40
  testRunner.When("I patch the ActionPlan:", ((string)(null)), table5, "When ");
#line 43
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table6.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "false"});
            table6.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table6.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table6.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table6.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table6.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table6.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 44
  testRunner.And("the response body should contain:", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch ActionPlanDeliveryMethod")]
        public virtual void PatchActionPlanDeliveryMethod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch ActionPlanDeliveryMethod", null, ((string[])(null)));
#line 56
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table7.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table7.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table7.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table7.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table7.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table7.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table7.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 57
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "2"});
#line 67
  testRunner.When("I patch the ActionPlan:", ((string)(null)), table8, "When ");
#line 70
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table9.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table9.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table9.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table9.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "2"});
            table9.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table9.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table9.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 71
  testRunner.And("the response body should contain:", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch PriorityCustomer")]
        public virtual void PatchPriorityCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch PriorityCustomer", null, ((string[])(null)));
#line 83
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table10.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table10.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table10.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table10.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table10.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table10.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table10.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 84
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "PriorityCustomer",
                        "2"});
#line 94
  testRunner.When("I patch the ActionPlan:", ((string)(null)), table11, "When ");
#line 97
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table12.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table12.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table12.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table12.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table12.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table12.AddRow(new string[] {
                        "PriorityCustomer",
                        "2"});
            table12.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 98
  testRunner.And("the response body should contain:", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch CurrentSituation")]
        public virtual void PatchCurrentSituation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch CurrentSituation", null, ((string[])(null)));
#line 110
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table13.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table13.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table13.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table13.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table13.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table13.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table13.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 111
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table13, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "CurrentSituation",
                        "updated text here"});
#line 121
  testRunner.When("I patch the ActionPlan:", ((string)(null)), table14, "When ");
#line 124
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table15.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table15.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table15.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table15.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table15.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table15.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table15.AddRow(new string[] {
                        "CurrentSituation",
                        "updated text here"});
#line 125
  testRunner.And("the response body should contain:", ((string)(null)), table15, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
