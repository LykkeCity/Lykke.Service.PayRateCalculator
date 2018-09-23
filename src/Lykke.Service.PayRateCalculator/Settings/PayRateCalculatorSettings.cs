using JetBrains.Annotations;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.PayRateCalculator.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class PayRateCalculatorSettings
    {
        public DbSettings Db { get; set; }
    }
}
