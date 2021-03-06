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
    [NUnit.Framework.DescriptionAttribute("SubscriptionPost")]
    public partial class SubscriptionPostFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Post.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Subscription", "SubscriptionPost", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 6
#line hidden
            TechTalk.SpecFlow.Table table899 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table899.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table899.AddRow(new string[] {
                        "AdviserContactNumber",
                        "9879867896796"});
#line 7
 testRunner.Given("I post an adviser with the following details V2:", ((string)(null)), table899, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table900 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table900.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table900.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table900.AddRow(new string[] {
                        "PriorityGroups",
                        "1,3"});
#line 11
 testRunner.Given("I post a Customer with the following details V3:", ((string)(null)), table900, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table901 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table901.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table901.AddRow(new string[] {
                        "Channel",
                        "2"});
            table901.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table901.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 16
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table901, "And ");
#line hidden
            TechTalk.SpecFlow.Table table902 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table902.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table902.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
            table902.AddRow(new string[] {
                        "SessionAttended",
                        "true"});
#line 22
 testRunner.And("I post a session with the following details V2:", ((string)(null)), table902, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a subscription with all valid values")]
        [NUnit.Framework.CategoryAttribute("subscriptions")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void CreateASubscriptionWithAllValidValues()
        {
            string[] tagsOfScenario = new string[] {
                    "subscriptions",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a subscription with all valid values", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 29
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
#line 6
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table903 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table903.AddRow(new string[] {
                            "TouchPointId",
                            "9111111111"});
                table903.AddRow(new string[] {
                            "Subscribe",
                            "true"});
#line 30
 testRunner.Given("I post a subscription with the following details:", ((string)(null)), table903, "Given ");
#line hidden
#line 34
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table904 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table904.AddRow(new string[] {
                            "TouchPointId",
                            "9111111111"});
                table904.AddRow(new string[] {
                            "Subscribe",
                            "true"});
#line 35
 testRunner.And("the response body should contain:", ((string)(null)), table904, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
