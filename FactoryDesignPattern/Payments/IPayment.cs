namespace FactoryDesignPattern.Payments
{
    public interface IPayment
    {
        string ProcessPayment(decimal amount);
    }
} 