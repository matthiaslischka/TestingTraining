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
namespace Foerder.Services.Spec.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class FoerderantragOhneFreigabeFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FoerderantragOhneFreigabe.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("de-AT"), "FoerderantragOhneFreigabe", "\tUm bei einem Antrag ohne Freigabe den aktiv Status zu prüfen\r\n\tMöchte ich als Sa" +
                    "chbearbeiter\r\n\tDass Die Befristung und die Datenquelle herangezogen wird", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "FoerderantragOhneFreigabe")))
            {
                Foerder.Services.Spec.Features.FoerderantragOhneFreigabeFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Antrag ohne Bewilligung")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FoerderantragOhneFreigabe")]
        public virtual void AntragOhneBewilligung()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Antrag ohne Bewilligung", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("es existiert ein Antrag ohne Bewilligung", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Angenommen ");
#line 8
 testRunner.When("ich den aktiv Status prüfe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Wenn ");
#line 9
 testRunner.Then("ist der Status \'inaktiv\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void AntragMitBewilligung(string beschreibung, string befristung, string heute, string status, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Antrag mit Bewilligung", exampleTags);
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.Given(string.Format("es existiert ein Antrag mit Bewilligung und Befristung bis \'{0}\'", befristung), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Angenommen ");
#line 13
 testRunner.And(string.Format("heute ist der \'{0}\'", heute), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Und ");
#line 14
 testRunner.Then(string.Format("ist der Status \'{0}\'", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Antrag mit Bewilligung: Befristung endete gestern - inaktiv")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FoerderantragOhneFreigabe")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Befristung endete gestern - inaktiv")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Beschreibung", "Befristung endete gestern - inaktiv")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Befristung", "01.01.2017")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:heute", "02.01.2017")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "inaktiv")]
        public virtual void AntragMitBewilligung_BefristungEndeteGestern_Inaktiv()
        {
            this.AntragMitBewilligung("Befristung endete gestern - inaktiv", "01.01.2017", "02.01.2017", "inaktiv", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Antrag mit Bewilligung: Befristung endet morgen - aktiv")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FoerderantragOhneFreigabe")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Befristung endet morgen - aktiv")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Beschreibung", "Befristung endet morgen - aktiv")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Befristung", "03.01.2017")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:heute", "02.01.2017")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "aktiv")]
        public virtual void AntragMitBewilligung_BefristungEndetMorgen_Aktiv()
        {
            this.AntragMitBewilligung("Befristung endet morgen - aktiv", "03.01.2017", "02.01.2017", "aktiv", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Antrag mit Bewilligung: KEINE AHNUNG")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FoerderantragOhneFreigabe")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "KEINE AHNUNG")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Beschreibung", "KEINE AHNUNG")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Befristung", "02.01.2017")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:heute", "02.01.2017")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "inaktiv")]
        public virtual void AntragMitBewilligung_KEINEAHNUNG()
        {
            this.AntragMitBewilligung("KEINE AHNUNG", "02.01.2017", "02.01.2017", "inaktiv", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Antrag mit Bewilligung aus LgkPlus")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FoerderantragOhneFreigabe")]
        public virtual void AntragMitBewilligungAusLgkPlus()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Antrag mit Bewilligung aus LgkPlus", ((string[])(null)));
#line 22
 this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
