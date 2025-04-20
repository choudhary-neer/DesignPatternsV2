public class BitcoinPayment : IPaymentStrategy
{
    public string PaymentType => "bitcoin";

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using Bitcoin");
    }
}
