using System;
using Foerder.Services.Spec.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Foerder.Services.Spec.Steps
{
    [Binding]
    public class FoerderantragOhneFreigabeSteps
    {
        private readonly FoerderantragDriver _foederFoerderantragDriver;

        public FoerderantragOhneFreigabeSteps(FoerderantragDriver foederFoerderantragDriver)
        {
            _foederFoerderantragDriver = foederFoerderantragDriver;
        }

        [Given(@"es existiert ein Antrag ohne Bewilligung")]
        public void AngenommenEsExistiertEinAntragOhneBewilligung()
        {
            _foederFoerderantragDriver.CreateAntragOhneBewilligung();
        }

        [When(@"ich den aktiv Status prüfe")]
        public void WennIchDenAktivStatusPrufe()
        {
            _foederFoerderantragDriver.CheckActive();
        }

        [Then(@"ist der Status '(.*)'")]
        public void DannIstDerStatus(bool status)
        {
            //bool isActive =  GetIsActive(status);
            _foederFoerderantragDriver.AssertIsActive(status);
        }

        [Given(@"es existiert ein Antrag mit Bewilligung und Befristung bis '(.*)'")]
        public void AngenommenEsExistiertEinAntragMitBewilligungUndBefristungBis(DateTime befristungBis)
        {
            _foederFoerderantragDriver.CreateAntragMitBewilligung(befristungBis);
        }

        [Given(@"heute ist der '(.*)'")]
        public void AngenommenHeuteIstDer(DateTime stichtag)
        {
            _foederFoerderantragDriver.SetAktivStichtag(stichtag);
        }


    }

    [Binding]
    public class StepArgumentTransformation
    {
        [StepArgumentTransformation()]
        public bool StringToBool(string value)
        {
            switch (value)
            {
                case "aktiv":
                    return true;
                case "inaktiv":
                    return false;
                default:
                    throw new ArgumentException();
            }
        }
    }
}