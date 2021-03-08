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
namespace NCS.DSS.FunctionalTests.Features.Adviser
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AdviserPostV2")]
    public partial class AdviserPostV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PostV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Adviser", "AdviserPostV2", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Valid Adviser")]
        [NUnit.Framework.CategoryAttribute("adviserdetails")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void CreateValidAdviser()
        {
            string[] tagsOfScenario = new string[] {
                    "adviserdetails",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Valid Adviser", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
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
                TechTalk.SpecFlow.Table table378 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table378.AddRow(new string[] {
                            "AdviserName",
                            "BillyAdviser"});
                table378.AddRow(new string[] {
                            "AdviserEmailAddress",
                            "billy@bill.com"});
                table378.AddRow(new string[] {
                            "AdviserContactNumber",
                            "98798678967967"});
#line 5
 testRunner.Given("I post an adviser with the following details V2:", ((string)(null)), table378, "Given ");
#line hidden
#line 10
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table379 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table379.AddRow(new string[] {
                            "AdviserName",
                            "BillyAdviser"});
                table379.AddRow(new string[] {
                            "AdviserEmailAddress",
                            "billy@bill.com"});
                table379.AddRow(new string[] {
                            "AdviserContactNumber",
                            "98798678967967"});
#line 11
 testRunner.And("the response body should contain:", ((string)(null)), table379, "And ");
#line hidden
#line 16
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.Given("I fetch a adviserdetails cosmos document from adviserdetails database using key A" +
                        "dviserDetailId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 18
 testRunner.Then("the cosmos document should have property CreatedBy with value 9111111111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Valid Adviser with SubcontractorId")]
        [NUnit.Framework.CategoryAttribute("adviserdetails")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void CreateValidAdviserWithSubcontractorId()
        {
            string[] tagsOfScenario = new string[] {
                    "adviserdetails",
                    "subcontractorId"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Valid Adviser with SubcontractorId", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 21
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
#line 22
 testRunner.Given("I want to set the scenario touchPointId header to 9111111111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table380 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table380.AddRow(new string[] {
                            "AdviserName",
                            "BillyAdviser"});
                table380.AddRow(new string[] {
                            "AdviserEmailAddress",
                            "billy@bill.com"});
                table380.AddRow(new string[] {
                            "AdviserContactNumber",
                            "98798678967967"});
#line 23
 testRunner.Given("I post an adviser with the following details V2:", ((string)(null)), table380, "Given ");
#line hidden
#line 28
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table381 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table381.AddRow(new string[] {
                            "AdviserName",
                            "BillyAdviser"});
                table381.AddRow(new string[] {
                            "AdviserEmailAddress",
                            "billy@bill.com"});
                table381.AddRow(new string[] {
                            "AdviserContactNumber",
                            "98798678967967"});
#line 29
 testRunner.And("the response body should contain:", ((string)(null)), table381, "And ");
#line hidden
#line 35
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Given("I fetch a adviserdetails cosmos document from adviserdetails database using key A" +
                        "dviserDetailId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 37
 testRunner.Then("the cosmos document should have property CreatedBy with value 9111111111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change feed for Post Adviser")]
        [NUnit.Framework.CategoryAttribute("adviserdetails")]
        public virtual void ChangeFeedForPostAdviser()
        {
            string[] tagsOfScenario = new string[] {
                    "adviserdetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change feed for Post Adviser", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 40
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
#line 41
 testRunner.Given("I want to set the scenario touchPointId header to 9111111111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table382 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table382.AddRow(new string[] {
                            "AdviserName",
                            "BillyAdviser"});
                table382.AddRow(new string[] {
                            "AdviserEmailAddress",
                            "billy@bill.com"});
#line 42
 testRunner.Given("I post an adviser with the following details V2:", ((string)(null)), table382, "Given ");
#line hidden
#line 46
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 48
 testRunner.Then("there should be a record in the dss-adviserdetails table with AdviserDetailId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.Given("I fetch a adviserdetails cosmos document from adviserdetails database using key A" +
                        "dviserDetailId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 51
 testRunner.Then("the cosmos document should have property CreatedBy with value 9111111111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Missing AdviserName")]
        [NUnit.Framework.CategoryAttribute("adviserdetails")]
        public virtual void MissingAdviserName()
        {
            string[] tagsOfScenario = new string[] {
                    "adviserdetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Missing AdviserName", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table383 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table383.AddRow(new string[] {
                            "AdviserEmailAddress",
                            "billy@bill.com"});
                table383.AddRow(new string[] {
                            "AdviserContactNumber",
                            "98798678967967"});
#line 55
 testRunner.Given("I post an adviser with the following details V2:", ((string)(null)), table383, "Given ");
#line hidden
#line 59
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
