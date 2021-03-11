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
    [NUnit.Framework.DescriptionAttribute("DigitalIdentityPatchV2")]
    public partial class DigitalIdentityPatchV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PatchV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/DigitalIdentity", "DigitalIdentityPatchV2", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Patch a valid Digital Identity")]
        [NUnit.Framework.CategoryAttribute("digitalidentity")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchAValidDigitalIdentity()
        {
            string[] tagsOfScenario = new string[] {
                    "digitalidentity",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch a valid Digital Identity", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table626 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table626.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table626.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 5
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table626, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table627 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table627.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table627.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table627.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table627.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table627.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 9
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table627, "Given ");
#line hidden
#line 16
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table628 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table628.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table628.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table628.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table628.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table628.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 17
 testRunner.And("the response body should contain:", ((string)(null)), table628, "And ");
#line hidden
                TechTalk.SpecFlow.Table table629 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table629.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table629.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table629.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table629.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 24
 testRunner.Given("I Post a digital identity with the following details V2:", ((string)(null)), table629, "Given ");
#line hidden
#line 30
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table630 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table630.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table630.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table630.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table630.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 31
 testRunner.And("the response body should contain:", ((string)(null)), table630, "And ");
#line hidden
                TechTalk.SpecFlow.Table table631 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table631.AddRow(new string[] {
                            "id_token",
                            "1234567910"});
                table631.AddRow(new string[] {
                            "IdentityStoreId",
                            "aaf18eff-bf70-4e04-82ba-a056258f0db8"});
                table631.AddRow(new string[] {
                            "LegacyIdentity",
                            "\"test\""});
#line 37
 testRunner.Given("I patch the following digitalIdentity By CustomerId V2:", ((string)(null)), table631, "Given ");
#line hidden
#line 42
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table632 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table632.AddRow(new string[] {
                            "id_token",
                            "1234567910"});
                table632.AddRow(new string[] {
                            "IdentityStoreId",
                            "aaf18eff-bf70-4e04-82ba-a056258f0db8"});
                table632.AddRow(new string[] {
                            "LegacyIdentity",
                            "\"test\""});
#line 43
 testRunner.And("the response body should contain:", ((string)(null)), table632, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch Digital Identity for Customer that does not exist")]
        [NUnit.Framework.CategoryAttribute("digitalidentity")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchDigitalIdentityForCustomerThatDoesNotExist()
        {
            string[] tagsOfScenario = new string[] {
                    "digitalidentity",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch Digital Identity for Customer that does not exist", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 50
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
                TechTalk.SpecFlow.Table table633 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table633.AddRow(new string[] {
                            "id_token",
                            "1234567910"});
                table633.AddRow(new string[] {
                            "IdentityStoreId",
                            "aaf18eff-bf70-4e04-82ba-a056258f0db8"});
                table633.AddRow(new string[] {
                            "LegacyIdentity",
                            "\"test\""});
                table633.AddRow(new string[] {
                            "CustomerId",
                            "e432d40a-28bc-4969-bda8-9c096c747b52"});
#line 51
 testRunner.Given("I patch the following digitalIdentity By CustomerId V2:", ((string)(null)), table633, "Given ");
#line hidden
#line 57
 testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch a Digital Identity for a customer that does not have a digital identity")]
        [NUnit.Framework.CategoryAttribute("digitalidentity")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchADigitalIdentityForACustomerThatDoesNotHaveADigitalIdentity()
        {
            string[] tagsOfScenario = new string[] {
                    "digitalidentity",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch a Digital Identity for a customer that does not have a digital identity", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 60
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
                TechTalk.SpecFlow.Table table634 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table634.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table634.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 61
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table634, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table635 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table635.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table635.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table635.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table635.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table635.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 65
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table635, "Given ");
#line hidden
#line 72
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table636 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table636.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table636.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table636.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table636.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table636.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 73
 testRunner.And("the response body should contain:", ((string)(null)), table636, "And ");
#line hidden
                TechTalk.SpecFlow.Table table637 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table637.AddRow(new string[] {
                            "id_token",
                            "1234567910"});
                table637.AddRow(new string[] {
                            "IdentityStoreId",
                            "aaf18eff-bf70-4e04-82ba-a056258f0db8"});
                table637.AddRow(new string[] {
                            "LegacyIdentity",
                            "\"test\""});
#line 80
 testRunner.Given("I patch the following digitalIdentity By CustomerId V2:", ((string)(null)), table637, "Given ");
#line hidden
#line 85
 testRunner.Then("there should be a 204 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch a valid Digital Identity By Digital IdentityId")]
        [NUnit.Framework.CategoryAttribute("digitalidentity")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchAValidDigitalIdentityByDigitalIdentityId()
        {
            string[] tagsOfScenario = new string[] {
                    "digitalidentity",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch a valid Digital Identity By Digital IdentityId", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 88
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
                TechTalk.SpecFlow.Table table638 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table638.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table638.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 89
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table638, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table639 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table639.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table639.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table639.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table639.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table639.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 93
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table639, "Given ");
#line hidden
#line 100
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table640 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table640.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table640.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table640.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table640.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table640.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 101
 testRunner.And("the response body should contain:", ((string)(null)), table640, "And ");
#line hidden
                TechTalk.SpecFlow.Table table641 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table641.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table641.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table641.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table641.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 108
 testRunner.Given("I Post a digital identity with the following details V2:", ((string)(null)), table641, "Given ");
#line hidden
#line 114
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table642 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table642.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table642.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table642.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table642.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 115
 testRunner.And("the response body should contain:", ((string)(null)), table642, "And ");
#line hidden
                TechTalk.SpecFlow.Table table643 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table643.AddRow(new string[] {
                            "id_token",
                            "1234567910"});
                table643.AddRow(new string[] {
                            "IdentityStoreId",
                            "aaf18eff-bf70-4e04-82ba-a056258f0db8"});
                table643.AddRow(new string[] {
                            "LegacyIdentity",
                            "\"test\""});
#line 121
 testRunner.Given("I patch the following digitalIdentity By DigitalIdentityId V2:", ((string)(null)), table643, "Given ");
#line hidden
#line 126
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 127
 testRunner.And("there should be a record in the dss-digitalidentities table Ignoring \'\' with Iden" +
                        "tityId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table644 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table644.AddRow(new string[] {
                            "id_token",
                            "1234567910"});
                table644.AddRow(new string[] {
                            "IdentityStoreId",
                            "aaf18eff-bf70-4e04-82ba-a056258f0db8"});
                table644.AddRow(new string[] {
                            "LegacyIdentity",
                            "\"test\""});
#line 128
 testRunner.And("the response body should contain:", ((string)(null)), table644, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch a Digital Identity By Digital IdentityId for a customer that does not have " +
            "a digital identity")]
        [NUnit.Framework.CategoryAttribute("digitalidentity")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void PatchADigitalIdentityByDigitalIdentityIdForACustomerThatDoesNotHaveADigitalIdentity()
        {
            string[] tagsOfScenario = new string[] {
                    "digitalidentity",
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch a Digital Identity By Digital IdentityId for a customer that does not have " +
                    "a digital identity", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 135
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
                TechTalk.SpecFlow.Table table645 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table645.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table645.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
#line 136
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table645, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table646 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table646.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table646.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table646.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table646.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table646.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 140
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table646, "Given ");
#line hidden
#line 147
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table647 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table647.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table647.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table647.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table647.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table647.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 148
 testRunner.And("the response body should contain:", ((string)(null)), table647, "And ");
#line hidden
                TechTalk.SpecFlow.Table table648 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table648.AddRow(new string[] {
                            "id_token",
                            "1234567910"});
                table648.AddRow(new string[] {
                            "IdentityStoreId",
                            "aaf18eff-bf70-4e04-82ba-a056258f0db8"});
                table648.AddRow(new string[] {
                            "LegacyIdentity",
                            "\"test\""});
#line 155
 testRunner.Given("I patch the following digitalIdentity By DigitalIdentityId V2:", ((string)(null)), table648, "Given ");
#line hidden
#line 160
 testRunner.Then("there should be a 204 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
