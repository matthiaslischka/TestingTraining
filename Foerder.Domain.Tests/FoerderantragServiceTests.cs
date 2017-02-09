using System;
using Foerder.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foerder.Domain.Tests
{
    [TestClass]
    public class FoerderantragServiceTests
    {
        private readonly FoerderantragService _target = new FoerderantragService();

        [TestMethod]
        public void IsActive_AntragOhneBewilligung_IsNotActive()
        {
            var foerderantragOhneBewilligung = new Foerderantrag {Bewilligung = null};
            var anyDateTime = new DateTime(2014,1,1);

            //-------------Act-------------
            var isActive = _target.IsAktiv(foerderantragOhneBewilligung, anyDateTime);

            Assert.IsFalse(isActive);
        }

        [TestMethod]
        public void IsActive_AntragOhneFreigabe_IsNotActive()
        {
            var foerderantragOhneFreigabe = new Foerderantrag {Bewilligung = new Foerderbewilligung {Freigabe = null}};
            var anyDateTime = new DateTime(2014, 1, 1);

            //-------------Act-------------
            var isActive = _target.IsAktiv(foerderantragOhneFreigabe, anyDateTime);
            
            Assert.IsFalse(isActive);
        }

        [TestMethod]
        public void IsActive_FreigabeAufrechtBisNull_IsNotActive()
        {
            var foerderantragOhneAufrechtBis = new Foerderantrag {Bewilligung =  new Foerderbewilligung {Freigabe = new Foerdermittelfreigabe {AufrechtBis = null} } };
            var anyDateTime = new DateTime(2014, 1, 1);

            //-------------Act-------------
            var isActive = _target.IsAktiv(foerderantragOhneAufrechtBis, anyDateTime);
            Assert.IsTrue(isActive);
        }
    }
}
