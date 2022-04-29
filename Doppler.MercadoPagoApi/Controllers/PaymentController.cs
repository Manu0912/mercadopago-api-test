using Doppler.MercadoPagoApi.Payment;
using Doppler.MercadoPagoApi.Payment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Doppler.MercadoPagoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PaymentRequestDto paymentRequest)
        {
            //var cardTokenClient = new CardTokenClient();

            //var result = await cardTokenClient.CreateTokenAsync(card);

            //return Ok(result);

            var response = await _paymentService.CreatePaymentAsync(paymentRequest);

            return Ok(response);
        }
    }
}
