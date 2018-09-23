using JetBrains.Annotations;

namespace Lykke.Service.PayRateCalculator.Client
{
    /// <summary>
    /// PayRateCalculator client interface.
    /// </summary>
    [PublicAPI]
    public interface IPayRateCalculatorClient
    {
        // Make your app's controller interfaces visible by adding corresponding properties here.
        // NO actual methods should be placed here (these go to controller interfaces, for example - IPayRateCalculatorApi).
        // ONLY properties for accessing controller interfaces are allowed.

        /// <summary>Application Api interface</summary>
        IPayRateCalculatorApi Api { get; }
    }
}
