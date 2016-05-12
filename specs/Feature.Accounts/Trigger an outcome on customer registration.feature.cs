﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "UI")]
    public partial class TriggerAnOutcomeOnCustomerRegistrationFeature : Xunit.IClassFixture<TriggerAnOutcomeOnCustomerRegistrationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Trigger an outcome on customer registration.feature"
#line hidden
        
        public TriggerAnOutcomeOnCustomerRegistrationFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Trigger an outcome on customer registration", null, ProgrammingLanguage.CSharp, new string[] {
                        "UI"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(TriggerAnOutcomeOnCustomerRegistrationFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Trigger an outcome on customer registration")]
        [Xunit.TraitAttribute("Description", "Trigger an outcome on customer registration_UC1_Empty registration outcome")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void TriggerAnOutcomeOnCustomerRegistration_UC1_EmptyRegistrationOutcome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Trigger an outcome on customer registration_UC1_Empty registration outcome", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table1.AddRow(new string[] {
                        "/sitecore/content/Habitat",
                        "RegisterOutcome",
                        ""});
#line 7
 testRunner.Given("Value set to item field", ((string)(null)), table1, "Given ");
#line 10
 testRunner.And("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table2.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 11
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table2, "When ");
#line 14
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "email",
                        "Outcome value"});
            table3.AddRow(new string[] {
                        "kov@sitecore.net",
                        ""});
#line 16
 testRunner.Then("User Outcome contains value", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Trigger an outcome on customer registration")]
        [Xunit.TraitAttribute("Description", "Trigger an outcome on customer registration_UC2_Custom registration outcome")]
        [Xunit.TraitAttribute("Category", "NeedUpdateStepWithRemovingDataFromAnalytic")]
        public virtual void TriggerAnOutcomeOnCustomerRegistration_UC2_CustomRegistrationOutcome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Trigger an outcome on customer registration_UC2_Custom registration outcome", new string[] {
                        "NeedUpdateStepWithRemovingDataFromAnalytic"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table4.AddRow(new string[] {
                        "/sitecore/content/Habitat",
                        "RegisterOutcome",
                        "Outcomes/Sales Lead"});
#line 24
 testRunner.Given("Outcome set to item field", ((string)(null)), table4, "Given ");
#line 27
 testRunner.And("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table5.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 28
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table5, "When ");
#line 31
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("Actor Ends user visit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("Wating for timeout 30 s", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "email",
                        "Outcome value"});
            table6.AddRow(new string[] {
                        "kov@sitecore.net",
                        "Sales Lead"});
#line 34
 testRunner.Then("User Outcome contains value", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                TriggerAnOutcomeOnCustomerRegistrationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TriggerAnOutcomeOnCustomerRegistrationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
