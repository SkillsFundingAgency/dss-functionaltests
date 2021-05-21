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
    [NUnit.Framework.DescriptionAttribute("Post V3 Outcome")]
    public partial class PostV3OutcomeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PostV3.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Outcome", "Post V3 Outcome", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table864 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table864.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table864.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details V2:", ((string)(null)), table864, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table865 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table865.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table865.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table865.AddRow(new string[] {
                        "PriorityGroups",
                        "1,3"});
#line 8
 testRunner.And("I post a Customer with the following details V3:", ((string)(null)), table865, "And ");
#line hidden
            TechTalk.SpecFlow.Table table866 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table866.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table866.AddRow(new string[] {
                        "Channel",
                        "2"});
            table866.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table866.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 13
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table866, "And ");
#line hidden
            TechTalk.SpecFlow.Table table867 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table867.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table867.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
#line 19
 testRunner.And("I post a session with the following details V2:", ((string)(null)), table867, "And ");
#line hidden
            TechTalk.SpecFlow.Table table868 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table868.AddRow(new string[] {
                        "DateActionPlanCreated",
                        "2018-07-30T09:00:00Z"});
            table868.AddRow(new string[] {
                        "CustomerCharterShownToCustomer",
                        "true"});
            table868.AddRow(new string[] {
                        "DateAndTimeCharterShown",
                        "2018-07-30T09:00:00Z"});
            table868.AddRow(new string[] {
                        "DateActionPlanSentToCustomer",
                        "2018-07-30T09:00:00Z"});
            table868.AddRow(new string[] {
                        "ActionPlanDeliveryMethod",
                        "1"});
            table868.AddRow(new string[] {
                        "DateActionPlanAcknowledged",
                        "2018-07-30T09:00:00Z"});
            table868.AddRow(new string[] {
                        "PriorityCustomer",
                        "1"});
            table868.AddRow(new string[] {
                        "CurrentSituation",
                        "looking for work"});
#line 23
 testRunner.And("I post an ActionPlan with the following details V3:", ((string)(null)), table868, "And ");
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
                TechTalk.SpecFlow.Table table869 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table869.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
#line 36
 testRunner.Given("I post an outcome with the following details V3:", ((string)(null)), table869, "Given ");
#line hidden
#line 39
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table870 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table870.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
#line 41
 testRunner.And("the response body should contain:", ((string)(null)), table870, "And ");
#line hidden
#line 44
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 46
 testRunner.Then("there should be a record in the dss-outcomes table with OutcomeId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 49
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
                TechTalk.SpecFlow.Table table871 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table871.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
                table871.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table871.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table871.AddRow(new string[] {
                            "IsPriorityCustomer",
                            "true"});
#line 50
 testRunner.Given("I post an outcome with the following details V3:", ((string)(null)), table871, "Given ");
#line hidden
#line 56
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table872 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table872.AddRow(new string[] {
                            "OutcomeType",
                            "3"});
                table872.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table872.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table872.AddRow(new string[] {
                            "IsPriorityCustomer",
                            "true"});
#line 58
 testRunner.And("the response body should contain:", ((string)(null)), table872, "And ");
#line hidden
#line 65
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 67
 testRunner.Then("there should be a record in the dss-outcomes table with OutcomeId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 70
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
                TechTalk.SpecFlow.Table table873 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table873.AddRow(new string[] {
                            "OutcomeType",
                            "6"});
                table873.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table873.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table873.AddRow(new string[] {
                            "IsPriorityCustomer",
                            "true"});
#line 71
 testRunner.Given("I post an outcome with the following details V3:", ((string)(null)), table873, "Given ");
#line hidden
#line 77
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
#line 80
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
                TechTalk.SpecFlow.Table table874 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table874.AddRow(new string[] {
                            "OutcomeType",
                            "6"});
                table874.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table874.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table874.AddRow(new string[] {
                            "IsPriorityCustomer",
                            "true"});
#line 81
 testRunner.Given("I post an outcome with the following details V3:", ((string)(null)), table874, "Given ");
#line hidden
#line 87
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
#line 90
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
                TechTalk.SpecFlow.Table table875 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table875.AddRow(new string[] {
                            "OutcomeType",
                            "6"});
                table875.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-20T21:45:00Z"});
                table875.AddRow(new string[] {
                            "IsPriorityCustomer",
                            "true"});
#line 91
 testRunner.Given("I post an outcome with the following details V3:", ((string)(null)), table875, "Given ");
#line hidden
#line 96
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
#line 99
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
                TechTalk.SpecFlow.Table table876 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table876.AddRow(new string[] {
                            "OutcomeType",
                            "6"});
                table876.AddRow(new string[] {
                            "OutcomeClaimedDate",
                            "2018-07-19T21:45:00Z"});
                table876.AddRow(new string[] {
                            "OutcomeEffectiveDate",
                            "2018-07-20T21:45:00Z"});
                table876.AddRow(new string[] {
                            "IsPriorityCustomer",
                            "true"});
#line 100
 testRunner.Given("I post an outcome with the following details V3:", ((string)(null)), table876, "Given ");
#line hidden
#line 106
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
