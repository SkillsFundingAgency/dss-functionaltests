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
namespace NCS.DSS.FunctionalTests.Features.Session
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SessionPostV1")]
    public partial class SessionPostV1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Post.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Session", "SessionPostV1", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table798 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table798.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table798.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table798, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table799 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table799.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table799.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table799, "And ");
#line hidden
            TechTalk.SpecFlow.Table table800 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table800.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table800.AddRow(new string[] {
                        "Channel",
                        "2"});
            table800.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table800.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 12
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table800, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Session for existing customer with all valid Values")]
        [NUnit.Framework.CategoryAttribute("sessions")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void CreateASessionForExistingCustomerWithAllValidValues()
        {
            string[] tagsOfScenario = new string[] {
                    "sessions",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Session for existing customer with all valid Values", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 20
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
                TechTalk.SpecFlow.Table table801 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table801.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table801.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
#line 21
 testRunner.Given("I post a session with the following details:", ((string)(null)), table801, "Given ");
#line hidden
#line 25
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table802 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table802.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table802.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table802.AddRow(new string[] {
                            "SessionAttended",
                            ""});
                table802.AddRow(new string[] {
                            "ReasonForNonAttendance",
                            "99"});
#line 26
 testRunner.And("the response body should contain:", ((string)(null)), table802, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Session for existing customer with incorrect format for date and time of" +
            " session")]
        [NUnit.Framework.CategoryAttribute("sessions")]
        public virtual void CreateASessionForExistingCustomerWithIncorrectFormatForDateAndTimeOfSession()
        {
            string[] tagsOfScenario = new string[] {
                    "sessions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Session for existing customer with incorrect format for date and time of" +
                    " session", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 36
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
                TechTalk.SpecFlow.Table table803 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table803.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "21-065-2012"});
                table803.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
#line 37
 testRunner.Given("I post a session with the following details:", ((string)(null)), table803, "Given ");
#line hidden
#line 41
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Session for existing customer with incorrect format for venue post code")]
        [NUnit.Framework.CategoryAttribute("sessions")]
        public virtual void CreateASessionForExistingCustomerWithIncorrectFormatForVenuePostCode()
        {
            string[] tagsOfScenario = new string[] {
                    "sessions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Session for existing customer with incorrect format for venue post code", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 44
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
                TechTalk.SpecFlow.Table table804 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table804.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "21-06-2018"});
                table804.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1"});
#line 45
 testRunner.Given("I post a session with the following details:", ((string)(null)), table804, "Given ");
#line hidden
#line 49
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
