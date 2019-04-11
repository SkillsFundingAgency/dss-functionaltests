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
    [NUnit.Framework.DescriptionAttribute("GetV2")]
    [NUnit.Framework.CategoryAttribute("postV2")]
    [NUnit.Framework.CategoryAttribute("getV2")]
    public partial class GetV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GetV2", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV2",
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
#line 6
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
#line 7
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
#line 11
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
#line 15
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
#line 21
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
#line 25
 testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "DateActionAgreed",
                        "2018-07-30T09:00:00Z"});
            table6.AddRow(new string[] {
                        "DateActionAimsToBeCompletedBy",
                        "2018-08-08T09:00:00Z"});
            table6.AddRow(new string[] {
                        "ActionSummary",
                        "A Summary"});
            table6.AddRow(new string[] {
                        "SignpostedTo",
                        "Some Details"});
            table6.AddRow(new string[] {
                        "ActionType",
                        "1"});
            table6.AddRow(new string[] {
                        "ActionStatus",
                        "1"});
            table6.AddRow(new string[] {
                        "PersonResponsible",
                        "1"});
            table6.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-07-30T09:00:00Z"});
#line 35
 testRunner.And("I post an Action with the following details:", ((string)(null)), table6, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Action by ID")]
        [NUnit.Framework.CategoryAttribute("Action")]
        public virtual void GetActionByID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Action by ID", null, new string[] {
                        "Action"});
#line 47
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
 this.FeatureBackground();
#line 48
 testRunner.When("I get an Action by ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
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
                        "2018-08-08T09:00:00Z"});
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
            table7.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-07-30T09:00:00Z"});
#line 50
 testRunner.And("the response body should contain:", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

