public class PaymentService
{
    private readonly PaymentStrategyFactory factory;

    public PaymentService(PaymentStrategyFactory factory)
    {
        this.factory = factory;
    }

    public void ProcessPayment(string paymentType, decimal amount)
    {
        var strategy = factory.GetStrategy(paymentType);
        strategy.Pay(amount);
    }
}
