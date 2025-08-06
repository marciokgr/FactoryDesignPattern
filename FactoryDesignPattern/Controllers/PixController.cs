using Microsoft.AspNetCore.Mvc;
using FactoryDesignPattern.Factory;

[ApiController]
[Route("api/pagamentos/[controller]")]
public class PixController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] decimal amount)
    {
        var payment = PaymentFactory.CreatePayment("pix");
        var result = payment.ProcessPayment(amount);
        return Ok(result);
    }
} 