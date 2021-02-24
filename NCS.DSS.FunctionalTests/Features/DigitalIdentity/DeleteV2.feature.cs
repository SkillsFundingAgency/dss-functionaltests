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
namespace NCS.DSS.FunctionalTests.Features.DigitalIdentity
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.6.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DigitalIdentityDeleteV2")]
    public partial class DigitalIdentityDeleteV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "DeleteV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/DigitalIdentity", "DigitalIdentityDeleteV2", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete valid DigitalIdentity Deletes the customers Digital Identity after cosmos " +
            "TTL")]
        [NUnit.Framework.CategoryAttribute("digitalidentity")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void DeleteValidDigitalIdentityDeletesTheCustomersDigitalIdentityAfterCosmosTTL()
        {
            string[] tagsOfScenario = new string[] {
                    "digitalidentity",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete valid DigitalIdentity Deletes the customers Digital Identity after cosmos " +
                    "TTL", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
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
                TechTalk.SpecFlow.Table table595 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table595.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table595.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 5
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table595, "Given ");
#line hidden
#line 9
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table596 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table596.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table596.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table596.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table596.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table596.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 10
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table596, "Given ");
#line hidden
#line 17
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table597 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table597.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table597.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table597.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table597.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table597.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 18
 testRunner.And("the response body should contain:", ((string)(null)), table597, "And ");
#line hidden
                TechTalk.SpecFlow.Table table598 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table598.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table598.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table598.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table598.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 25
 testRunner.Given("I Post a digital identity with the following details V2:", ((string)(null)), table598, "Given ");
#line hidden
#line 31
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table599 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table599.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table599.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table599.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table599.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 32
 testRunner.And("the response body should contain:", ((string)(null)), table599, "And ");
#line hidden
#line 38
 testRunner.Given("I Delete a Digital Identity V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 39
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.Given("I wait for 20 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 41
 testRunner.And("I get a DigitalIdentity by CustomerID V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.Then("there should be a 204 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete Digital Identity & Do not wait for TTL still retrieves Digital Identity")]
        [NUnit.Framework.CategoryAttribute("digitalidentity")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void DeleteDigitalIdentityDoNotWaitForTTLStillRetrievesDigitalIdentity()
        {
            string[] tagsOfScenario = new string[] {
                    "digitalidentity",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Digital Identity & Do not wait for TTL still retrieves Digital Identity", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 46
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
                TechTalk.SpecFlow.Table table600 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table600.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table600.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 47
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table600, "Given ");
#line hidden
#line 51
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table601 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table601.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table601.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table601.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table601.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table601.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 52
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table601, "Given ");
#line hidden
#line 59
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table602 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table602.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table602.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table602.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table602.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table602.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 60
 testRunner.And("the response body should contain:", ((string)(null)), table602, "And ");
#line hidden
                TechTalk.SpecFlow.Table table603 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table603.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table603.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table603.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table603.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 67
 testRunner.Given("I Post a digital identity with the following details V2:", ((string)(null)), table603, "Given ");
#line hidden
#line 73
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table604 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table604.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table604.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table604.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table604.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 74
 testRunner.And("the response body should contain:", ((string)(null)), table604, "And ");
#line hidden
#line 80
 testRunner.Given("I Delete a Digital Identity V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 81
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 82
 testRunner.Given("I get a DigitalIdentity by CustomerID V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 83
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete Digital identity for customer that does not have a digital identity")]
        [NUnit.Framework.CategoryAttribute("digitalidentity")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void DeleteDigitalIdentityForCustomerThatDoesNotHaveADigitalIdentity()
        {
            string[] tagsOfScenario = new string[] {
                    "digitalidentity",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Digital identity for customer that does not have a digital identity", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table605 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table605.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table605.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 88
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table605, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table606 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table606.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table606.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table606.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table606.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table606.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 92
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table606, "Given ");
#line hidden
#line 99
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table607 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table607.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table607.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table607.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table607.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table607.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 100
 testRunner.And("the response body should contain:", ((string)(null)), table607, "And ");
#line hidden
#line 107
 testRunner.Given("I Delete a Digital Identity V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 108
 testRunner.Then("there should be a 204 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
