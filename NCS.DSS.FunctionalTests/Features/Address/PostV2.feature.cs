﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace NCS.DSS.FunctionalTests.Features.Address
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PostV2")]
    [NUnit.Framework.CategoryAttribute("postV2")]
    public partial class PostV2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PostV2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PostV2", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV2"});
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
        public virtual void ScenarioTearDown()
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
#line 7
 #line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table1.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 8
 testRunner.Given("I post a Customer with the following details:", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post valid address")]
        public virtual void PostValidAddress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post valid address", null, ((string[])(null)));
#line 14
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "Address1",
                        "1"});
            table2.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table2.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table2.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table2.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table2.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table2.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table2.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table2.AddRow(new string[] {
                        "Latitude",
                        "52.40121"});
            table2.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table2.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table2.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 15
 testRunner.Given("I post an Address with the following details:", ((string)(null)), table2, "Given ");
#line 29
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Address1",
                        "1"});
            table3.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table3.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table3.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table3.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table3.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table3.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table3.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table3.AddRow(new string[] {
                        "Latitude",
                        "52.40121"});
            table3.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table3.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table3.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 30
  testRunner.And("the response body should contain:", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post valid address with Subcontractor Id")]
        [NUnit.Framework.CategoryAttribute("subcontractorId")]
        public virtual void PostValidAddressWithSubcontractorId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post valid address with Subcontractor Id", null, new string[] {
                        "subcontractorId"});
#line 47
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "Address1",
                        "1"});
            table4.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table4.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table4.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table4.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table4.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table4.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table4.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table4.AddRow(new string[] {
                        "Latitude",
                        "52.40121"});
            table4.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table4.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table4.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 48
 testRunner.Given("I post an Address with the following details:", ((string)(null)), table4, "Given ");
#line 62
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "Address1",
                        "1"});
            table5.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table5.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table5.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table5.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table5.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table5.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table5.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table5.AddRow(new string[] {
                        "Latitude",
                        "52.40121"});
            table5.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table5.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table5.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 63
  testRunner.And("the response body should contain:", ((string)(null)), table5, "And ");
#line 77
  testRunner.And("the response body should contain the SubContractorId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Address with only mandatory Fields")]
        public virtual void PostAddressWithOnlyMandatoryFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Address with only mandatory Fields", null, ((string[])(null)));
#line 80
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "Address1",
                        "1"});
            table6.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
#line 81
  testRunner.Given("I post an Address with the following details:", ((string)(null)), table6, "Given ");
#line 85
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "Address1",
                        "1"});
            table7.AddRow(new string[] {
                        "Address2",
                        "null"});
            table7.AddRow(new string[] {
                        "Address3",
                        "null"});
            table7.AddRow(new string[] {
                        "Address4",
                        "null"});
            table7.AddRow(new string[] {
                        "Address5",
                        "null"});
            table7.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table7.AddRow(new string[] {
                        "AlternativePostCode",
                        "null"});
            table7.AddRow(new string[] {
                        "Longitude",
                        "null"});
            table7.AddRow(new string[] {
                        "Latitude",
                        "null"});
            table7.AddRow(new string[] {
                        "EffectiveFrom",
                        "null"});
            table7.AddRow(new string[] {
                        "EffectiveTo",
                        "null"});
#line 86
  testRunner.And("the response body should contain:", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Address with maximum Field lengths")]
        public virtual void PostAddressWithMaximumFieldLengths()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Address with maximum Field lengths", null, ((string[])(null)));
#line 101
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "Address1",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table8.AddRow(new string[] {
                        "Address3",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table8.AddRow(new string[] {
                        "Address4",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table8.AddRow(new string[] {
                        "Address5",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table8.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table8.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table8.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table8.AddRow(new string[] {
                        "Latitude",
                        "52.40121"});
            table8.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table8.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table8.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 102
  testRunner.Given("I post an Address with the following details:", ((string)(null)), table8, "Given ");
#line 115
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "Address1",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table9.AddRow(new string[] {
                        "Address3",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table9.AddRow(new string[] {
                        "Address4",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table9.AddRow(new string[] {
                        "Address5",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghij"});
            table9.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table9.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table9.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table9.AddRow(new string[] {
                        "Latitude",
                        "52.40121"});
            table9.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table9.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table9.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 116
  testRunner.And("the response body should contain:", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Address with Address1 Field missing")]
        public virtual void PostAddressWithAddress1FieldMissing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Address with Address1 Field missing", null, ((string[])(null)));
#line 131
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table10.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table10.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table10.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table10.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table10.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table10.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table10.AddRow(new string[] {
                        "Latitude",
                        "52.40121"});
            table10.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table10.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table10.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 132
  testRunner.Given("I post an Address with the following details:", ((string)(null)), table10, "Given ");
#line 145
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Address with Address1 Field over character limit")]
        public virtual void PostAddressWithAddress1FieldOverCharacterLimit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Address with Address1 Field over character limit", null, ((string[])(null)));
#line 148
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "Address1",
                        "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijA" +
                            "bcdefghijAbcdefghijA"});
            table11.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table11.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table11.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table11.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table11.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table11.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table11.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table11.AddRow(new string[] {
                        "Latitude",
                        "52.40100"});
            table11.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table11.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table11.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 149
  testRunner.Given("I post an Address with the following details:", ((string)(null)), table11, "Given ");
#line 163
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Address with invalid Address1")]
        public virtual void PostAddressWithInvalidAddress1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Address with invalid Address1", null, ((string[])(null)));
#line 166
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "Address1",
                        "1#"});
            table12.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table12.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table12.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table12.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table12.AddRow(new string[] {
                        "PostCode",
                        "AA999AAA"});
            table12.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table12.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table12.AddRow(new string[] {
                        "Latitude",
                        "52.40100"});
            table12.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table12.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table12.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 167
  testRunner.Given("I post an Address with the following details:", ((string)(null)), table12, "Given ");
#line 181
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Address with PostCode Field missing")]
        public virtual void PostAddressWithPostCodeFieldMissing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Address with PostCode Field missing", null, ((string[])(null)));
#line 184
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "Address1",
                        "1"});
            table13.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table13.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table13.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table13.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table13.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table13.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table13.AddRow(new string[] {
                        "Latitude",
                        "52.40100"});
            table13.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table13.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table13.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 185
  testRunner.Given("I post an Address with the following details:", ((string)(null)), table13, "Given ");
#line 198
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Address with invalid PostCode")]
        public virtual void PostAddressWithInvalidPostCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Address with invalid PostCode", null, ((string[])(null)));
#line 201
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table14.AddRow(new string[] {
                        "Address1",
                        "1"});
            table14.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table14.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table14.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table14.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table14.AddRow(new string[] {
                        "PostCode",
                        "AA999AAAA"});
            table14.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table14.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table14.AddRow(new string[] {
                        "Latitude",
                        "52.40100"});
            table14.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table14.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table14.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 202
  testRunner.Given("I post an Address with the following details:", ((string)(null)), table14, "Given ");
#line 216
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Address with invalid Longitude")]
        public virtual void PostAddressWithInvalidLongitude()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Address with invalid Longitude", null, ((string[])(null)));
#line 219
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "Address1",
                        "1"});
            table15.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table15.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table15.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table15.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table15.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table15.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table15.AddRow(new string[] {
                        "Longitude",
                        "-981.50812"});
            table15.AddRow(new string[] {
                        "Latitude",
                        "52.40100"});
            table15.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table15.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table15.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 220
  testRunner.Given("I post an Address with the following details:", ((string)(null)), table15, "Given ");
#line 234
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Address with invalid Latitude")]
        public virtual void PostAddressWithInvalidLatitude()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Address with invalid Latitude", null, ((string[])(null)));
#line 238
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "Address1",
                        "1"});
            table16.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table16.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table16.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table16.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table16.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table16.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table16.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table16.AddRow(new string[] {
                        "Latitude",
                        "521.40100"});
            table16.AddRow(new string[] {
                        "EffectiveFrom",
                        "2018-06-19T09:01:00Z"});
            table16.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table16.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 239
  testRunner.Given("I post an Address with the following details:", ((string)(null)), table16, "Given ");
#line 253
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Valid Address with invalid EffectiveFrom date")]
        public virtual void PostValidAddressWithInvalidEffectiveFromDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Valid Address with invalid EffectiveFrom date", null, ((string[])(null)));
#line 256
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "Address1",
                        "1"});
            table17.AddRow(new string[] {
                        "Address2",
                        "The Street"});
            table17.AddRow(new string[] {
                        "Address3",
                        "The Town"});
            table17.AddRow(new string[] {
                        "Address4",
                        "The Area"});
            table17.AddRow(new string[] {
                        "Address5",
                        "The County"});
            table17.AddRow(new string[] {
                        "PostCode",
                        "NW11WN"});
            table17.AddRow(new string[] {
                        "AlternativePostCode",
                        "NW22WN"});
            table17.AddRow(new string[] {
                        "Longitude",
                        "-98.50812"});
            table17.AddRow(new string[] {
                        "Latitude",
                        "52.40100"});
            table17.AddRow(new string[] {
                        "EffectiveFrom",
                        "2033-06-19T09:01:00Z"});
            table17.AddRow(new string[] {
                        "EffectiveTo",
                        "2018-06-21T13:12:00Z"});
            table17.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-09-19T09:01:00Z"});
#line 257
  testRunner.Given("I post an Address with the following details:", ((string)(null)), table17, "Given ");
#line 271
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

