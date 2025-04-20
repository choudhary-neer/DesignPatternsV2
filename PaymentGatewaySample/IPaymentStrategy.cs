public interface IPaymentStrategy
{
    string PaymentType { get; }
    void Pay(decimal amount);
}
