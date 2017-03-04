﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Habitat.Website.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class WFFMFormsIntegrationFeature : Xunit.IClassFixture<WFFMFormsIntegrationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WFFM forms integration.feature"
#line hidden
        
        public WFFMFormsIntegrationFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WFFM forms integration", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void SetFixture(WFFMFormsIntegrationFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="WFFM forms integration_UC1_Verify MVC forms present in all Wide and Narrow column" +
            "s")]
        [Xunit.TraitAttribute("FeatureTitle", "WFFM forms integration")]
        [Xunit.TraitAttribute("Description", "WFFM forms integration_UC1_Verify MVC forms present in all Wide and Narrow column" +
            "s")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void WFFMFormsIntegration_UC1_VerifyMVCFormsPresentInAllWideAndNarrowColumns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WFFM forms integration_UC1_Verify MVC forms present in all Wide and Narrow column" +
                    "s", new string[] {
                        "Ready"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "AllowedControls"});
            table1.AddRow(new string[] {
                        "/sitecore/layout/Placeholder Settings/Project/Common/Columns/col-narrow-1",
                        "Mvc Form"});
            table1.AddRow(new string[] {
                        "/sitecore/layout/Placeholder Settings/Project/Common/Columns/col-narrow-2",
                        "Mvc Form"});
            table1.AddRow(new string[] {
                        "/sitecore/layout/Placeholder Settings/Project/Common/Columns/col-narrow-3",
                        "Mvc Form"});
            table1.AddRow(new string[] {
                        "/sitecore/layout/Placeholder Settings/Project/Common/Columns/col-narrow-4",
                        "Mvc Form"});
            table1.AddRow(new string[] {
                        "/sitecore/layout/Placeholder Settings/Project/Common/Columns/col-narrow-5",
                        "Mvc Form"});
            table1.AddRow(new string[] {
                        "/sitecore/layout/Placeholder Settings/Project/Common/Columns/col-narrow-6",
                        "Mvc Form"});
            table1.AddRow(new string[] {
                        "/sitecore/layout/Placeholder Settings/Project/Common/Columns/col-wide-1",
                        "Mvc Form"});
            table1.AddRow(new string[] {
                        "/sitecore/layout/Placeholder Settings/Project/Common/Columns/col-wide-2",
                        "Mvc Form"});
            table1.AddRow(new string[] {
                        "/sitecore/layout/Placeholder Settings/Project/Common/Columns/col-wide-3",
                        "Mvc Form"});
#line 6
 testRunner.Then("Items contain MVC controls", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="WFFM forms integration_UC2_Few webforms on one page")]
        [Xunit.TraitAttribute("FeatureTitle", "WFFM forms integration")]
        [Xunit.TraitAttribute("Description", "WFFM forms integration_UC2_Few webforms on one page")]
        [Xunit.TraitAttribute("Category", "OnlyManual")]
        public virtual void WFFMFormsIntegration_UC2_FewWebformsOnOnePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WFFM forms integration_UC2_Few webforms on one page", new string[] {
                        "OnlyManual"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("New Page was created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.And("Webfrom \'Get Our Newsletter\' was added to layout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("Webfrom \'Leave a message\' was added to layout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "FieldName",
                        "FieldValue"});
            table2.AddRow(new string[] {
                        "Get Our Newsletter",
                        "Is Ajax Mvc Form",
                        "0"});
            table2.AddRow(new string[] {
                        "Leave a message",
                        "Is Ajax Mvc Form",
                        "0"});
#line 25
 testRunner.And("Value set to item field", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "WebForm",
                        "FieldName",
                        "Field value"});
            table3.AddRow(new string[] {
                        "Get Our Newsletter",
                        "Email",
                        "kov@sitecore.net"});
#line 29
 testRunner.When("User inputs data to webForm", ((string)(null)), table3, "When ");
#line 32
 testRunner.Then("No form validation errors on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                WFFMFormsIntegrationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                WFFMFormsIntegrationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
