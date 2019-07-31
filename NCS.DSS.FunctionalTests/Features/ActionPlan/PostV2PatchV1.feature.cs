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
    [NUnit.Framework.DescriptionAttribute("PostV2PatchV1")]
    [NUnit.Framework.CategoryAttribute("postV2")]
    [NUnit.Framework.CategoryAttribute("patchV1")]
    public partial class PostV2PatchV1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PostV2PatchV1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PostV2PatchV1", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV2",
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
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table2, "Given ");
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
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table4.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
#line 23
 testRunner.And("I post a session with the following details:", ((string)(null)), table4, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Valid CustomerCharterShownToCustomer")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchValidCustomerCharterShownToCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Valid CustomerCharterShownToCustomer", null, new string[] {
                        "actionplans",
                        "smoke"});
#line 31
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table5.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "false"});
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
#line 32
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table6.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-31T09:00:00Z"});
#line 41
  testRunner.When("I patch the following:", ((string)(null)), table6, "When ");
#line 45
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                        "DateActionPlanSentToCustomer",
                        "2018-07-31T09:00:00Z"});
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
#line 46
  testRunner.And("the response body should contain:", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Valid DateAndTimeCharterShown")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PatchValidDateAndTimeCharterShown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Valid DateAndTimeCharterShown", null, new string[] {
                        "actionplans"});
#line 57
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table8.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table8.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table8.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table8.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table8.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table8.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 58
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table8, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
#line 67
  testRunner.When("I patch the following:", ((string)(null)), table9, "When ");
#line 70
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 71
  testRunner.And("the response body should contain:", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Valid DateActionPlanCreated")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PatchValidDateActionPlanCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Valid DateActionPlanCreated", null, new string[] {
                        "actionplans"});
#line 83
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-29T09:00:00Z"});
            table11.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table11.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table11.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table11.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table11.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table11.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table11.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 84
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table11, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
#line 94
  testRunner.When("I patch the following:", ((string)(null)), table12, "When ");
#line 97
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 98
  testRunner.And("the response body should contain:", ((string)(null)), table13, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Valid DateActionPlanSentToCustomer")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PatchValidDateActionPlanSentToCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Valid DateActionPlanSentToCustomer", null, new string[] {
                        "actionplans"});
#line 110
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table14.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table14.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table14.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table14.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table14.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table14.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table14.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 111
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table14, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-31T09:00:00Z"});
#line 121
  testRunner.When("I patch the following:", ((string)(null)), table15, "When ");
#line 124
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table16.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table16.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table16.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-31T09:00:00Z"});
            table16.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table16.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table16.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table16.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 125
  testRunner.And("the response body should contain:", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Valid DateActionPlanAcknowledged")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PatchValidDateActionPlanAcknowledged()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Valid DateActionPlanAcknowledged", null, new string[] {
                        "actionplans"});
#line 137
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table17.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table17.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table17.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table17.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table17.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table17.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table17.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 138
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table17, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-31T09:00:00Z"});
#line 148
  testRunner.When("I patch the following:", ((string)(null)), table18, "When ");
#line 151
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table19.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table19.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table19.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table19.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table19.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-31T09:00:00Z"});
            table19.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table19.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 152
  testRunner.And("the response body should contain:", ((string)(null)), table19, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Valid ActionPlanDeliveryMethod")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PatchValidActionPlanDeliveryMethod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Valid ActionPlanDeliveryMethod", null, new string[] {
                        "actionplans"});
#line 164
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table20.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table20.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table20.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table20.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table20.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table20.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table20.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 165
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table20, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
#line 175
  testRunner.When("I patch the following:", ((string)(null)), table21, "When ");
#line 178
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table22.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table22.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table22.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table22.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table22.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table22.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table22.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 179
  testRunner.And("the response body should contain:", ((string)(null)), table22, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Valid PriorityCustomer")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PatchValidPriorityCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Valid PriorityCustomer", null, new string[] {
                        "actionplans"});
#line 191
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table23.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table23.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table23.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table23.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table23.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table23.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table23.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table23.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 192
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table23, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "PriorityCustomer",
                        "2"});
#line 202
  testRunner.When("I patch the following:", ((string)(null)), table24, "When ");
#line 205
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table25.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table25.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table25.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table25.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table25.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table25.AddRow(new string[] {
                        "PriorityCustomer",
                        "2"});
            table25.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 206
  testRunner.And("the response body should contain:", ((string)(null)), table25, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Valid CurrentSituation")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PatchValidCurrentSituation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Valid CurrentSituation", null, new string[] {
                        "actionplans"});
#line 218
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table26.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table26.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table26.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table26.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table26.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table26.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table26.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 219
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table26, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "CurrentSituation",
                        "still looking"});
#line 229
  testRunner.When("I patch the following:", ((string)(null)), table27, "When ");
#line 232
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table28.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table28.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table28.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table28.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table28.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table28.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table28.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table28.AddRow(new string[] {
                        "CurrentSituation",
                        "still looking"});
#line 233
  testRunner.And("the response body should contain:", ((string)(null)), table28, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

