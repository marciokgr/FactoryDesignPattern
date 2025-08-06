using Microsoft.AspNetCore.Mvc;
using FactoryDesignPattern.Factory;

[ApiController]
[Route("api/pagamentos/[controller]")]
public class CreditCardController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] decimal amount)
    {
        var payment = PaymentFactory.CreatePayment("creditcard");
        var result = payment.ProcessPayment(amount);
        return Ok(result);
    }
} 