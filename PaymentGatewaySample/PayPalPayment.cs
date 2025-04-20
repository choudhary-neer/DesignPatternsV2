public class PayPalPayment : IPaymentStrategy
{
    public string PaymentType => "paypal";

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal");
    }
}
