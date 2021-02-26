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
            TechTalk.SpecFlow.Table table1240 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1240.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table1240.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 4
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table1240, "Given ");
#line hidden
#line 8
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1241 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1241.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table1241.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 9
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table1241, "Given ");
#line hidden
#line 13
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1242 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1242.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table1242.AddRow(new string[] {
                        "Channel",
                        "2"});
            table1242.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table1242.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 14
 testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table1242, "Given ");
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
#line 22
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
                TechTalk.SpecFlow.Table table1243 = new TechTalk.SpecFlow.Table(new string[] {
                            "field",
                            "value"});
                table1243.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table1243.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table1243.AddRow(new string[] {
                            "SessionAttended",
                            "true"});
#line 23
 testRunner.Given("I post a session with the following details:", ((string)(null)), table1243, "Given ");
#line hidden
#line 28
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1244 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1244.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-22T14:45:00Z"});
#line 29
 testRunner.When("I patch the following Session:", ((string)(null)), table1244, "When ");
#line hidden
#line 32
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1245 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1245.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-22T14:45:00Z"});
                table1245.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table1245.AddRow(new string[] {
                            "SessionAttended",
                            "true"});
#line 33
 testRunner.And("the response body should contain:", ((string)(null)), table1245, "And ");
#line hidden
#line 38
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 39
 testRunner.Then("there should be a record in the dss-sessions table with SessionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 43
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
                TechTalk.SpecFlow.Table table1246 = new TechTalk.SpecFlow.Table(new string[] {
                            "field",
                            "value"});
                table1246.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table1246.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table1246.AddRow(new string[] {
                            "SessionAttended",
                            "true"});
#line 44
 testRunner.Given("I post a session with the following details:", ((string)(null)), table1246, "Given ");
#line hidden
#line 49
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1247 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1247.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NQ"});
#line 50
 testRunner.When("I patch the following Session:", ((string)(null)), table1247, "When ");
#line hidden
#line 53
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1248 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1248.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table1248.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NQ"});
                table1248.AddRow(new string[] {
                            "SessionAttended",
                            "true"});
#line 54
 testRunner.And("the response body should contain:", ((string)(null)), table1248, "And ");
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
#line 61
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
                TechTalk.SpecFlow.Table table1249 = new TechTalk.SpecFlow.Table(new string[] {
                            "field",
                            "value"});
                table1249.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table1249.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table1249.AddRow(new string[] {
                            "SessionAttended",
                            "true"});
#line 62
 testRunner.Given("I post a session with the following details:", ((string)(null)), table1249, "Given ");
#line hidden
#line 67
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1250 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1250.AddRow(new string[] {
                            "SessionAttended",
                            "false"});
#line 68
 testRunner.When("I patch the following Session:", ((string)(null)), table1250, "When ");
#line hidden
#line 71
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1251 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table1251.AddRow(new string[] {
                            "DateandTimeOfSession",
                            "2018-06-21T14:45:00Z"});
                table1251.AddRow(new string[] {
                            "VenuePostCode",
                            "NN1 2NN"});
                table1251.AddRow(new string[] {
                            "SessionAttended",
                            "false"});
#line 72
 testRunner.And("the response body should contain:", ((string)(null)), table1251, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
