namespace Doppler.MercadoPagoApi.Payment.Models
{
    public class PaymentRequestDto
    {
        public decimal TransactionAmount { get; set; }
        public Card Card { get; set; }
        public string Description { get; set; }
        public int Installments { get; set; }
        public string PaymentMethodId { get; set; }
        public PayerDto Payer { get; set; }
    }
}
