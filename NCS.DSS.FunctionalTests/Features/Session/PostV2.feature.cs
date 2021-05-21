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
            TechTalk.SpecFlow.Table table882 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table882.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table882.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details V2:", ((string)(null)), table882, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table883 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table883.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table883.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table883.AddRow(new string[] {
                        "PriorityGroups",
                        "1,3"});
#line 8
 testRunner.And("I post a Customer with the following details V3:", ((string)(null)), table883, "And ");
#line hidden
            TechTalk.SpecFlow.Table table884 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table884.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table884.AddRow(new string[] {
                        "Channel",
                        "2"});
            table884.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table884.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 13
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table884, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a Session for with venue postcode that reports wrong location when Country" +
            " paraneters is not passed to geocoding")]
        [NUnit.Framework.CategoryAttribute("sessions")]
        [NUnit.Framework.CategoryAttribute("Ignore")]
        public virtual void CreateASessionForWithVenuePostcodeThatReportsWrongLocationWhenCountryParanetersIsNotPassedToGeocoding()
        {
            string[] tagsOfScenario = new string[] {
                    "sessions",
                    "Ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a Session for with venue postcode that reports wrong location when Country" +
                    " paraneters is not passed to geocoding", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table885 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table885.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table885.AddRow(new string[] {
                            "VenuePostCode",
                            "S46 8SE"});
#line 22
 testRunner.Given("I post a session with the following details V2:", ((string)(null)), table885, "Given ");
#line hidden
#line 26
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table886 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table886.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table886.AddRow(new string[] {
                            "VenuePostCode",
                            "S46 8SE"});
                table886.AddRow(new string[] {
                            "SessionAttended",
                            ""});
                table886.AddRow(new string[] {
                            "ReasonForNonAttendance",
                            "99"});
#line 30
 testRunner.And("the response body should contain:", ((string)(null)), table886, "And ");
#line hidden
#line 36
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("the response body should not contain the \"Longitude\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("the response body should not contain the \"Latitude\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 40
 testRunner.Then("there should be a record in the dss-sessions table with SessionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                TechTalk.SpecFlow.Table table887 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table887.AddRow(new string[] {
                            "AdviserName",
                            "BillyAdviser"});
                table887.AddRow(new string[] {
                            "AdviserContactNumber",
                            "98798678967967"});
#line 46
 testRunner.Given("I post an adviser with the following details V2:", ((string)(null)), table887, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table888 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table888.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table888.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
                table888.AddRow(new string[] {
                            "PriorityGroups",
                            "1,3"});
#line 50
 testRunner.And("I post a Customer with the following details V3:", ((string)(null)), table888, "And ");
#line hidden
                TechTalk.SpecFlow.Table table889 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table889.AddRow(new string[] {
                            "DateandTimeOfInteraction",
                            "2018-06-25T11:21:00Z"});
                table889.AddRow(new string[] {
                            "Channel",
                            "2"});
                table889.AddRow(new string[] {
                            "InteractionType",
                            "2"});
                table889.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-06-22T16:52:10Z"});
#line 55
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table889, "And ");
#line hidden
                TechTalk.SpecFlow.Table table890 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table890.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table890.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
#line 61
 testRunner.Given("I post a session with the following details V2:", ((string)(null)), table890, "Given ");
#line hidden
#line 65
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 71
 testRunner.Then("there should be a record in the dss-sessions table with SessionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 79
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
                TechTalk.SpecFlow.Table table891 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table891.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "21-065-2012"});
                table891.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
#line 80
 testRunner.Given("I post a session with the following details V2:", ((string)(null)), table891, "Given ");
#line hidden
#line 84
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
#line 87
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
                TechTalk.SpecFlow.Table table892 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table892.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "21-06-2018"});
                table892.AddRow(new string[] {
                            "VenuePostCode",
                            "NN76N N1"});
#line 88
 testRunner.Given("I post a session with the following details V2:", ((string)(null)), table892, "Given ");
#line hidden
#line 92
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
