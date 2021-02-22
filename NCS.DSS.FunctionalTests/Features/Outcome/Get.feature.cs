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
    [NUnit.Framework.DescriptionAttribute("Get")]
    public partial class GetFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Get.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Outcome", "Get", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table1036 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1036.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table1036.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table1036, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1037 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1037.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table1037.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table1037, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1038 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1038.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table1038.AddRow(new string[] {
                        "Channel",
                        "2"});
            table1038.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table1038.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 12
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table1038, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1039 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table1039.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table1039.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table1039.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table1039.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table1039.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table1039.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table1039.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table1039.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 18
 testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table1039, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1040 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1040.AddRow(new string[] {
                        "OutcomeType",
                        "3"});
            table1040.AddRow(new string[] {
                        "OutcomeClaimedDate",
                        "2018-07-20T21:45:00Z"});
            table1040.AddRow(new string[] {
                        "OutcomeEffectiveDate",
                        "2018-07-20T21:45:00Z"});
#line 28
 testRunner.And("I post an outcome with the following details:", ((string)(null)), table1040, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Outcome by ID")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void GetOutcomeByID()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Outcome by ID", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 36
 testRunner.When("I get an Outcome by ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1041 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1041.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
                table1041.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table1041.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
#line 38
 testRunner.And("the response body should contain:", ((string)(null)), table1041, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
