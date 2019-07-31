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
        [NUnit.Framework.DescriptionAttribute("Post Valid ActionPlan with all fields")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PostValidActionPlanWithAllFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Valid ActionPlan with all fields", null, new string[] {
                        "actionplans",
                        "smoke"});
#line 29
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
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
#line 30
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table5, "Given ");
#line 40
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
     testRunner.And("the \"actionplans\" cosmos document should include CreatedBy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table6.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table6.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
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
#line 42
  testRunner.And("the response body should contain:", ((string)(null)), table6, "And ");
#line 52
  testRunner.And("the response body should contain the SessionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
  testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
  testRunner.And("there should be a record in the ActionPlans ChangeFeed table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
  testRunner.And("there should be a record in the ActionPlans-history ChangeFeed table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Valid ActionPlan with all fields and SubContractorId")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void PostValidActionPlanWithAllFieldsAndSubContractorId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Valid ActionPlan with all fields and SubContractorId", null, new string[] {
                        "actionplans",
                        "subcontractorId"});
#line 59
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
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
#line 60
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table7, "Given ");
#line 70
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
     testRunner.And("the \"actionplans\" cosmos document should include CreatedBy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table8.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table8.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table8.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
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
#line 72
  testRunner.And("the response body should contain:", ((string)(null)), table8, "And ");
#line 82
  testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
  testRunner.And("the response body should contain the SessionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
  testRunner.And("the response body should contain the SubContractorId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Valid ActionPlan with only mandatory fields")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PostValidActionPlanWithOnlyMandatoryFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Valid ActionPlan with only mandatory fields", null, new string[] {
                        "actionplans"});
#line 87
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table9.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table9.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table9.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
#line 88
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table9, "Given ");
#line 93
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table10.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table10.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table10.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "null"});
            table10.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table10.AddRow(new string[] {
                        "CurrentSituation",
                        "null"});
#line 94
  testRunner.And("the response body should contain:", ((string)(null)), table10, "And ");
#line 101
  testRunner.And("the response body should contain the SessionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Valid ActionPlan with only mandatory fields and SubcontractorId")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void PostValidActionPlanWithOnlyMandatoryFieldsAndSubcontractorId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Valid ActionPlan with only mandatory fields and SubcontractorId", null, new string[] {
                        "actionplans",
                        "subcontractorId"});
#line 105
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table11.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table11.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table11.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
#line 106
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table11, "Given ");
#line 111
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                        "ActionPlanDeliveryMethod",
                        "null"});
            table12.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table12.AddRow(new string[] {
                        "CurrentSituation",
                        "null"});
#line 112
  testRunner.And("the response body should contain:", ((string)(null)), table12, "And ");
#line 119
  testRunner.And("the response body should contain the SessionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
  testRunner.And("the response body should contain the SubContractorId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Changed feed for Post ActionPlan")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void ChangedFeedForPostActionPlan()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Changed feed for Post ActionPlan", null, new string[] {
                        "actionplans"});
#line 123
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
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
#line 142
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table13, "Given ");
#line 152
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 153
  testRunner.And("there should be a record in the ActionPlans ChangeFeed table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
  testRunner.And("there should be a record in the ActionPlans-history ChangeFeed table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post ActionPlan with missing DateActionPlanCreated")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PostActionPlanWithMissingDateActionPlanCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post ActionPlan with missing DateActionPlanCreated", null, new string[] {
                        "actionplans"});
#line 157
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
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
#line 158
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table14, "Given ");
#line 167
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post ActionPlan with invalid DateActionPlanCreated")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PostActionPlanWithInvalidDateActionPlanCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post ActionPlan with invalid DateActionPlanCreated", null, new string[] {
                        "actionplans"});
#line 170
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table15.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2058-07-30T09:00:00Z"});
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
                        "looking for work"});
#line 171
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table15, "Given ");
#line 181
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post ActionPlan with DateActionPlanCreated earlier than Session.DateandTimeOfSess" +
            "ion")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PostActionPlanWithDateActionPlanCreatedEarlierThanSession_DateandTimeOfSession()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post ActionPlan with DateActionPlanCreated earlier than Session.DateandTimeOfSess" +
                    "ion", null, new string[] {
                        "actionplans"});
#line 184
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table16.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2017-07-30T09:00:00Z"});
            table16.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table16.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table16.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
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
#line 185
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table16, "Given ");
#line 195
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post ActionPlan with DateAndTimeCharterShown earlier than DateActionPlanCreated")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PostActionPlanWithDateAndTimeCharterShownEarlierThanDateActionPlanCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post ActionPlan with DateAndTimeCharterShown earlier than DateActionPlanCreated", null, new string[] {
                        "actionplans",
                        "ignore"});
#line 198
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table17.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table17.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table17.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-29T09:00:00Z"});
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
#line 199
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table17, "Given ");
#line 209
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post ActionPlan with DateActionPlanSentToCustomer earlier than DateActionPlanCrea" +
            "ted")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PostActionPlanWithDateActionPlanSentToCustomerEarlierThanDateActionPlanCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post ActionPlan with DateActionPlanSentToCustomer earlier than DateActionPlanCrea" +
                    "ted", null, new string[] {
                        "actionplans"});
#line 212
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table18.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table18.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table18.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table18.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-29T09:00:00Z"});
            table18.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table18.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table18.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table18.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 213
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table18, "Given ");
#line 223
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post ActionPlan with DateActionPlanAcknowledged earlier than DateActionPlanCreate" +
            "d")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PostActionPlanWithDateActionPlanAcknowledgedEarlierThanDateActionPlanCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post ActionPlan with DateActionPlanAcknowledged earlier than DateActionPlanCreate" +
                    "d", null, new string[] {
                        "actionplans"});
#line 226
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
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
                        "2018-07-29T09:00:00Z"});
            table19.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table19.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 227
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table19, "Given ");
#line 237
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post ActionPlan with missing CustomerCharterShownToCustomer")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PostActionPlanWithMissingCustomerCharterShownToCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post ActionPlan with missing CustomerCharterShownToCustomer", null, new string[] {
                        "actionplans"});
#line 240
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table20.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
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
#line 241
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table20, "Given ");
#line 250
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post ActionPlan with invalid CustomerCharterShownToCustomer")]
        [NUnit.Framework.CategoryAttribute("actionplans")]
        public virtual void PostActionPlanWithInvalidCustomerCharterShownToCustomer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post ActionPlan with invalid CustomerCharterShownToCustomer", null, new string[] {
                        "actionplans"});
#line 253
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table21.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2058-07-30T09:00:00Z"});
            table21.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "3"});
            table21.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table21.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table21.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table21.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table21.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table21.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 254
  testRunner.Given("I post an ActionPlan with the following details:", ((string)(null)), table21, "Given ");
#line 264
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

