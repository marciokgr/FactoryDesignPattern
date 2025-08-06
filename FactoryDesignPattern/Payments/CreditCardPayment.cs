namespace FactoryDesignPattern.Payments
{
    public class CreditCardPayment : IPayment
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Pagamento de R${amount} realizado via Cartão de Crédito.";
        }
    }
} 