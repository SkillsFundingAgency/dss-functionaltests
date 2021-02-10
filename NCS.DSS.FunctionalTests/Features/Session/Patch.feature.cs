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
    [NUnit.Framework.DescriptionAttribute("SessionPatchV1")]
    public partial class SessionPatchV1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Patch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Session", "SessionPatchV1", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table761 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table761.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table761.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table761, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table762 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table762.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table762.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table762, "And ");
#line hidden
            TechTalk.SpecFlow.Table table763 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table763.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table763.AddRow(new string[] {
                        "Channel",
                        "2"});
            table763.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table763.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 12
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table763, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch DateandTimeOfSession")]
        [NUnit.Framework.CategoryAttribute("sessions")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchDateandTimeOfSession()
        {
            string[] tagsOfScenario = new string[] {
                    "sessions",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch DateandTimeOfSession", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table764 = new TechTalk.SpecFlow.Table(new string[] {
                            "field",
                            "value"});
                table764.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table764.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table764.AddRow(new string[] {
                            "SessionAttended",
                            "true"});
#line 21
 testRunner.Given("I post a session with the following details:", ((string)(null)), table764, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table765 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table765.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-22T14:45:00Z"});
#line 26
 testRunner.When("I patch the following Session:", ((string)(null)), table765, "When ");
#line hidden
#line 29
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table766 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table766.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-22T14:45:00Z"});
                table766.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table766.AddRow(new string[] {
                            "SessionAttended",
                            "true"});
#line 30
 testRunner.And("the response body should contain:", ((string)(null)), table766, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch VenuePostCode")]
        [NUnit.Framework.CategoryAttribute("sessions")]
        public virtual void PatchVenuePostCode()
        {
            string[] tagsOfScenario = new string[] {
                    "sessions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch VenuePostCode", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 39
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
                TechTalk.SpecFlow.Table table767 = new TechTalk.SpecFlow.Table(new string[] {
                            "field",
                            "value"});
                table767.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table767.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table767.AddRow(new string[] {
                            "SessionAttended",
                            "true"});
#line 40
 testRunner.Given("I post a session with the following details:", ((string)(null)), table767, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table768 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table768.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NQ"});
#line 45
 testRunner.When("I patch the following Session:", ((string)(null)), table768, "When ");
#line hidden
#line 48
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table769 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table769.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table769.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NQ"});
                table769.AddRow(new string[] {
                            "SessionAttended",
                            "true"});
#line 49
 testRunner.And("the response body should contain:", ((string)(null)), table769, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch SessionAttended")]
        [NUnit.Framework.CategoryAttribute("sessions")]
        public virtual void PatchSessionAttended()
        {
            string[] tagsOfScenario = new string[] {
                    "sessions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch SessionAttended", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 56
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
                TechTalk.SpecFlow.Table table770 = new TechTalk.SpecFlow.Table(new string[] {
                            "field",
                            "value"});
                table770.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table770.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table770.AddRow(new string[] {
                            "SessionAttended",
                            "true"});
#line 57
 testRunner.Given("I post a session with the following details:", ((string)(null)), table770, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table771 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table771.AddRow(new string[] {
                            "SessionAttended",
                            "false"});
#line 62
 testRunner.When("I patch the following Session:", ((string)(null)), table771, "When ");
#line hidden
#line 65
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table772 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table772.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table772.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table772.AddRow(new string[] {
                            "SessionAttended",
                            "false"});
#line 66
 testRunner.And("the response body should contain:", ((string)(null)), table772, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
