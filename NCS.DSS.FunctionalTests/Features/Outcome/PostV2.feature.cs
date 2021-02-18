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
    [NUnit.Framework.DescriptionAttribute("Post V2 Outcome")]
    public partial class PostV2OutcomeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PostV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Outcome", "Post V2 Outcome", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table1049 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1049.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table1049.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table1049, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1050 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1050.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table1050.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table1050, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1051 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1051.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table1051.AddRow(new string[] {
                        "Channel",
                        "2"});
            table1051.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table1051.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 12
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table1051, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1052 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1052.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table1052.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
#line 18
 testRunner.And("I post a session with the following details:", ((string)(null)), table1052, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1053 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table1053.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table1053.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table1053.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table1053.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table1053.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table1053.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table1053.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table1053.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 22
 testRunner.And("I post an ActionPlan with the following details:", ((string)(null)), table1053, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create an outcome with minimum valid values")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void CreateAnOutcomeWithMinimumValidValues()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an outcome with minimum valid values", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 34
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
                TechTalk.SpecFlow.Table table1054 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1054.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
#line 35
 testRunner.Given("I post an outcome with the following details V2:", ((string)(null)), table1054, "Given ");
#line hidden
#line 38
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1055 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1055.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
#line 40
 testRunner.And("the response body should contain:", ((string)(null)), table1055, "And ");
#line hidden
#line 43
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("there should be a record in the dss-outcomes table with OutcomeId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("there should be 1 records in the dss-outcomes-history table with SessionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create an outcome with all valid values")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void CreateAnOutcomeWithAllValidValues()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes",
                    "subcontractorId"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an outcome with all valid values", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 48
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
                TechTalk.SpecFlow.Table table1056 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1056.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
                table1056.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table1056.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table1056.AddRow(new string[] {
                            "ClaimedPriorityGroup",
                            "5"});
#line 49
 testRunner.Given("I post an outcome with the following details V2:", ((string)(null)), table1056, "Given ");
#line hidden
#line 55
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1057 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1057.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
                table1057.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table1057.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table1057.AddRow(new string[] {
                            "ClaimedPriorityGroup",
                            "5"});
#line 57
 testRunner.And("the response body should contain:", ((string)(null)), table1057, "And ");
#line hidden
#line 63
 testRunner.And("the response body should contain the SubContractorId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.And("there should be a record in the dss-outcomes table with OutcomeId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And("there should be 1 records in the dss-outcomes-history table with SessionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
#line 69
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
                TechTalk.SpecFlow.Table table1058 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1058.AddRow(new string[] {
                            "OutcomeType",
                            "6"});
                table1058.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table1058.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table1058.AddRow(new string[] {
                            "ClaimedPriorityGroup",
                            "5"});
#line 70
 testRunner.Given("I post an outcome with the following details V2:", ((string)(null)), table1058, "Given ");
#line hidden
#line 76
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create an outcome with missing ClaimedPriorityGroup")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void CreateAnOutcomeWithMissingClaimedPriorityGroup()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an outcome with missing ClaimedPriorityGroup", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 79
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
                TechTalk.SpecFlow.Table table1059 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1059.AddRow(new string[] {
                            "OutcomeType",
                            "6"});
                table1059.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table1059.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
#line 80
 testRunner.Given("I post an outcome with the following details V2:", ((string)(null)), table1059, "Given ");
#line hidden
#line 85
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 88
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
                TechTalk.SpecFlow.Table table1060 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1060.AddRow(new string[] {
                            "OutcomeType",
                            "6"});
                table1060.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table1060.AddRow(new string[] {
                            "ClaimedPriorityGroup",
                            "5"});
#line 89
 testRunner.Given("I post an outcome with the following details V2:", ((string)(null)), table1060, "Given ");
#line hidden
#line 94
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create an outcome with OutcomeClaimedDate earlier than OutcomeEffectiveDate")]
        [NUnit.Framework.CategoryAttribute("outcomes")]
        public virtual void CreateAnOutcomeWithOutcomeClaimedDateEarlierThanOutcomeEffectiveDate()
        {
            string[] tagsOfScenario = new string[] {
                    "outcomes"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an outcome with OutcomeClaimedDate earlier than OutcomeEffectiveDate", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 97
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
                TechTalk.SpecFlow.Table table1061 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1061.AddRow(new string[] {
                            "OutcomeType",
                            "6"});
                table1061.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-19T21:45:00Z"});
                table1061.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table1061.AddRow(new string[] {
                            "ClaimedPriorityGroup",
                            "5"});
#line 98
 testRunner.Given("I post an outcome with the following details V2:", ((string)(null)), table1061, "Given ");
#line hidden
#line 104
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
