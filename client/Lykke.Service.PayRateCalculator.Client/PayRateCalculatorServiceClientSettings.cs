using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.PayRateCalculator.Client 
{
    /// <summary>
    /// PayRateCalculator client settings.
    /// </summary>
    public class PayRateCalculatorServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
