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
namespace NCS.DSS.FunctionalTests.Features.Diversity
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DiversityV2_Get")]
    [NUnit.Framework.CategoryAttribute("postV2")]
    [NUnit.Framework.CategoryAttribute("getV2")]
    public partial class DiversityV2_GetFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DiversityV2_Get.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DiversityV2_Get", null, ProgrammingLanguage.CSharp, new string[] {
                        "postV2",
                        "getV2"});
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
#line 5
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table1.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 6
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table2.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 10
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table2, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Diversity Details by ID")]
        [NUnit.Framework.CategoryAttribute("diversitydetails")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void GetDiversityDetailsByID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Diversity Details by ID", null, new string[] {
                        "diversitydetails",
                        "smoke"});
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "ConsentToCollectLLDDHealth",
                        "true"});
            table3.AddRow(new string[] {
                        "LearningDifficultyOrDisabilityDeclaration",
                        "1"});
            table3.AddRow(new string[] {
                        "PrimaryLearningDifficultyOrDisability",
                        "4"});
            table3.AddRow(new string[] {
                        "SecondaryLearningDifficultyOrDisability",
                        "5"});
            table3.AddRow(new string[] {
                        "DateAndTimeLLDDHealthConsentCollected",
                        "2018-06-25T11:21:00Z"});
            table3.AddRow(new string[] {
                        "ConsentToCollectEthnicity",
                        "true"});
            table3.AddRow(new string[] {
                        "Ethnicity",
                        "32"});
            table3.AddRow(new string[] {
                        "DateAndTimeEthnicityCollected",
                        "2018-06-25T11:22:00Z"});
#line 19
 testRunner.Given("I post a Diversity Details record with the following details:", ((string)(null)), table3, "Given ");
#line 29
 testRunner.When("I get a Diversity Details by ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "ConsentToCollectLLDDHealth",
                        "true"});
            table4.AddRow(new string[] {
                        "LearningDifficultyOrDisabilityDeclaration",
                        "1"});
            table4.AddRow(new string[] {
                        "PrimaryLearningDifficultyOrDisability",
                        "4"});
            table4.AddRow(new string[] {
                        "SecondaryLearningDifficultyOrDisability",
                        "5"});
            table4.AddRow(new string[] {
                        "DateAndTimeLLDDHealthConsentCollected",
                        "2018-06-25T11:21:00Z"});
            table4.AddRow(new string[] {
                        "ConsentToCollectEthnicity",
                        "true"});
            table4.AddRow(new string[] {
                        "Ethnicity",
                        "32"});
            table4.AddRow(new string[] {
                        "DateAndTimeEthnicityCollected",
                        "2018-06-25T11:22:00Z"});
#line 31
  testRunner.And("the response body should contain:", ((string)(null)), table4, "And ");
#line 41
 testRunner.And("the response body should not contain the \"CreatedBy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("the date field LastModifiedDate should hold a recent value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("the response body should have LastModifiedBy with value 9000000001", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get All Diversity Details records where 1 exists")]
        [NUnit.Framework.CategoryAttribute("LearningProgression")]
        public virtual void GetAllDiversityDetailsRecordsWhere1Exists()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get All Diversity Details records where 1 exists", null, new string[] {
                        "LearningProgression"});
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "ConsentToCollectLLDDHealth",
                        "false"});
            table5.AddRow(new string[] {
                        "LearningDifficultyOrDisabilityDeclaration",
                        "1"});
            table5.AddRow(new string[] {
                        "PrimaryLearningDifficultyOrDisability",
                        "4"});
            table5.AddRow(new string[] {
                        "SecondaryLearningDifficultyOrDisability",
                        "5"});
            table5.AddRow(new string[] {
                        "DateAndTimeLLDDHealthConsentCollected",
                        "2018-06-25T11:21:00Z"});
            table5.AddRow(new string[] {
                        "ConsentToCollectEthnicity",
                        "false"});
            table5.AddRow(new string[] {
                        "Ethnicity",
                        "32"});
            table5.AddRow(new string[] {
                        "DateAndTimeEthnicityCollected",
                        "2018-06-25T11:22:00Z"});
#line 48
 testRunner.Given("I post a Diversity Details record with the following details:", ((string)(null)), table5, "Given ");
#line 58
 testRunner.When("I get all Diversity Details records for a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.And("the response should contain 1 document(s)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "ConsentToCollectLLDDHealth",
                        "False"});
            table6.AddRow(new string[] {
                        "LearningDifficultyOrDisabilityDeclaration",
                        "1"});
            table6.AddRow(new string[] {
                        "PrimaryLearningDifficultyOrDisability",
                        "4"});
            table6.AddRow(new string[] {
                        "SecondaryLearningDifficultyOrDisability",
                        "5"});
            table6.AddRow(new string[] {
                        "DateAndTimeLLDDHealthConsentCollected",
                        "2018-06-25T11:21:00Z"});
            table6.AddRow(new string[] {
                        "ConsentToCollectEthnicity",
                        "False"});
            table6.AddRow(new string[] {
                        "Ethnicity",
                        "32"});
            table6.AddRow(new string[] {
                        "DateAndTimeEthnicityCollected",
                        "2018-06-25T11:22:00Z"});
#line 61
 testRunner.And("the response body should incorporate a document with the following details:", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Diversity Details by invalid ID")]
        [NUnit.Framework.CategoryAttribute("LearningProgression")]
        public virtual void GetDiversityDetailsByInvalidID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Diversity Details by invalid ID", null, new string[] {
                        "LearningProgression"});
#line 78
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "ConsentToCollectLLDDHealth",
                        "true"});
            table7.AddRow(new string[] {
                        "LearningDifficultyOrDisabilityDeclaration",
                        "1"});
            table7.AddRow(new string[] {
                        "PrimaryLearningDifficultyOrDisability",
                        "4"});
            table7.AddRow(new string[] {
                        "SecondaryLearningDifficultyOrDisability",
                        "5"});
            table7.AddRow(new string[] {
                        "DateAndTimeLDDHealthConsentCollected",
                        "2018-06-25T11:21:00Z"});
            table7.AddRow(new string[] {
                        "ConsentToCollectEthnicity",
                        "true"});
            table7.AddRow(new string[] {
                        "EthnicityID",
                        "32"});
            table7.AddRow(new string[] {
                        "DateAndTimeEthnicityCollected",
                        "2018-06-25T11:22:00Z"});
#line 79
 testRunner.Given("I post a Diversity Details record with the following details:", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table8.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 89
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table8, "And ");
#line 93
 testRunner.When("I get a Diversity Details by ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 //testRunner.Then("there should be a 404 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
 testRunner.Then("there should be a 204 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get All Diversity Details records where none exist")]
        [NUnit.Framework.CategoryAttribute("LearningProgression")]
        public virtual void GetAllDiversityDetailsRecordsWhereNoneExist()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get All Diversity Details records where none exist", null, new string[] {
                        "LearningProgression"});
#line 97
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 113
 testRunner.When("I get all Diversity Details records for a customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
 //testRunner.Then("there should be a 404 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
 testRunner.Then("there should be a 204 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

