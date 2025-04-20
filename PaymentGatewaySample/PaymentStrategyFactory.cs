public class PaymentStrategyFactory
{
    private readonly Dictionary<string, IPaymentStrategy> strategies;

    public PaymentStrategyFactory(IEnumerable<IPaymentStrategy> strategies)
    {
        this.strategies = strategies.ToDictionary(s => s.PaymentType, StringComparer.OrdinalIgnoreCase);
    }

    public IPaymentStrategy GetStrategy(string type)
    {
        if (strategies.TryGetValue(type, out var strategy))
            return strategy;

        throw new NotSupportedException($"Payment type '{type}' is not supported.");
    }
}
