using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Foerder.Services.Tests.TestDataBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Foerder.Services.Tests
{
    [TestClass]
    public class FoerderantragServiceIsAktivTests
    {
        private const string ActiveState = "ActiveState";
        private const string InactiveState = "InactiveState";
        private const string DataSource = "SpecificDataSource";
        private FoerderantragService _service;
        private DateTime AnyStichtag { get; } = DateTime.Now;
        
        [TestInitialize]
        public void Initialize()
        {
            var antragAufrechtStatusProviderMock = new Mock<IAntragAufrechtStatusProvider>();

            antragAufrechtStatusProviderMock
                .Setup(provider => provider.GetAntragAufrechtStatusList(DataSource))
                .Returns(new List<string> {ActiveState});

            _service = new FoerderantragService(antragAufrechtStatusProviderMock.Object);
        }

        [TestMethod]
        public void WithoutBewilligungAndActiveState_ShouldBeActive()
        {
            var antrag = AFoerder.Antrag.WithoutBewilligung();
            antrag.DataSource = DataSource;
            antrag.Status = ActiveState;

            // Act
            var isAktiv = _service.IsAktiv(antrag, AnyStichtag);

            isAktiv.Should().BeTrue();
        }

        [TestMethod]
        public void WithoutBewilligungAndInactiveState_ShouldNotBeActive()
        {
            var antrag = AFoerder.Antrag.WithoutBewilligung();
            antrag.DataSource = DataSource;
            antrag.Status = InactiveState;

            // Act
            var isAktiv = _service.IsAktiv(antrag, AnyStichtag);

            isAktiv.Should().BeFalse();
        }

        [TestMethod]
        public void WithoutFreigabeAndActiveState_ShouldBeActive()
        {
            var antragOhneFreigabe = AFoerder.Antrag.WithoutFreigabe();
            antragOhneFreigabe.DataSource = DataSource;
            antragOhneFreigabe.Status = ActiveState;

            var isAktiv = _service.IsAktiv(antragOhneFreigabe, AnyStichtag);

            isAktiv.Should().BeTrue();
        }

        [TestMethod]
        public void WithoutFreigabeAndInactiveState_ShouldNotBeActive()
        {
            var antragOhneFreigabe = AFoerder.Antrag.WithoutFreigabe();
            antragOhneFreigabe.DataSource = DataSource;
            antragOhneFreigabe.Status = InactiveState;

            var isAktiv = _service.IsAktiv(antragOhneFreigabe, AnyStichtag);

            isAktiv.Should().BeFalse();
        }

        [TestMethod]
        public void WithBewilligungAndUnrestrictedFreigabe_ShouldBeAktiv()
        {
            var antrag = AFoerder.Antrag.WithUnrestrictedFreigabe();

            // Act
            var isAktiv = _service.IsAktiv(antrag, AnyStichtag);

            isAktiv.Should().BeTrue();
        }

        [TestMethod]
        public void AtADateBeforeTheFreigabeValidityDate_ShouldBeAktiv()
        {
            var aufrechtBis = new DateTime(2017, 3, 1);
            var antrag = AFoerder.Antrag.WithFreigabeUntil(aufrechtBis);

            // Act
            var isAktiv = _service.IsAktiv(antrag, stichtag:aufrechtBis.AddDays(-1));

            isAktiv.Should().BeTrue();
        }

        [TestMethod]
        public void AtTheFreigabeValidityDate_ShouldBeAktiv()
        {
            var aufrechtBis = new DateTime(2017, 3, 1);
            var antrag = AFoerder.Antrag.WithFreigabeUntil(aufrechtBis);

            // Act
            var isAktiv = _service.IsAktiv(antrag, stichtag: aufrechtBis);

            isAktiv.Should().BeTrue();
        }

        [TestMethod]
        public void AtADateAfterTheFreigabeValidityDate_ShouldBeInaktiv()
        {
            var aufrechtBis = new DateTime(2017, 3, 1);
            var antrag = AFoerder.Antrag.WithFreigabeUntil(aufrechtBis);

            // Act
            var isAktiv = _service.IsAktiv(antrag, stichtag: aufrechtBis.AddDays(+1));

            isAktiv.Should().BeFalse();
        }
    }
}
