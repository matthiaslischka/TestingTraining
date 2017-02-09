using System;
using FluentAssertions;
using Foerder.Domain;

namespace Foerder.Services.Spec.Drivers
{
    public class FoerderantragDriver
    {
        public Foerderantrag Foerderantrag { get; set; }
        public bool IsActive { get; set; }
        public DateTime StichtagGueltig { get; set; }
        public void CreateAntragOhneBewilligung()
        {
            Foerderantrag = new Foerderantrag {Bewilligung = null};
        }

        public void CreateAntragMitBewilligung(DateTime? befristungBis)
        {
            Foerderantrag = new Foerderantrag {Bewilligung = new Foerderbewilligung {BewilligtBis = befristungBis}};
        }

        public void CheckActive()
        {
            var foerderantragService = new FoerderantragService(new ConfigurationProvider());
            var anyDateTime = new DateTime(2017, 1, 1);
            IsActive = foerderantragService.IsAktiv(new Foerderantrag(), anyDateTime);
        }

        public void AssertIsActive(bool expectedIsActive)
        {
            IsActive.Should().Be(expectedIsActive);
        }

        public void SetAktivStichtag(DateTime stichtag)
        {
            StichtagGueltig = stichtag;
        }
    }
}