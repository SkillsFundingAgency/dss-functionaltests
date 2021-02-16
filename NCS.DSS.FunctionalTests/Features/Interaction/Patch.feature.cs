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
namespace NCS.DSS.FunctionalTests.Features.Interaction
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("InteractionPatch")]
    public partial class InteractionPatchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Patch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Interaction", "InteractionPatch", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table817 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table817.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table817.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table817, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table818 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table818.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table818.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table818, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Date")]
        [NUnit.Framework.CategoryAttribute("interactions")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchDate()
        {
            string[] tagsOfScenario = new string[] {
                    "interactions",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Date", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table819 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table819.AddRow(new string[] {
                            "DateandTimeOfInteraction",
                            "2018-06-25T11:21:00Z"});
                table819.AddRow(new string[] {
                            "Channel",
                            "2"});
                table819.AddRow(new string[] {
                            "InteractionType",
                            "2"});
#line 15
 testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table819, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table820 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table820.AddRow(new string[] {
                            "DateandTimeOfInteraction",
                            "2018-06-26T11:21:00Z"});
#line 20
 testRunner.When("I patch the following Valid Interaction:", ((string)(null)), table820, "When ");
#line hidden
#line 23
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table821 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table821.AddRow(new string[] {
                            "DateandTimeOfInteraction",
                            "2018-06-26T11:21:00Z"});
                table821.AddRow(new string[] {
                            "Channel",
                            "2"});
                table821.AddRow(new string[] {
                            "InteractionType",
                            "2"});
#line 24
 testRunner.And("the response body should contain:", ((string)(null)), table821, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch channel")]
        [NUnit.Framework.CategoryAttribute("interactions")]
        public virtual void PatchChannel()
        {
            string[] tagsOfScenario = new string[] {
                    "interactions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch channel", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 33
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
                TechTalk.SpecFlow.Table table822 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table822.AddRow(new string[] {
                            "DateandTimeOfInteraction",
                            "2018-06-25T11:21:00Z"});
                table822.AddRow(new string[] {
                            "Channel",
                            "2"});
                table822.AddRow(new string[] {
                            "InteractionType",
                            "2"});
#line 34
 testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table822, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table823 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table823.AddRow(new string[] {
                            "Channel",
                            "1"});
#line 39
 testRunner.When("I patch the following Valid Interaction:", ((string)(null)), table823, "When ");
#line hidden
#line 42
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table824 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table824.AddRow(new string[] {
                            "DateandTimeOfInteraction",
                            "2018-06-25T11:21:00Z"});
                table824.AddRow(new string[] {
                            "Channel",
                            "1"});
                table824.AddRow(new string[] {
                            "InteractionType",
                            "2"});
#line 43
 testRunner.And("the response body should contain:", ((string)(null)), table824, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch InteractionType")]
        [NUnit.Framework.CategoryAttribute("interactions")]
        public virtual void PatchInteractionType()
        {
            string[] tagsOfScenario = new string[] {
                    "interactions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch InteractionType", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 52
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
                TechTalk.SpecFlow.Table table825 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table825.AddRow(new string[] {
                            "DateandTimeOfInteraction",
                            "2018-06-25T11:21:00Z"});
                table825.AddRow(new string[] {
                            "Channel",
                            "2"});
                table825.AddRow(new string[] {
                            "InteractionType",
                            "2"});
#line 53
 testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table825, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table826 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table826.AddRow(new string[] {
                            "InteractionType",
                            "1"});
#line 58
 testRunner.When("I patch the following Valid Interaction:", ((string)(null)), table826, "When ");
#line hidden
#line 61
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table827 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table827.AddRow(new string[] {
                            "DateandTimeOfInteraction",
                            "2018-06-25T11:21:00Z"});
                table827.AddRow(new string[] {
                            "Channel",
                            "2"});
                table827.AddRow(new string[] {
                            "InteractionType",
                            "1"});
#line 62
 testRunner.And("the response body should contain:", ((string)(null)), table827, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
