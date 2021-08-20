﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.6.0.0
//      SpecFlow Generator Version:3.6.0.0
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
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Get V3 Outcome")]
    public partial class GetV3OutcomeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GetV3.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Outcome", "Get V3 Outcome", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void TestTearDown()
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
#line 3
#line hidden
            TechTalk.SpecFlow.Table table602 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table602.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table602.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details V2:", ((string)(null)), table602, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table603 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table603.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table603.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table603.AddRow(new string[] {
                        "PriorityGroups",
                        "1,3"});
#line 8
 testRunner.And("I post a Customer with the following details V3:", ((string)(null)), table603, "And ");
#line hidden
            TechTalk.SpecFlow.Table table604 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table604.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table604.AddRow(new string[] {
                        "Channel",
                        "2"});
            table604.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table604.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 13
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table604, "And ");
#line hidden
            TechTalk.SpecFlow.Table table605 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table605.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table605.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
#line 19
 testRunner.And("I post a session with the following details V2:", ((string)(null)), table605, "And ");
#line hidden
            TechTalk.SpecFlow.Table table606 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table606.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table606.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table606.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table606.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table606.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table606.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table606.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table606.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 23
 testRunner.And("I post an ActionPlan with the following details V3:", ((string)(null)), table606, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create an outcome with all valid values and Get V3")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void CreateAnOutcomeWithAllValidValuesAndGetV3()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes",
                    "subcontractorId"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an outcome with all valid values and Get V3", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table607 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table607.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
                table607.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table607.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table607.AddRow(new string[] {
                            "IsPriorityCustomer",
                            "true"});
#line 36
 testRunner.Given("I post an outcome with the following details V3:", ((string)(null)), table607, "Given ");
#line hidden
#line 42
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table608 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table608.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
                table608.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table608.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table608.AddRow(new string[] {
                            "IsPriorityCustomer",
                            "true"});
#line 44
 testRunner.And("the response body should contain:", ((string)(null)), table608, "And ");
#line hidden
#line 51
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.When("I get an Outcome by ID V3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table609 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table609.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
                table609.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table609.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table609.AddRow(new string[] {
                            "IsPriorityCustomer",
                            "true"});
#line 54
 testRunner.And("the response body should contain:", ((string)(null)), table609, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
