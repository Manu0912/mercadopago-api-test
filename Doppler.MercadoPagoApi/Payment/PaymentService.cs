using Doppler.MercadoPagoApi.Payment.Models;
using MercadoPago.Client.Common;
using MercadoPago.Client.Payment;
using MercadoPago.Config;
using System.Threading.Tasks;

namespace Doppler.MercadoPagoApi.Payment
{
    public class PaymentService : IPaymentService
    {
        private readonly ICardTokenClient _cardTokenClient;

        public PaymentService(ICardTokenClient cardTokenClient)
        {
            _cardTokenClient = cardTokenClient;
        }

        public async Task<PaymentResponseDto> CreatePaymentAsync(PaymentRequestDto paymentRequestDto)
        {
            var cardToken = await _cardTokenClient.CreateTokenAsync(paymentRequestDto.Card);

            MercadoPagoConfig.AccessToken = "TEST-5802037317015635-042521-d9d005ad43ac9c35052037825722d007-1108854570";

            var paymentRequestCreated = new PaymentCreateRequest
            {
                TransactionAmount = paymentRequestDto.TransactionAmount,
                Token = cardToken.Id,
                Description = paymentRequestDto.Description,
                Installments = paymentRequestDto.Installments,
                PaymentMethodId = paymentRequestDto.PaymentMethodId,
                Payer = new PaymentPayerRequest
                {
                    Type = "customer",
                    Email = paymentRequestDto.Payer.Email
                },
            };

            var client = new PaymentClient();
            var payment = await client.CreateAsync(paymentRequestCreated);

            var response = new PaymentResponseDto(payment.Id, payment.Status, payment.StatusDetail);

            return response;
        }
    }
}
