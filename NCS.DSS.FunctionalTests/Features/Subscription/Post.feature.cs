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
#line 5
#line hidden
            TechTalk.SpecFlow.Table table942 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table942.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table942.AddRow(new string[] {
                        "AdviserContactNumber",
                        "9879867896796"});
#line 6
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table942, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table943 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table943.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table943.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 10
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table943, "And ");
#line hidden
            TechTalk.SpecFlow.Table table944 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table944.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table944.AddRow(new string[] {
                        "Channel",
                        "2"});
            table944.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table944.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 14
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table944, "And ");
#line hidden
            TechTalk.SpecFlow.Table table945 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table945.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table945.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
            table945.AddRow(new string[] {
                        "SessionAttended",
                        "true"});
#line 20
 testRunner.And("I post a session with the following details:", ((string)(null)), table945, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Subscribe to a customer")]
        [NUnit.Framework.CategoryAttribute("subscriptions")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void SubscribeToACustomer()
        {
            string[] tagsOfScenario = new string[] {
                    "subscriptions",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subscribe to a customer", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 27
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
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table946 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table946.AddRow(new string[] {
                            "TouchpointId",
                            "9000000001"});
                table946.AddRow(new string[] {
                            "Subscribe",
                            "true"});
#line 28
 testRunner.Given("I post a new subscription request:", ((string)(null)), table946, "Given ");
#line hidden
#line 32
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table947 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table947.AddRow(new string[] {
                            "TouchpointId",
                            "9000000001"});
                table947.AddRow(new string[] {
                            "Subscribe",
                            "true"});
#line 33
 testRunner.And("the response body should contain:", ((string)(null)), table947, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
