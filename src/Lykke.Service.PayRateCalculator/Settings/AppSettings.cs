using JetBrains.Annotations;
using Lykke.Sdk.Settings;

namespace Lykke.Service.PayRateCalculator.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public PayRateCalculatorSettings PayRateCalculatorService { get; set; }
    }
}
