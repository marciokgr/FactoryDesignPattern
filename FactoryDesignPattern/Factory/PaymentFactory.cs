using FactoryDesignPattern.Payments;

namespace FactoryDesignPattern.Factory
{
    public static class PaymentFactory
    {
        public static IPayment CreatePayment(string paymentType)
        {
            return paymentType.ToLower() switch
            {
                "pix" => new PixPayment(),
                "creditcard" => new CreditCardPayment(),
                _ => throw new ArgumentException("Tipo de pagamento inválido")
            };
        }
    }
} 