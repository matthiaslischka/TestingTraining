using System;
using Foerder.Domain;

namespace Foerder.Services
{
    public class FoerderantragService
    {
        private readonly IConfigurationProvider _configurationProvider;

        public FoerderantragService(IConfigurationProvider configurationProvider)
        {
            _configurationProvider = configurationProvider;
        }

        public bool IsAktiv(Foerderantrag antrag, DateTime stichtag)
        {
            if (antrag.Bewilligung != null && antrag.Bewilligung.Freigabe == null)
            {
                var befristungbBis = antrag.Bewilligung.BewilligtBis;
                return !befristungbBis.HasValue || (befristungbBis.Value >= stichtag);
            }

            var statusAntragAufrecht = _configurationProvider.GetStatusAntragAufrechtByDataSource(antrag.DataSource);
            return (statusAntragAufrecht != null) &&
                    statusAntragAufrecht.Contains(antrag.Status ?? string.Empty);
        }
    }
}