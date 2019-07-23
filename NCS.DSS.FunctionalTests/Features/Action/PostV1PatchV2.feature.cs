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
namespace NCS.DSS.FunctionalTests.Features.Action
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PostV1PatchV2")]
    [NUnit.Framework.CategoryAttribute("postV1")]
    [NUnit.Framework.CategoryAttribute("patchV2")]
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
#line 23
 testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table4, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch DateActionAimsToBeCompletedBy with SubcontractorId")]
        [NUnit.Framework.CategoryAttribute("actions")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void PatchDateActionAimsToBeCompletedByWithSubcontractorId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch DateActionAimsToBeCompletedBy with SubcontractorId", null, new string[] {
                        "actions",
                        "smoke",
                        "subcontractorId"});
#line 35
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table5.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table5.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table5.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table5.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table5.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table5.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 36
  testRunner.Given("I post an Action with the following details:", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-09-08T09:00:00Z"});
#line 45
  testRunner.When("I patch the following:", ((string)(null)), table6, "When ");
#line 48
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table7.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-09-08T09:00:00Z"});
            table7.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table7.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table7.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table7.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table7.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 49
  testRunner.And("the response body should contain:", ((string)(null)), table7, "And ");
#line 58
  testRunner.And("the response body should contain the SubContractorId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch ActionSummary")]
        [NUnit.Framework.CategoryAttribute("actions")]
        public virtual void PatchActionSummary()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch ActionSummary", null, new string[] {
                        "actions"});
#line 61
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table8.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table8.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table8.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table8.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table8.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table8.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 62
  testRunner.Given("I post an Action with the following details:", ((string)(null)), table8, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "ActionSummary",
                        "A New Summary"});
#line 71
  testRunner.When("I patch the following:", ((string)(null)), table9, "When ");
#line 74
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table10.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table10.AddRow(new string[] {
                        "ActionSummary",
                        "A New Summary"});
            table10.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table10.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table10.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table10.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 75
  testRunner.And("the response body should contain:", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch SignpostedTo")]
        [NUnit.Framework.CategoryAttribute("actions")]
        public virtual void PatchSignpostedTo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch SignpostedTo", null, new string[] {
                        "actions"});
#line 86
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table11.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table11.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table11.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table11.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table11.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table11.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 87
  testRunner.Given("I post an Action with the following details:", ((string)(null)), table11, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "SignpostedTo",
                        "Updated Details"});
#line 96
  testRunner.When("I patch the following:", ((string)(null)), table12, "When ");
#line 99
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table13.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table13.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table13.AddRow(new string[] {
                        "SignpostedTo",
                        "Updated Details"});
            table13.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table13.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table13.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 100
  testRunner.And("the response body should contain:", ((string)(null)), table13, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch ActionType")]
        [NUnit.Framework.CategoryAttribute("actions")]
        public virtual void PatchActionType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch ActionType", null, new string[] {
                        "actions"});
#line 111
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table14.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table14.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table14.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table14.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table14.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table14.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 112
  testRunner.Given("I post an Action with the following details:", ((string)(null)), table14, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "ActionType",
                        "2"});
#line 121
  testRunner.When("I patch the following:", ((string)(null)), table15, "When ");
#line 124
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table16.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table16.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table16.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table16.AddRow(new string[] {
                        "ActionType",
                        "2"});
            table16.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table16.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 125
  testRunner.And("the response body should contain:", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch ActionStatus")]
        [NUnit.Framework.CategoryAttribute("actions")]
        public virtual void PatchActionStatus()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch ActionStatus", null, new string[] {
                        "actions"});
#line 136
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table17.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table17.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table17.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table17.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table17.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table17.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 137
  testRunner.Given("I post an Action with the following details:", ((string)(null)), table17, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "ActionStatus",
                        "2"});
#line 146
  testRunner.When("I patch the following:", ((string)(null)), table18, "When ");
#line 149
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table19.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table19.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table19.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table19.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table19.AddRow(new string[] {
                        "ActionStatus",
                        "2"});
            table19.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 150
  testRunner.And("the response body should contain:", ((string)(null)), table19, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch PersonResponsible")]
        [NUnit.Framework.CategoryAttribute("actions")]
        public virtual void PatchPersonResponsible()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch PersonResponsible", null, new string[] {
                        "actions"});
#line 161
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table20.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table20.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table20.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table20.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table20.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table20.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 162
  testRunner.Given("I post an Action with the following details:", ((string)(null)), table20, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "PersonResponsible",
                        "2"});
#line 171
  testRunner.When("I patch the following:", ((string)(null)), table21, "When ");
#line 174
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table22.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table22.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table22.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table22.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table22.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table22.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table22.AddRow(new string[] {
                        "PersonResponsible",
                        "2"});
#line 175
  testRunner.And("the response body should contain:", ((string)(null)), table22, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch with invalid ActionType")]
        [NUnit.Framework.CategoryAttribute("actions")]
        public virtual void PatchWithInvalidActionType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch with invalid ActionType", null, new string[] {
                        "actions"});
#line 186
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table23.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table23.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table23.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table23.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table23.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table23.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table23.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 187
  testRunner.Given("I post an Action with the following details:", ((string)(null)), table23, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table24.AddRow(new string[] {
                        "ActionType",
                        "33"});
#line 196
  testRunner.When("I patch the following:", ((string)(null)), table24, "When ");
#line 199
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch with invalid ActionStatus")]
        public virtual void PatchWithInvalidActionStatus()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch with invalid ActionStatus", null, ((string[])(null)));
#line 201
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table25.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table25.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table25.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table25.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table25.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table25.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table25.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 202
  testRunner.Given("I post an Action with the following details:", ((string)(null)), table25, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table26.AddRow(new string[] {
                        "ActionStatus",
                        "33"});
#line 211
  testRunner.When("I patch the following:", ((string)(null)), table26, "When ");
#line 214
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch with invalid PersonResponsible")]
        [NUnit.Framework.CategoryAttribute("actions")]
        public virtual void PatchWithInvalidPersonResponsible()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch with invalid PersonResponsible", null, new string[] {
                        "actions"});
#line 217
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table27.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table27.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table27.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table27.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table27.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table27.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table27.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
#line 218
  testRunner.Given("I post an Action with the following details:", ((string)(null)), table27, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table28.AddRow(new string[] {
                        "PersonResponsible",
                        "33"});
#line 227
  testRunner.When("I patch the following:", ((string)(null)), table28, "When ");
#line 230
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

