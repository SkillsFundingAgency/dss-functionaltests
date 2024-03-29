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
                TechTalk.SpecFlow.Table table300 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table300.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table300.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
                table300.AddRow(new string[] {
                            "PriorityGroups",
                            "1,3"});
#line 5
 testRunner.Given("I post a Customer with the following details V3:", ((string)(null)), table300, "Given ");
#line hidden
#line 10
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table301 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table301.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table301.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table301.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table301.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table301.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 11
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table301, "Given ");
#line hidden
#line 18
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table302 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table302.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table302.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table302.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table302.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table302.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 19
 testRunner.And("the response body should contain:", ((string)(null)), table302, "And ");
#line hidden
                TechTalk.SpecFlow.Table table303 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table303.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table303.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table303.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table303.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 26
 testRunner.Given("I Post a digital identity with the following details V2:", ((string)(null)), table303, "Given ");
#line hidden
#line 32
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table304 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table304.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table304.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table304.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table304.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 33
 testRunner.And("the response body should contain:", ((string)(null)), table304, "And ");
#line hidden
#line 39
 testRunner.Given("I Delete a Digital Identity V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 40
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.Given("I wait for 20 Seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 42
 testRunner.And("I get a DigitalIdentity by CustomerID V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
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
                TechTalk.SpecFlow.Table table305 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table305.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table305.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
                table305.AddRow(new string[] {
                            "PriorityGroups",
                            "1,3"});
#line 47
 testRunner.Given("I post a Customer with the following details V3:", ((string)(null)), table305, "Given ");
#line hidden
#line 52
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table306 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table306.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table306.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table306.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table306.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table306.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 53
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table306, "Given ");
#line hidden
#line 60
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table307 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table307.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table307.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table307.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table307.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table307.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 61
 testRunner.And("the response body should contain:", ((string)(null)), table307, "And ");
#line hidden
                TechTalk.SpecFlow.Table table308 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table308.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table308.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table308.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table308.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 68
 testRunner.Given("I Post a digital identity with the following details V2:", ((string)(null)), table308, "Given ");
#line hidden
#line 74
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table309 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table309.AddRow(new string[] {
                            "IdentityStoreId",
                            "6973bf77-35f6-4989-a8ca-f1528d9c10a5"});
                table309.AddRow(new string[] {
                            "LegacyIdentity",
                            "07676 123456"});
                table309.AddRow(new string[] {
                            "id_token",
                            "08654 123456"});
                table309.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612+00:00"});
#line 75
 testRunner.And("the response body should contain:", ((string)(null)), table309, "And ");
#line hidden
#line 81
 testRunner.Given("I Delete a Digital Identity V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 82
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.Given("I get a DigitalIdentity by CustomerID V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 84
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
                TechTalk.SpecFlow.Table table310 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table310.AddRow(new string[] {
                            "GivenName",
                            "Bob"});
                table310.AddRow(new string[] {
                            "FamilyName",
                            "Customer"});
                table310.AddRow(new string[] {
                            "PriorityGroups",
                            "1,3"});
#line 88
 testRunner.Given("I post a Customer with the following details V3:", ((string)(null)), table310, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table311 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table311.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table311.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table311.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table311.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table311.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 93
 testRunner.Given("I post a Contact with the following details with unique email address:", ((string)(null)), table311, "Given ");
#line hidden
#line 100
 testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table312 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table312.AddRow(new string[] {
                            "PreferredContactMethod",
                            "1"});
                table312.AddRow(new string[] {
                            "MobileNumber",
                            "07676 123456"});
                table312.AddRow(new string[] {
                            "HomeNumber",
                            "08654 123456"});
                table312.AddRow(new string[] {
                            "AlternativeNumber",
                            "07564656766"});
                table312.AddRow(new string[] {
                            "LastModifiedDate",
                            "2018-08-20T11:46:02.4482612Z"});
#line 101
 testRunner.And("the response body should contain:", ((string)(null)), table312, "And ");
#line hidden
#line 108
 testRunner.Given("I Delete a Digital Identity V2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 109
 testRunner.Then("there should be a 204 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
