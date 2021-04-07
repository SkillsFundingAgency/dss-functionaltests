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
namespace NCS.DSS.FunctionalTests.Features.Goal
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Patch")]
    public partial class PatchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Patch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Goal", "Patch", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table781 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table781.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table781.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table781, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table782 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table782.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table782.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table782, "And ");
#line hidden
            TechTalk.SpecFlow.Table table783 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table783.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table783.AddRow(new string[] {
                        "Channel",
                        "2"});
            table783.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table783.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 12
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table783, "And ");
#line hidden
            TechTalk.SpecFlow.Table table784 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table784.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table784.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table784.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table784.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table784.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table784.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table784.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table784.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 18
 testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table784, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch DateGoalCaptured")]
        [NUnit.Framework.CategoryAttribute("goals")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchDateGoalCaptured()
        {
            string[] tagsOfScenario = new string[] {
                    "goals",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch DateGoalCaptured", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 30
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
                TechTalk.SpecFlow.Table table785 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table785.AddRow(new string[] {
                            "DateGoalCaptured",
                            "2018-06-21T14:45:00Z"});
                table785.AddRow(new string[] {
                            "DateGoalShouldBeCompletedBy",
                            "2018-07-21T14:45:00Z"});
                table785.AddRow(new string[] {
                            "GoalSummary",
                            "some goal text"});
                table785.AddRow(new string[] {
                            "GoalType",
                            "1"});
                table785.AddRow(new string[] {
                            "GoalStatus",
                            "1"});
#line 31
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table785, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table786 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table786.AddRow(new string[] {
                            "DateGoalCaptured",
                            "2018-06-22T14:45:00Z"});
#line 38
 testRunner.When("I patch the following Goal:", ((string)(null)), table786, "When ");
#line hidden
#line 41
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table787 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table787.AddRow(new string[] {
                            "DateGoalCaptured",
                            "2018-06-22T14:45:00Z"});
                table787.AddRow(new string[] {
                            "DateGoalShouldBeCompletedBy",
                            "2018-07-21T14:45:00Z"});
                table787.AddRow(new string[] {
                            "GoalSummary",
                            "some goal text"});
                table787.AddRow(new string[] {
                            "GoalType",
                            "1"});
                table787.AddRow(new string[] {
                            "GoalStatus",
                            "1"});
#line 42
 testRunner.And("the response body should contain:", ((string)(null)), table787, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch DateGoalShouldBeCompletedBy")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void PatchDateGoalShouldBeCompletedBy()
        {
            string[] tagsOfScenario = new string[] {
                    "goals"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch DateGoalShouldBeCompletedBy", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 51
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
                TechTalk.SpecFlow.Table table788 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table788.AddRow(new string[] {
                            "DateGoalCaptured",
                            "2018-06-21T14:45:00Z"});
                table788.AddRow(new string[] {
                            "DateGoalShouldBeCompletedBy",
                            "2018-07-21T14:45:00Z"});
                table788.AddRow(new string[] {
                            "GoalSummary",
                            "some goal text"});
                table788.AddRow(new string[] {
                            "GoalType",
                            "1"});
                table788.AddRow(new string[] {
                            "GoalStatus",
                            "1"});
#line 52
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table788, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table789 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table789.AddRow(new string[] {
                            "DateGoalShouldBeCompletedBy",
                            "2018-07-22T14:45:00Z"});
#line 59
 testRunner.When("I patch the following Goal:", ((string)(null)), table789, "When ");
#line hidden
#line 62
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table790 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table790.AddRow(new string[] {
                            "DateGoalCaptured",
                            "2018-06-21T14:45:00Z"});
                table790.AddRow(new string[] {
                            "DateGoalShouldBeCompletedBy",
                            "2018-07-22T14:45:00Z"});
                table790.AddRow(new string[] {
                            "GoalSummary",
                            "some goal text"});
                table790.AddRow(new string[] {
                            "GoalType",
                            "1"});
                table790.AddRow(new string[] {
                            "GoalStatus",
                            "1"});
#line 63
 testRunner.And("the response body should contain:", ((string)(null)), table790, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch DateGoalAchieved")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void PatchDateGoalAchieved()
        {
            string[] tagsOfScenario = new string[] {
                    "goals"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch DateGoalAchieved", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 72
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
                TechTalk.SpecFlow.Table table791 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table791.AddRow(new string[] {
                            "DateGoalCaptured",
                            "2018-06-21T14:45:00Z"});
                table791.AddRow(new string[] {
                            "DateGoalShouldBeCompletedBy",
                            "2018-07-21T14:45:00Z"});
                table791.AddRow(new string[] {
                            "GoalSummary",
                            "some goal text"});
                table791.AddRow(new string[] {
                            "GoalType",
                            "1"});
                table791.AddRow(new string[] {
                            "GoalStatus",
                            "1"});
#line 73
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table791, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table792 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table792.AddRow(new string[] {
                            "DateGoalAchieved",
                            "2018-07-15T14:45:00Z"});
#line 80
 testRunner.When("I patch the following Goal:", ((string)(null)), table792, "When ");
#line hidden
#line 83
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table793 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table793.AddRow(new string[] {
                            "DateGoalCaptured",
                            "2018-06-21T14:45:00Z"});
                table793.AddRow(new string[] {
                            "DateGoalShouldBeCompletedBy",
                            "2018-07-21T14:45:00Z"});
                table793.AddRow(new string[] {
                            "DateGoalAchieved",
                            "2018-07-15T14:45:00Z"});
                table793.AddRow(new string[] {
                            "GoalSummary",
                            "some goal text"});
                table793.AddRow(new string[] {
                            "GoalType",
                            "1"});
                table793.AddRow(new string[] {
                            "GoalStatus",
                            "1"});
#line 84
 testRunner.And("the response body should contain:", ((string)(null)), table793, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch with invalid GoalType")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void PatchWithInvalidGoalType()
        {
            string[] tagsOfScenario = new string[] {
                    "goals"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch with invalid GoalType", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 96
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
                TechTalk.SpecFlow.Table table794 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table794.AddRow(new string[] {
                            "DateGoalCaptured",
                            "2018-06-21T14:45:00Z"});
                table794.AddRow(new string[] {
                            "DateGoalShouldBeCompletedBy",
                            "2018-07-21T14:45:00Z"});
                table794.AddRow(new string[] {
                            "GoalSummary",
                            "some goal text"});
                table794.AddRow(new string[] {
                            "GoalType",
                            "1"});
                table794.AddRow(new string[] {
                            "GoalStatus",
                            "1"});
#line 97
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table794, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table795 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table795.AddRow(new string[] {
                            "GoalType",
                            "4"});
#line 104
 testRunner.When("I patch the following Goal:", ((string)(null)), table795, "When ");
#line hidden
#line 107
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch with invalid GoalStatus")]
        [NUnit.Framework.CategoryAttribute("goals")]
        public virtual void PatchWithInvalidGoalStatus()
        {
            string[] tagsOfScenario = new string[] {
                    "goals"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch with invalid GoalStatus", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 110
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
                TechTalk.SpecFlow.Table table796 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table796.AddRow(new string[] {
                            "DateGoalCaptured",
                            "2018-06-21T14:45:00Z"});
                table796.AddRow(new string[] {
                            "DateGoalShouldBeCompletedBy",
                            "2018-07-21T14:45:00Z"});
                table796.AddRow(new string[] {
                            "GoalSummary",
                            "some goal text"});
                table796.AddRow(new string[] {
                            "GoalType",
                            "1"});
                table796.AddRow(new string[] {
                            "GoalStatus",
                            "1"});
#line 111
 testRunner.Given("I post a goal with the following details:", ((string)(null)), table796, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table797 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table797.AddRow(new string[] {
                            "GoalStatus",
                            "4"});
#line 118
 testRunner.When("I patch the following Goal:", ((string)(null)), table797, "When ");
#line hidden
#line 121
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
