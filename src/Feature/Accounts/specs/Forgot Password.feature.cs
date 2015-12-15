﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code


#pragma warning disable

namespace Habitat.Accounts.Specflow
{
  using TechTalk.SpecFlow;

  [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
  [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public partial class ForgotPasswordFeature : Xunit.IUseFixture<ForgotPasswordFeature.FixtureData>, System.IDisposable
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
      var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Forgot Password", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
    public virtual void Accounts_ForgotPassword_UC1_OpenPasswordResertPageOnLoginPage()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC1_Open Password Resert page on Login Page", new string[]
      {
        "Ready"
      });
#line 6
      this.ScenarioSetup(scenarioInfo);
#line 7
      testRunner.Given("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
      testRunner.When("Actor clicks Forgot your password? link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
      testRunner.Then("Password Reset title presents on ForgotPassword page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
      testRunner.And("Page URL ends on /ForgotPassword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table1 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Text on page"
      });
      table1.AddRow(new string[]
      {
        "The new password will be sent to your e-mail."
      });
#line 11
      testRunner.And("Forgot password form contains message to user", ((string)(null)), table1, "And ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
    [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC2_Open Password Resert page on Login form")]
    public virtual void Accounts_ForgotPassword_UC2_OpenPasswordResertPageOnLoginForm()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC2_Open Password Resert page on Login form", new string[]
      {
        "Ready"
      });
#line 17
      this.ScenarioSetup(scenarioInfo);
#line hidden
      var table2 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "ConfirmPassword"
      });
      table2.AddRow(new string[]
      {
        "kov10@sitecore.net",
        "k",
        "k"
      });
#line 18
      testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table2, "Given ");
#line 21
      testRunner.And("Login form is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
      testRunner.When("Actor clicks Forgot your password? link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
      testRunner.Then("Password Reset title presents on ForgotPassword page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
      testRunner.And("Page URL ends on /ForgotPassword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table3 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Text on page"
      });
      table3.AddRow(new string[]
      {
        "The new password will be sent to your e-mail."
      });
#line 25
      testRunner.And("Forgot password form contains message to user", ((string)(null)), table3, "And ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
    [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC3_Check required fields")]
    public virtual void Accounts_ForgotPassword_UC3_CheckRequiredFields()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC3_Check required fields", new string[]
      {
        "Ready"
      });
#line 32
      this.ScenarioSetup(scenarioInfo);
#line 33
      testRunner.Given("Habitat website is opened on Forgot Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
      testRunner.When("Actor clicks Reset password button on Reset Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
      var table4 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Required field error message"
      });
      table4.AddRow(new string[]
      {
        "E-mail is required"
      });
#line 35
      testRunner.Then("System shows following error message for the E-mail field", ((string)(null)), table4, "Then ");
#line 38
      testRunner.And("Page URL ends on /ForgotPassword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
    [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC4_Reset password for registered user")]
    public virtual void Accounts_ForgotPassword_UC4_ResetPasswordForRegisteredUser()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC4_Reset password for registered user", new string[]
      {
        "Ready"
      });
#line 42
      this.ScenarioSetup(scenarioInfo);
#line hidden
      var table5 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "ConfirmPassword"
      });
      table5.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k",
        "k"
      });
#line 43
      testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table5, "Given ");
#line 46
      testRunner.And("Habitat website is opened on Forgot Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table6 = new TechTalk.SpecFlow.Table(new string[]
      {
        "E-mail"
      });
      table6.AddRow(new string[]
      {
        "kov@sitecore.net"
      });
#line 47
      testRunner.When("Actor enters following data into E-mail field", ((string)(null)), table6, "When ");
#line 50
      testRunner.And("Actor clicks Reset password button on Reset Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table7 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Info message on Forgot Password page"
      });
      table7.AddRow(new string[]
      {
        "Your password has been reset."
      });
#line 51
      testRunner.Then("Systen shows following Alert message", ((string)(null)), table7, "Then ");
#line hidden
      var table8 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Button name"
      });
      table8.AddRow(new string[]
      {
        "Reset Password"
      });
#line 54
      testRunner.And("Then Following buttons is no longer present on Forgot Password page", ((string)(null)), table8, "And ");
#line hidden
      var table9 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Field name"
      });
      table9.AddRow(new string[]
      {
        "E-mail"
      });
#line 57
      testRunner.Then("Following fields is no longer present on Forgot Password page", ((string)(null)), table9, "Then ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
    [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC5_Invalid e-mail")]
    public virtual void Accounts_ForgotPassword_UC5_InvalidE_Mail()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC5_Invalid e-mail", new string[]
      {
        "Ready"
      });
#line 65
      this.ScenarioSetup(scenarioInfo);
#line 66
      testRunner.Given("Habitat website is opened on Forgot Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
      var table10 = new TechTalk.SpecFlow.Table(new string[]
      {
        "E-mail"
      });
      table10.AddRow(new string[]
      {
        "kov$sitecore.net"
      });
#line 67
      testRunner.When("Actor enters following data into E-mail field", ((string)(null)), table10, "When ");
#line 70
      testRunner.And("Actor clicks Reset password button on Reset Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table11 = new TechTalk.SpecFlow.Table(new string[]
      {
        "E-mail field error message"
      });
      table11.AddRow(new string[]
      {
        "Invalid email address"
      });
#line 71
      testRunner.Then("System shows following error message for the E-mail field", ((string)(null)), table11, "Then ");
#line 74
      testRunner.And("Page URL ends on /ForgotPassword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
    [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC6_Try to reset password for unknown user")]
    public virtual void Accounts_ForgotPassword_UC6_TryToResetPasswordForUnknownUser()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC6_Try to reset password for unknown user", new string[]
      {
        "NeedImplementation"
      });
#line 78
      this.ScenarioSetup(scenarioInfo);
#line hidden
      var table12 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "ConfirmPassword"
      });
      table12.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k",
        "k"
      });
#line 79
      testRunner.Given("User is registered in Habitat and logged out", ((string)(null)), table12, "Given ");
#line 82
      testRunner.And("Habitat website is opened on Forgot Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table13 = new TechTalk.SpecFlow.Table(new string[]
      {
        "E-mail"
      });
      table13.AddRow(new string[]
      {
        "kov1@sitecore.net"
      });
#line 83
      testRunner.When("Actor enters following data into E-mail field", ((string)(null)), table13, "When ");
#line 86
      testRunner.And("Actor clicks Reset password button on Reset Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table14 = new TechTalk.SpecFlow.Table(new string[]
      {
        "E-mail field error message"
      });
      table14.AddRow(new string[]
      {
        "User with specified email does not exist"
      });
#line 87
      testRunner.Then("System shows following error message for the E-mail field", ((string)(null)), table14, "Then ");
#line hidden
      this.ScenarioCleanup();
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class FixtureData : System.IDisposable
    {
      public FixtureData()
      {
        FeatureSetup();
      }

      void System.IDisposable.Dispose()
      {
        FeatureTearDown();
      }
    }
  }
}

#pragma warning restore

#endregion