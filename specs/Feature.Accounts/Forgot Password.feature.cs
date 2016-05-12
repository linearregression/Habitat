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
    public partial class ForgotPasswordFeature : Xunit.IClassFixture<ForgotPasswordFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Forgot Password.feature"
#line hidden
        
        public ForgotPasswordFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Forgot Password", null, ProgrammingLanguage.CSharp, new string[] {
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
        
        public virtual void SetFixture(ForgotPasswordFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC1_Open Password Resert page on Login Page")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_ForgotPassword_UC1_OpenPasswordResertPageOnLoginPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC1_Open Password Resert page on Login Page", new string[] {
                        "Ready"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("Actor clicks Forgot your password? link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("Password Reset title presents on ForgotPassword page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("Page URL ends on /Forgot-Password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table1.AddRow(new string[] {
                        "Reset password"});
#line 12
 testRunner.And("Following buttons present on Forgot Password page", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Text on page"});
            table2.AddRow(new string[] {
                        "The new password will be sent to your e-mail."});
#line 15
 testRunner.And("Forgot password form contains message to user", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC2_Open Password Resert page on Login form")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_ForgotPassword_UC2_OpenPasswordResertPageOnLoginForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC2_Open Password Resert page on Login form", new string[] {
                        "Ready"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table3.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 22
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table3, "Given ");
#line 25
 testRunner.And("Actor selects User icon on Navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("Actor clicks Forgot your password? button on User form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("Password Reset title presents on ForgotPassword page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.And("Page URL ends on /Forgot-Password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table4.AddRow(new string[] {
                        "Reset password"});
#line 29
 testRunner.And("Following buttons present on Forgot Password page", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Text on page"});
            table5.AddRow(new string[] {
                        "The new password will be sent to your e-mail."});
#line 32
 testRunner.And("Forgot password form contains message to user", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC3_Check required fields")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_ForgotPassword_UC3_CheckRequiredFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC3_Check required fields", new string[] {
                        "Ready"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
 testRunner.Given("Habitat website is opened on Forgot Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.When("Actor clicks Reset password button on Reset Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Required field error message"});
            table6.AddRow(new string[] {
                        "Please enter a value for E-mail"});
#line 40
 testRunner.Then("System shows following error message for the E-mail field", ((string)(null)), table6, "Then ");
#line 43
 testRunner.And("Page URL ends on /Forgot-Password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC4_Reset password for registered user")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_ForgotPassword_UC4_ResetPasswordForRegisteredUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC4_Reset password for registered user", new string[] {
                        "Ready"});
#line 47
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table7.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k",
                        "k"});
#line 48
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table7, "Given ");
#line 51
 testRunner.And("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("Habitat website is opened on Forgot Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail"});
            table8.AddRow(new string[] {
                        "kov1@sitecore.net"});
#line 53
 testRunner.When("Actor enters following data into E-mail field", ((string)(null)), table8, "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Info message on Forgot Password page"});
            table9.AddRow(new string[] {
                        "Your password has been reset."});
#line 56
 testRunner.And("Actor clicks Reset password button on Reset Password page", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table10.AddRow(new string[] {
                        "Reset Password"});
#line 60
 testRunner.Then("Following buttons is no longer present on Forgot Password page", ((string)(null)), table10, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field name"});
            table11.AddRow(new string[] {
                        "Email"});
#line 63
 testRunner.And("Following fields is no longer present on Forgot Password page", ((string)(null)), table11, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC5_Invalid e-mail")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_ForgotPassword_UC5_InvalidE_Mail()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC5_Invalid e-mail", new string[] {
                        "Ready"});
#line 71
this.ScenarioSetup(scenarioInfo);
#line 72
 testRunner.Given("Habitat website is opened on Forgot Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail"});
            table12.AddRow(new string[] {
                        "kov$sitecore.net"});
#line 73
 testRunner.When("Actor enters following data into E-mail field", ((string)(null)), table12, "When ");
#line 76
 testRunner.And("Actor clicks Reset password button on Reset Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail field error message"});
            table13.AddRow(new string[] {
                        "Please enter a valid email address"});
#line 77
 testRunner.Then("System shows following error message for the E-mail field", ((string)(null)), table13, "Then ");
#line 80
 testRunner.And("Page URL ends on /Forgot-Password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC6_Try to reset password for unknown user")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_ForgotPassword_UC6_TryToResetPasswordForUnknownUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC6_Try to reset password for unknown user", new string[] {
                        "Ready"});
#line 84
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table14.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 85
 testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table14, "Given ");
#line 88
 testRunner.And("Habitat website is opened on Forgot Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail"});
            table15.AddRow(new string[] {
                        "kov100@sitecore.net"});
#line 89
 testRunner.When("Actor enters following data into E-mail field", ((string)(null)), table15, "When ");
#line 92
 testRunner.And("Actor clicks Reset password button on Reset Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail field error message"});
            table16.AddRow(new string[] {
                        "User with specified e-mail address does not exist"});
#line 93
 testRunner.Then("System shows following error message for the E-mail field", ((string)(null)), table16, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ForgotPasswordFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ForgotPasswordFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
