using Doppler.MercadoPagoApi.Payment.Models;
using System.Threading.Tasks;

namespace Doppler.MercadoPagoApi.Payment
{
    public interface IPaymentService
    {
        Task<PaymentResponseDto> CreatePaymentAsync(PaymentRequestDto paymentRequest);
    }
}
