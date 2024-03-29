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
namespace NCS.DSS.FunctionalTests.Features.Contact
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ContactPatchV1")]
    public partial class ContactPatchV1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Patch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Contact", "ContactPatchV1", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
            TechTalk.SpecFlow.Table table200 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table200.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table200.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
            table200.AddRow(new string[] {
                        "PriorityGroups",
                        "1,3"});
#line 4
 testRunner.Given("I post a Customer with the following details V3:", ((string)(null)), table200, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch PreferredContactMethod")]
        [NUnit.Framework.CategoryAttribute("contactdetails")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchPreferredContactMethod()
        {
            string[] tagsOfScenario = new string[] {
                    "contactdetails",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch PreferredContactMethod", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 11
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
                TechTalk.SpecFlow.Table table201 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table201.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table201.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table201.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table201.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 12
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table201, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table202 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table202.AddRow(new string[] {
                            "PreferredContactMethod",
                            "2"});
                table202.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
#line 18
 testRunner.When("I patch the following Contact:", ((string)(null)), table202, "When ");
#line hidden
#line 22
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table203 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table203.AddRow(new string[] {
                            "PreferredContactMethod",
                            "2"});
                table203.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table203.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table203.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 23
 testRunner.And("the response body should contain:", ((string)(null)), table203, "And ");
#line hidden
#line 29
 testRunner.And("there should be a record in the dss-contacts table with ContactId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch PreferredContactMethod with invalid data")]
        [NUnit.Framework.CategoryAttribute("contactdetails")]
        public virtual void PatchPreferredContactMethodWithInvalidData()
        {
            string[] tagsOfScenario = new string[] {
                    "contactdetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch PreferredContactMethod with invalid data", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table204 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table204.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table204.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table204.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table204.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 34
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table204, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table205 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table205.AddRow(new string[] {
                            "PreferredContactMethod",
                            "6"});
#line 40
 testRunner.When("I patch the following Contact:", ((string)(null)), table205, "When ");
#line hidden
#line 43
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch MobileNumber")]
        [NUnit.Framework.CategoryAttribute("contactdetails")]
        public virtual void PatchMobileNumber()
        {
            string[] tagsOfScenario = new string[] {
                    "contactdetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch MobileNumber", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 47
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
                TechTalk.SpecFlow.Table table206 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table206.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table206.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table206.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table206.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 48
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table206, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table207 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table207.AddRow(new string[] {
                            "MobileNumber",
                            "07676 654321"});
#line 54
 testRunner.When("I patch the following Contact:", ((string)(null)), table207, "When ");
#line hidden
#line 57
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table208 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table208.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table208.AddRow(new string[] {
                            "MobileNumber",
                            "07676 654321"});
                table208.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table208.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 58
 testRunner.And("the response body should contain:", ((string)(null)), table208, "And ");
#line hidden
#line 64
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 65
 testRunner.Then("there should be a record in the dss-contacts table with ContactId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch HomeNumber")]
        [NUnit.Framework.CategoryAttribute("contactdetails")]
        public virtual void PatchHomeNumber()
        {
            string[] tagsOfScenario = new string[] {
                    "contactdetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch HomeNumber", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 69
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
                TechTalk.SpecFlow.Table table209 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table209.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table209.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table209.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table209.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 70
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table209, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table210 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table210.AddRow(new string[] {
                            "HomeNumber",
                            "08654 654321"});
#line 76
 testRunner.When("I patch the following Contact:", ((string)(null)), table210, "When ");
#line hidden
#line 79
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table211 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table211.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table211.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table211.AddRow(new string[] {
                            "HomeNumber",
                            "08654 654321"});
                table211.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 80
 testRunner.And("the response body should contain:", ((string)(null)), table211, "And ");
#line hidden
#line 86
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 87
 testRunner.Then("there should be a record in the dss-contacts table with ContactId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch AlternativeNumber")]
        [NUnit.Framework.CategoryAttribute("contactdetails")]
        public virtual void PatchAlternativeNumber()
        {
            string[] tagsOfScenario = new string[] {
                    "contactdetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch AlternativeNumber", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 91
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
                TechTalk.SpecFlow.Table table212 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table212.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table212.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table212.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table212.AddRow(new string[] {
                            "AlternativeNumber",
                            "08654 123457"});
#line 92
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table212, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table213 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table213.AddRow(new string[] {
                            "AlternativeNumber",
                            "08654 123458"});
#line 98
 testRunner.When("I patch the following Contact:", ((string)(null)), table213, "When ");
#line hidden
#line 101
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table214 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table214.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table214.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table214.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table214.AddRow(new string[] {
                            "AlternativeNumber",
                            "08654 123458"});
#line 102
 testRunner.And("the response body should contain:", ((string)(null)), table214, "And ");
#line hidden
#line 108
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 109
 testRunner.Then("there should be a record in the dss-contacts table with ContactId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch EmailAddress")]
        [NUnit.Framework.CategoryAttribute("contactdetails")]
        public virtual void PatchEmailAddress()
        {
            string[] tagsOfScenario = new string[] {
                    "contactdetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch EmailAddress", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 113
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
                TechTalk.SpecFlow.Table table215 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table215.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table215.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table215.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table215.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 114
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table215, "Given ");
#line hidden
#line 120
 testRunner.When("I patch the following Contact With RandomEmailAddress:", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 121
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table216 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table216.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table216.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table216.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table216.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 122
 testRunner.And("the response body should contain:", ((string)(null)), table216, "And ");
#line hidden
#line 128
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 129
 testRunner.Then("there should be a record in the dss-contacts table with ContactId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch EmailAddress with invalid data")]
        [NUnit.Framework.CategoryAttribute("contactdetails")]
        public virtual void PatchEmailAddressWithInvalidData()
        {
            string[] tagsOfScenario = new string[] {
                    "contactdetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch EmailAddress with invalid data", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 133
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
                TechTalk.SpecFlow.Table table217 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table217.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table217.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table217.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table217.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 134
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table217, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table218 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table218.AddRow(new string[] {
                            "EmailAddress",
                            "customeratcustomer.com"});
#line 140
 testRunner.When("I patch the following Contact:", ((string)(null)), table218, "When ");
#line hidden
#line 143
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch new PreferredContactMethod - MobileNumber")]
        [NUnit.Framework.CategoryAttribute("contactdetails")]
        public virtual void PatchNewPreferredContactMethod_MobileNumber()
        {
            string[] tagsOfScenario = new string[] {
                    "contactdetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch new PreferredContactMethod - MobileNumber", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 146
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
                TechTalk.SpecFlow.Table table219 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table219.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table219.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table219.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table219.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 147
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table219, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table220 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table220.AddRow(new string[] {
                            "PreferredContactMethod",
                            "2"});
                table220.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
#line 153
 testRunner.When("I patch the following Contact:", ((string)(null)), table220, "When ");
#line hidden
#line 157
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table221 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table221.AddRow(new string[] {
                            "PreferredContactMethod",
                            "2"});
                table221.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table221.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table221.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
#line 158
 testRunner.And("the response body should contain:", ((string)(null)), table221, "And ");
#line hidden
#line 164
 testRunner.Given("I wait for 5 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 165
 testRunner.Then("there should be a record in the dss-contacts table with ContactId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
