using Lykke.HttpClientGenerator;

namespace Lykke.Service.PayRateCalculator.Client
{
    /// <summary>
    /// PayRateCalculator API aggregating interface.
    /// </summary>
    public class PayRateCalculatorClient : IPayRateCalculatorClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to PayRateCalculator Api.</summary>
        public IPayRateCalculatorApi Api { get; private set; }

        /// <summary>C-tor</summary>
        public PayRateCalculatorClient(IHttpClientGenerator httpClientGenerator)
        {
            Api = httpClientGenerator.Generate<IPayRateCalculatorApi>();
        }
    }
}
