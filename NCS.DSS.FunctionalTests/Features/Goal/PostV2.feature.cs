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
namespace NCS.DSS.FunctionalTests.Features.Goal
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PostV2")]
    [NUnit.Framework.CategoryAttribute("postV2")]
    public partial class PostV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PostV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PostV2", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV2"});
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
#line 7
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
#line 8
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
#line 12
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
#line 16
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
#line 22
 testRunner.And("I post a session with the following details:", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
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
#line 26
 testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table5, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Goal for existing customer with all valid values")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void CreateAGoalForExistingCustomerWithAllValidValues()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Goal for existing customer with all valid values", null, new string[] {
                        "goals"});
#line 40
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "DateGoalCaptured",
                        "2018-06-21T14:45:00Z"});
            table6.AddRow(new string[] {
                        "DateGoalShouldBeCompletedBy",
                        "2018-06-21T14:45:00Z"});
            table6.AddRow(new string[] {
                        "GoalSummary",
                        "some goal text"});
            table6.AddRow(new string[] {
                        "GoalType",
                        "1"});
            table6.AddRow(new string[] {
                        "GoalStatus",
                        "1"});
#line 41
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table6, "Given ");
#line 48
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "DateGoalCaptured",
                        "2018-06-21T14:45:00Z"});
            table7.AddRow(new string[] {
                        "DateGoalShouldBeCompletedBy",
                        "2018-06-21T14:45:00Z"});
            table7.AddRow(new string[] {
                        "GoalSummary",
                        "some goal text"});
            table7.AddRow(new string[] {
                        "GoalType",
                        "1"});
            table7.AddRow(new string[] {
                        "GoalStatus",
                        "1"});
#line 49
  testRunner.And("the response body should contain:", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Valid Goal with all fields")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void PostValidGoalWithAllFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Valid Goal with all fields", null, new string[] {
                        "goals"});
#line 58
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table8.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 59
  testRunner.Given("I post an adviser with the following details:", ((string)(null)), table8, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table9.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 63
  testRunner.And("I post a Customer with the following details:", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table10.AddRow(new string[] {
                        "Channel",
                        "2"});
            table10.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table10.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 67
  testRunner.And("I post an Interaction with the following details:", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table11.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
#line 73
  testRunner.And("I post a session with the following details:", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
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
                        "1"});
            table12.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 77
  testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "DateGoalCaptured",
                        "2018-06-21T14:45:00Z"});
            table13.AddRow(new string[] {
                        "DateGoalShouldBeCompletedBy",
                        "2018-06-21T14:45:00Z"});
            table13.AddRow(new string[] {
                        "GoalSummary",
                        "some goal text"});
            table13.AddRow(new string[] {
                        "GoalType",
                        "1"});
            table13.AddRow(new string[] {
                        "GoalStatus",
                        "1"});
#line 87
  testRunner.Given("I post a goal with the following details:", ((string)(null)), table13, "Given ");
#line 94
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
  testRunner.And("there should be a record in the goals ChangeFeed table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Goal with missing DateGoalCaptured")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void CreateAGoalWithMissingDateGoalCaptured()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Goal with missing DateGoalCaptured", null, new string[] {
                        "goals"});
#line 98
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "DateGoalShouldBeCompletedBy",
                        "2018-06-21T14:45:00Z"});
            table14.AddRow(new string[] {
                        "GoalSummary",
                        "some goal text"});
            table14.AddRow(new string[] {
                        "GoalType",
                        "1"});
            table14.AddRow(new string[] {
                        "GoalStatus",
                        "1"});
#line 99
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table14, "Given ");
#line 105
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Goal with missing DateGoalShouldBeCompletedBy")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void CreateAGoalWithMissingDateGoalShouldBeCompletedBy()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Goal with missing DateGoalShouldBeCompletedBy", null, new string[] {
                        "goals"});
#line 108
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "DateGoalCaptured",
                        "2018-06-21T14:45:00Z"});
            table15.AddRow(new string[] {
                        "GoalSummary",
                        "some goal text"});
            table15.AddRow(new string[] {
                        "GoalType",
                        "1"});
            table15.AddRow(new string[] {
                        "GoalStatus",
                        "1"});
#line 109
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table15, "Given ");
#line 115
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Goal with missing GoalSummary")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void CreateAGoalWithMissingGoalSummary()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Goal with missing GoalSummary", null, new string[] {
                        "goals"});
#line 118
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "DateGoalCaptured",
                        "2018-06-21T14:45:00Z"});
            table16.AddRow(new string[] {
                        "DateGoalShouldBeCompletedBy",
                        "2018-06-21T14:45:00Z"});
            table16.AddRow(new string[] {
                        "GoalType",
                        "1"});
            table16.AddRow(new string[] {
                        "GoalStatus",
                        "1"});
#line 119
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table16, "Given ");
#line 125
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Goal with missing GoalType")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void CreateAGoalWithMissingGoalType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Goal with missing GoalType", null, new string[] {
                        "goals"});
#line 128
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "DateGoalCaptured",
                        "2018-06-21T14:45:00Z"});
            table17.AddRow(new string[] {
                        "DateGoalShouldBeCompletedBy",
                        "2018-06-21T14:45:00Z"});
            table17.AddRow(new string[] {
                        "GoalSummary",
                        "some goal text"});
            table17.AddRow(new string[] {
                        "GoalStatus",
                        "1"});
#line 129
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table17, "Given ");
#line 135
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Goal with invalid GoalType")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void CreateAGoalWithInvalidGoalType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Goal with invalid GoalType", null, new string[] {
                        "goals"});
#line 138
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "DateGoalCaptured",
                        "2018-06-21T14:45:00Z"});
            table18.AddRow(new string[] {
                        "DateGoalShouldBeCompletedBy",
                        "2018-06-21T14:45:00Z"});
            table18.AddRow(new string[] {
                        "GoalSummary",
                        "some goal text"});
            table18.AddRow(new string[] {
                        "GoalType",
                        "11"});
            table18.AddRow(new string[] {
                        "GoalStatus",
                        "1"});
#line 139
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table18, "Given ");
#line 146
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Goal with invalid GoalStatus")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void CreateAGoalWithInvalidGoalStatus()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Goal with invalid GoalStatus", null, new string[] {
                        "goals"});
#line 149
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table19.AddRow(new string[] {
                        "DateGoalCaptured",
                        "2018-06-21T14:45:00Z"});
            table19.AddRow(new string[] {
                        "DateGoalShouldBeCompletedBy",
                        "2018-06-21T14:45:00Z"});
            table19.AddRow(new string[] {
                        "GoalSummary",
                        "some goal text"});
            table19.AddRow(new string[] {
                        "GoalType",
                        "1"});
            table19.AddRow(new string[] {
                        "GoalStatus",
                        "11"});
#line 150
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table19, "Given ");
#line 157
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Goal with missing GoalStatus")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void CreateAGoalWithMissingGoalStatus()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Goal with missing GoalStatus", null, new string[] {
                        "goals"});
#line 160
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table20.AddRow(new string[] {
                        "DateGoalCaptured",
                        "2018-06-21T14:45:00Z"});
            table20.AddRow(new string[] {
                        "DateGoalShouldBeCompletedBy",
                        "2018-06-21T14:45:00Z"});
            table20.AddRow(new string[] {
                        "GoalSummary",
                        "some goal text"});
            table20.AddRow(new string[] {
                        "GoalType",
                        "1"});
#line 161
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table20, "Given ");
#line 167
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "DateGoalCaptured",
                        "2018-06-21T14:45:00Z"});
            table21.AddRow(new string[] {
                        "DateGoalShouldBeCompletedBy",
                        "2018-06-21T14:45:00Z"});
            table21.AddRow(new string[] {
                        "GoalSummary",
                        "some goal text"});
            table21.AddRow(new string[] {
                        "GoalType",
                        "1"});
            table21.AddRow(new string[] {
                        "GoalStatus",
                        "1"});
#line 168
  testRunner.And("the response body should contain:", ((string)(null)), table21, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
