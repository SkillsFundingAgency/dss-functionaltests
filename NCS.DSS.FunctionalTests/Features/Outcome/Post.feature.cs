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
    [NUnit.Framework.DescriptionAttribute("Post an Outcome")]
    public partial class PostAnOutcomeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Post.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Outcome", "Post an Outcome", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table984 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table984.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table984.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table984, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table985 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table985.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table985.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table985, "And ");
#line hidden
            TechTalk.SpecFlow.Table table986 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table986.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table986.AddRow(new string[] {
                        "Channel",
                        "2"});
            table986.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table986.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 12
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table986, "And ");
#line hidden
            TechTalk.SpecFlow.Table table987 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table987.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table987.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table987.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table987.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table987.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table987.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table987.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table987.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 18
 testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table987, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create an outcome with all valid values")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void CreateAnOutcomeWithAllValidValues()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an outcome with all valid values", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table988 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table988.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
                table988.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table988.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
#line 31
 testRunner.Given("I post an outcome with the following details:", ((string)(null)), table988, "Given ");
#line hidden
#line 36
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table989 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table989.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
                table989.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table989.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
#line 37
 testRunner.And("the response body should contain:", ((string)(null)), table989, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create an outcome with missing OutcomeType")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void CreateAnOutcomeWithMissingOutcomeType()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an outcome with missing OutcomeType", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 46
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
                TechTalk.SpecFlow.Table table990 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table990.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table990.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
#line 47
 testRunner.Given("I post an outcome with the following details:", ((string)(null)), table990, "Given ");
#line hidden
#line 51
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create an outcome with invalid OutcomeType")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void CreateAnOutcomeWithInvalidOutcomeType()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an outcome with invalid OutcomeType", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 54
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
                TechTalk.SpecFlow.Table table991 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table991.AddRow(new string[] {
                            "OutcomeType",
                            "8"});
                table991.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table991.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
#line 55
 testRunner.Given("I post an outcome with the following details:", ((string)(null)), table991, "Given ");
#line hidden
#line 60
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create an outcome with missing OutcomeClaimedDate")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void CreateAnOutcomeWithMissingOutcomeClaimedDate()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an outcome with missing OutcomeClaimedDate", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 63
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
                TechTalk.SpecFlow.Table table992 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table992.AddRow(new string[] {
                            "OutcomeType",
                            "2"});
                table992.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
#line 64
 testRunner.Given("I post an outcome with the following details:", ((string)(null)), table992, "Given ");
#line hidden
#line 68
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table993 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table993.AddRow(new string[] {
                            "OutcomeType",
                            "2"});
                table993.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
#line 69
 testRunner.And("the response body should contain:", ((string)(null)), table993, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create an outcome with missing OutcomeEffectiveDate")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void CreateAnOutcomeWithMissingOutcomeEffectiveDate()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an outcome with missing OutcomeEffectiveDate", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 77
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
                TechTalk.SpecFlow.Table table994 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table994.AddRow(new string[] {
                            "OutcomeType",
                            "2"});
                table994.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
#line 78
 testRunner.Given("I post an outcome with the following details:", ((string)(null)), table994, "Given ");
#line hidden
#line 82
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table995 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table995.AddRow(new string[] {
                            "OutcomeType",
                            "2"});
                table995.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
#line 83
 testRunner.And("the response body should contain:", ((string)(null)), table995, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
