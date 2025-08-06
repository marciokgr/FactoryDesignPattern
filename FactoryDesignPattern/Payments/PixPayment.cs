namespace FactoryDesignPattern.Payments
{
    public class PixPayment : IPayment
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Pagamento de R${amount} realizado via Pix.";
        }
    }
} 