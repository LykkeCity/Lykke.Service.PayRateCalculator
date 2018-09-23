using Lykke.Job.PayRateCalculator.Settings.JobSettings;
using Lykke.Job.PayRateCalculator.Settings.SlackNotifications;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Job.PayRateCalculator.Settings
{
    public class AppSettings
    {
        public PayRateCalculatorJobSettings PayRateCalculatorJob { get; set; }

        public SlackNotificationsSettings SlackNotifications { get; set; }

        [Optional]
        public MonitoringServiceClientSettings MonitoringServiceClient { get; set; }
    }
}
