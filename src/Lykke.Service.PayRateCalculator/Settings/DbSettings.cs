using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.PayRateCalculator.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
