using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();

        // Register services
        services.AddSingleton<IPaymentStrategy, CreditCardPayment>();
        services.AddSingleton<IPaymentStrategy, PayPalPayment>();
        services.AddSingleton<IPaymentStrategy, BitcoinPayment>();
        services.AddSingleton<PaymentStrategyFactory>();
        services.AddTransient<PaymentService>();

        var provider = services.BuildServiceProvider();
        var paymentService = provider.GetRequiredService<PaymentService>();

        paymentService.ProcessPayment("paypal", 150);
        paymentService.ProcessPayment("bitcoin", 250);
        paymentService.ProcessPayment("creditcard", 350);

        Console.ReadKey();
    }
}
