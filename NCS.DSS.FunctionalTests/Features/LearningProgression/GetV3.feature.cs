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
namespace NCS.DSS.FunctionalTests.Features.LearningProgression
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LearningProgression_Get")]
    public partial class LearningProgression_GetFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GetV3.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/LearningProgression", "LearningProgression_Get", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table892 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table892.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table892.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table892, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table893 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table893.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table893.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table893, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Learning Progression by ID")]
        [NUnit.Framework.CategoryAttribute("learningprogressions")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void GetLearningProgressionByID()
        {
            string[] tagsOfScenario = new string[] {
                    "learningprogressions",
                    "Smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Learning Progression by ID", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 14
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
                TechTalk.SpecFlow.Table table894 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table894.AddRow(new string[] {
                            "DateProgressionRecorded",
                            "2018-06-25T11:21:00Z"});
                table894.AddRow(new string[] {
                            "CurrentLearningStatus",
                            "1"});
                table894.AddRow(new string[] {
                            "LearningHours",
                            "1"});
                table894.AddRow(new string[] {
                            "DateLearningStarted",
                            "2019-06-25T11:21:00Z"});
                table894.AddRow(new string[] {
                            "CurrentQualificationLevel",
                            "2"});
                table894.AddRow(new string[] {
                            "DateQualificationLevelAchieved",
                            "2019-07-25T11:21:00Z"});
                table894.AddRow(new string[] {
                            "LastLearningProvidersUKPRN",
                            "12345678"});
#line 15
 testRunner.Given("I post a Learning Progression record with the following details V3:", ((string)(null)), table894, "Given ");
#line hidden
#line 24
 testRunner.When("I get a Learning Progression by ID V3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table895 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table895.AddRow(new string[] {
                            "DateProgressionRecorded",
                            "2018-06-25T11:21:00Z"});
                table895.AddRow(new string[] {
                            "CurrentLearningStatus",
                            "1"});
                table895.AddRow(new string[] {
                            "LearningHours",
                            "1"});
                table895.AddRow(new string[] {
                            "DateLearningStarted",
                            "2019-06-25T11:21:00Z"});
                table895.AddRow(new string[] {
                            "CurrentQualificationLevel",
                            "2"});
                table895.AddRow(new string[] {
                            "DateQualificationLevelAchieved",
                            "2019-07-25T11:21:00Z"});
                table895.AddRow(new string[] {
                            "LastLearningProvidersUKPRN",
                            "12345678"});
#line 26
 testRunner.And("the response body should contain:", ((string)(null)), table895, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get All Learning Progression records where 1 exists")]
        [NUnit.Framework.CategoryAttribute("learningprogressions")]
        public virtual void GetAllLearningProgressionRecordsWhere1Exists()
        {
            string[] tagsOfScenario = new string[] {
                    "learningprogressions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get All Learning Progression records where 1 exists", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 38
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
                TechTalk.SpecFlow.Table table896 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table896.AddRow(new string[] {
                            "DateProgressionRecorded",
                            "2018-06-25T11:21:00Z"});
                table896.AddRow(new string[] {
                            "CurrentLearningStatus",
                            "1"});
                table896.AddRow(new string[] {
                            "LearningHours",
                            "1"});
                table896.AddRow(new string[] {
                            "DateLearningStarted",
                            "2019-06-25T11:21:00Z"});
                table896.AddRow(new string[] {
                            "CurrentQualificationLevel",
                            "2"});
                table896.AddRow(new string[] {
                            "DateQualificationLevelAchieved",
                            "2019-07-25T11:21:00Z"});
                table896.AddRow(new string[] {
                            "LastLearningProvidersUKPRN",
                            "12345678"});
#line 39
 testRunner.Given("I post a Learning Progression record with the following details V3:", ((string)(null)), table896, "Given ");
#line hidden
#line 48
 testRunner.When("I get all Learning Progression records for a customer V3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
 testRunner.And("the response should contain 1 document(s)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table897 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table897.AddRow(new string[] {
                            "DateProgressionRecorded",
                            "2018-06-25T11:21:00Z"});
                table897.AddRow(new string[] {
                            "CurrentLearningStatus",
                            "1"});
                table897.AddRow(new string[] {
                            "LearningHours",
                            "1"});
                table897.AddRow(new string[] {
                            "DateLearningStarted",
                            "2019-06-25T11:21:00Z"});
                table897.AddRow(new string[] {
                            "CurrentQualificationLevel",
                            "2"});
                table897.AddRow(new string[] {
                            "DateQualificationLevelAchieved",
                            "2019-07-25T11:21:00Z"});
                table897.AddRow(new string[] {
                            "LastLearningProvidersUKPRN",
                            "12345678"});
#line 51
 testRunner.Then("the response body should contain:", ((string)(null)), table897, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Learning Progression by invalid ID")]
        [NUnit.Framework.CategoryAttribute("learningprogressions")]
        public virtual void GetLearningProgressionByInvalidID()
        {
            string[] tagsOfScenario = new string[] {
                    "learningprogressions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Learning Progression by invalid ID", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 62
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
                TechTalk.SpecFlow.Table table898 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table898.AddRow(new string[] {
                            "DateProgressionRecorded",
                            "2018-06-25T11:21:00Z"});
                table898.AddRow(new string[] {
                            "CurrentLearningStatus",
                            "1"});
                table898.AddRow(new string[] {
                            "LearningHours",
                            "1"});
                table898.AddRow(new string[] {
                            "DateLearningStarted",
                            "2019-06-25T11:21:00Z"});
                table898.AddRow(new string[] {
                            "CurrentQualificationLevel",
                            "2"});
                table898.AddRow(new string[] {
                            "DateQualificationLevelAchieved",
                            "2019-07-25T11:21:00Z"});
                table898.AddRow(new string[] {
                            "LastLearningProvidersUKPRN",
                            "12345678"});
#line 63
 testRunner.Given("I post a Learning Progression record with the following details V3:", ((string)(null)), table898, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table899 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table899.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table899.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 72
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table899, "And ");
#line hidden
#line 76
 testRunner.When("I get a Learning Progression by ID V3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.Then("there should be a 204 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get All Learning Progression records where none exist")]
        [NUnit.Framework.CategoryAttribute("learningprogressions")]
        public virtual void GetAllLearningProgressionRecordsWhereNoneExist()
        {
            string[] tagsOfScenario = new string[] {
                    "learningprogressions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get All Learning Progression records where none exist", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table900 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table900.AddRow(new string[] {
                            "DateProgressionRecorded",
                            "2018-06-25T11:21:00Z"});
                table900.AddRow(new string[] {
                            "CurrentLearningStatus",
                            "1"});
                table900.AddRow(new string[] {
                            "LearningHours",
                            "1"});
                table900.AddRow(new string[] {
                            "DateLearningStarted",
                            "2019-06-25T11:21:00Z"});
                table900.AddRow(new string[] {
                            "CurrentQualificationLevel",
                            "2"});
                table900.AddRow(new string[] {
                            "DateQualificationLevelAchieved",
                            "2019-07-25T11:21:00Z"});
                table900.AddRow(new string[] {
                            "LastLearningProvidersUKPRN",
                            "12345678"});
#line 81
 testRunner.Given("I post a Learning Progression record with the following details V3:", ((string)(null)), table900, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table901 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table901.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table901.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 90
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table901, "And ");
#line hidden
#line 94
 testRunner.When("I get all Learning Progression records for a customer V3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("there should be a 204 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
