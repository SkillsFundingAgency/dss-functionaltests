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
    [NUnit.Framework.DescriptionAttribute("SessionPostV2")]
    public partial class SessionPostV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PostV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Session", "SessionPostV2", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table741 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table741.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table741.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table741, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table742 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table742.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table742.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table742, "And ");
#line hidden
            TechTalk.SpecFlow.Table table743 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table743.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table743.AddRow(new string[] {
                        "Channel",
                        "2"});
            table743.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table743.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 12
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table743, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Session for with venue postcode that reports wrong location when Country" +
            " paraneters is not passed to geocoding")]
        [NUnit.Framework.CategoryAttribute("sessions")]
        public virtual void CreateASessionForWithVenuePostcodeThatReportsWrongLocationWhenCountryParanetersIsNotPassedToGeocoding()
        {
            string[] tagsOfScenario = new string[] {
                    "sessions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Session for with venue postcode that reports wrong location when Country" +
                    " paraneters is not passed to geocoding", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table744 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table744.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table744.AddRow(new string[] {
                            "VenuePostCode",
                            "S41 8SE"});
#line 21
 testRunner.Given("I post a session with the following details:", ((string)(null)), table744, "Given ");
#line hidden
#line 25
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table745 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table745.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table745.AddRow(new string[] {
                            "VenuePostCode",
                            "S41 8SE"});
                table745.AddRow(new string[] {
                            "SessionAttended",
                            ""});
                table745.AddRow(new string[] {
                            "ReasonForNonAttendance",
                            "99"});
#line 29
 testRunner.And("the response body should contain:", ((string)(null)), table745, "And ");
#line hidden
#line 35
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("the response body should not contain the \"Longitude\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("the response body should not contain the \"Latitude\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change feed for Post Session")]
        [NUnit.Framework.CategoryAttribute("sessions")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void ChangeFeedForPostSession()
        {
            string[] tagsOfScenario = new string[] {
                    "sessions",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change feed for Post Session", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 42
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
                TechTalk.SpecFlow.Table table746 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table746.AddRow(new string[] {
                            "AdviserName",
                            "BillyAdviser"});
                table746.AddRow(new string[] {
                            "AdviserContactNumber",
                            "98798678967967"});
#line 43
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table746, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table747 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table747.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table747.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 47
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table747, "And ");
#line hidden
                TechTalk.SpecFlow.Table table748 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table748.AddRow(new string[] {
                            "DateandTimeOfInteraction",
                            "2018-06-25T11:21:00Z"});
                table748.AddRow(new string[] {
                            "Channel",
                            "2"});
                table748.AddRow(new string[] {
                            "InteractionType",
                            "2"});
                table748.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-06-22T16:52:10Z"});
#line 51
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table748, "And ");
#line hidden
                TechTalk.SpecFlow.Table table749 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table749.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table749.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
#line 57
 testRunner.Given("I post a session with the following details V2:", ((string)(null)), table749, "Given ");
#line hidden
#line 61
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
#line 74
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
                TechTalk.SpecFlow.Table table750 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table750.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "21-065-2012"});
                table750.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
#line 75
 testRunner.Given("I post a session with the following details V2:", ((string)(null)), table750, "Given ");
#line hidden
#line 79
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
#line 82
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
                TechTalk.SpecFlow.Table table751 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table751.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "21-06-2018"});
                table751.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1"});
#line 83
 testRunner.Given("I post a session with the following details V2:", ((string)(null)), table751, "Given ");
#line hidden
#line 87
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
