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
namespace NCS.DSS.FunctionalTests.Features.EmploymentProgression
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("EmploymentProgressionGetV3")]
    public partial class EmploymentProgressionGetV3Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GetV3.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/EmploymentProgression", "EmploymentProgressionGetV3", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table778 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table778.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table778.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table778, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table779 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table779.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table779.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table779, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Employment Progression by ID")]
        [NUnit.Framework.CategoryAttribute("employmentprogressions")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void GetEmploymentProgressionByID()
        {
            string[] tagsOfScenario = new string[] {
                    "employmentprogressions",
                    "Smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Employment Progression by ID", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table780 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table780.AddRow(new string[] {
                            "DateProgressionRecorded",
                            "2018-06-25T11:21:00Z"});
                table780.AddRow(new string[] {
                            "CurrentEmploymentStatus",
                            "1"});
                table780.AddRow(new string[] {
                            "EmploymentHours",
                            "1"});
                table780.AddRow(new string[] {
                            "DateOfEmployment",
                            "2019-06-25T11:21:00Z"});
                table780.AddRow(new string[] {
                            "LengthOfUnemployment",
                            "1"});
                table780.AddRow(new string[] {
                            "DateOfLastEmployment",
                            "2019-06-25T11:21:00Z"});
                table780.AddRow(new string[] {
                            "EconomicShockStatus",
                            "1"});
                table780.AddRow(new string[] {
                            "EconomicShockCode",
                            "Some text"});
                table780.AddRow(new string[] {
                            "EmployerName",
                            "Emp Smith"});
                table780.AddRow(new string[] {
                            "EmployerAddress",
                            "123 Pete Street"});
                table780.AddRow(new string[] {
                            "EmployerPostcode",
                            "PE12 3ST"});
#line 15
 testRunner.Given("I post a Employment Progression record with the following details V3:", ((string)(null)), table780, "Given ");
#line hidden
#line 28
 testRunner.When("I get a Employment Progression by ID V3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table781 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table781.AddRow(new string[] {
                            "DateProgressionRecorded",
                            "2018-06-25T11:21:00Z"});
                table781.AddRow(new string[] {
                            "CurrentEmploymentStatus",
                            "1"});
                table781.AddRow(new string[] {
                            "EmploymentHours",
                            "1"});
                table781.AddRow(new string[] {
                            "DateOfEmployment",
                            "2019-06-25T11:21:00Z"});
                table781.AddRow(new string[] {
                            "LengthOfUnemployment",
                            "1"});
                table781.AddRow(new string[] {
                            "DateOfLastEmployment",
                            "2019-06-25T11:21:00Z"});
                table781.AddRow(new string[] {
                            "EconomicShockStatus",
                            "1"});
                table781.AddRow(new string[] {
                            "EconomicShockCode",
                            "Some text"});
                table781.AddRow(new string[] {
                            "EmployerName",
                            "Emp Smith"});
                table781.AddRow(new string[] {
                            "EmployerAddress",
                            "123 Pete Street"});
                table781.AddRow(new string[] {
                            "EmployerPostcode",
                            "PE12 3ST"});
#line 30
 testRunner.And("the response body should contain:", ((string)(null)), table781, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get All Employment Progression records where 1 exists")]
        [NUnit.Framework.CategoryAttribute("employmentprogressions")]
        public virtual void GetAllEmploymentProgressionRecordsWhere1Exists()
        {
            string[] tagsOfScenario = new string[] {
                    "employmentprogressions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get All Employment Progression records where 1 exists", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 45
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
                TechTalk.SpecFlow.Table table782 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table782.AddRow(new string[] {
                            "DateProgressionRecorded",
                            "2018-06-25T11:21:00Z"});
                table782.AddRow(new string[] {
                            "CurrentEmploymentStatus",
                            "1"});
                table782.AddRow(new string[] {
                            "EmploymentHours",
                            "1"});
                table782.AddRow(new string[] {
                            "DateOfEmployment",
                            "2019-06-25T11:21:00Z"});
                table782.AddRow(new string[] {
                            "LengthOfUnemployment",
                            "1"});
                table782.AddRow(new string[] {
                            "DateOfLastEmployment",
                            "2019-06-25T11:21:00Z"});
                table782.AddRow(new string[] {
                            "EconomicShockStatus",
                            "1"});
                table782.AddRow(new string[] {
                            "EconomicShockCode",
                            "Some text"});
                table782.AddRow(new string[] {
                            "EmployerName",
                            "Emp Smith"});
                table782.AddRow(new string[] {
                            "EmployerAddress",
                            "123 Pete Street"});
                table782.AddRow(new string[] {
                            "EmployerPostcode",
                            "PE12 3ST"});
#line 46
 testRunner.Given("I post a Employment Progression record with the following details V3:", ((string)(null)), table782, "Given ");
#line hidden
#line 59
 testRunner.When("I get all Employment Progression records for a customer V3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Employment Progression by invalid ID")]
        [NUnit.Framework.CategoryAttribute("employmentprogressions")]
        public virtual void GetEmploymentProgressionByInvalidID()
        {
            string[] tagsOfScenario = new string[] {
                    "employmentprogressions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Employment Progression by invalid ID", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table783 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table783.AddRow(new string[] {
                            "DateProgressionRecorded",
                            "2018-06-25T11:21:00Z"});
                table783.AddRow(new string[] {
                            "CurrentEmploymentStatus",
                            "1"});
                table783.AddRow(new string[] {
                            "EmploymentHours",
                            "1"});
                table783.AddRow(new string[] {
                            "DateEmploymentStarted",
                            "2019-06-25T11:21:00Z"});
                table783.AddRow(new string[] {
                            "CurrentQualificationLevel",
                            "2"});
                table783.AddRow(new string[] {
                            "DateQualificationLevelAchieved",
                            "2019-07-25T11:21:00Z"});
                table783.AddRow(new string[] {
                            "LastEmploymentProvidersUKPRN",
                            "12345678"});
#line 78
 testRunner.Given("I post a Employment Progression record with the following details V3:", ((string)(null)), table783, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table784 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table784.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table784.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 87
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table784, "And ");
#line hidden
#line 91
 testRunner.When("I get a Employment Progression by ID V3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.Then("there should be a 204 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
