using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Foerder.Domain;

namespace Foerder.Services
{

    public interface IAntragAufrechtStatusProvider
    {
        List<string> GetAntragAufrechtStatusList(string dataSourceKey);
    }

    public class AntragAufrechtStatusProvider: IAntragAufrechtStatusProvider
    {
        public List<string> GetAntragAufrechtStatusList(string dataSourceKey)
        {
            var key = "StatusAntragAufrecht_" + dataSourceKey;
            var value = ConfigurationManager.AppSettings[key];
            return value?.Split(';').ToList();
        }
    }

    public class FoerderantragService
    {
        private readonly IAntragAufrechtStatusProvider _antragAufrechtStatusProvider;

        public FoerderantragService(IAntragAufrechtStatusProvider antragAufrechtStatusProvider)
        {
            _antragAufrechtStatusProvider = antragAufrechtStatusProvider;
        }

        public bool IsAktiv(Foerderantrag antrag, DateTime stichtag)
        {
            if (antrag.Bewilligung?.Freigabe != null)
            {
                var freigabe = antrag.Bewilligung.Freigabe;
                return !freigabe.AufrechtBis.HasValue || (freigabe.AufrechtBis.Value >= stichtag);
            }

            var statusAntragAufrecht = _antragAufrechtStatusProvider.GetAntragAufrechtStatusList(antrag.DataSource);
            return (statusAntragAufrecht != null) &&
                    statusAntragAufrecht.Contains(antrag.Status ?? string.Empty);
        }
    }
}