public class CreditCardPayment : IPaymentStrategy
{
    public string PaymentType => "creditcard";

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card");
    }
}
