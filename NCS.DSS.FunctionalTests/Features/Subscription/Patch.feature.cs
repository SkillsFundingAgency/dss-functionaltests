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
namespace NCS.DSS.FunctionalTests.Features.Subscription
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SubscriptionPatch")]
    public partial class SubscriptionPatchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Patch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Subscription", "SubscriptionPatch", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table702 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table702.AddRow(new string[] {
                        "GivenName",
                        "Bobby"});
            table702.AddRow(new string[] {
                        "FamilyName",
                        "SubPatch"});
            table702.AddRow(new string[] {
                        "PriorityGroups",
                        "1,3"});
#line 4
 testRunner.Given("I post a Customer with the following details V3:", ((string)(null)), table702, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table703 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table703.AddRow(new string[] {
                        "TouchpointId",
                        "9111111111"});
            table703.AddRow(new string[] {
                        "Subscribe",
                        "true"});
#line 9
 testRunner.And("I post a subscription with the following details:", ((string)(null)), table703, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Minimum")]
        [NUnit.Framework.CategoryAttribute("subscriptions")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchMinimum()
        {
            string[] tagsOfScenario = new string[] {
                    "subscriptions",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Minimum", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 15
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
                TechTalk.SpecFlow.Table table704 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table704.AddRow(new string[] {
                            "TouchPointId",
                            "9111111111"});
                table704.AddRow(new string[] {
                            "Subscribe",
                            "false"});
#line 16
 testRunner.Given("I patch a subscription with the following details:", ((string)(null)), table704, "Given ");
#line hidden
#line 20
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table705 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table705.AddRow(new string[] {
                            "TouchPointId",
                            "9111111111"});
                table705.AddRow(new string[] {
                            "Subscribe",
                            "false"});
#line 21
 testRunner.And("the response body should contain:", ((string)(null)), table705, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
