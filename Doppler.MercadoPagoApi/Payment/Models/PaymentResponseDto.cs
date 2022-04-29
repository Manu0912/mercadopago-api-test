namespace Doppler.MercadoPagoApi.Payment.Models
{
    public class PaymentResponseDto
    {
        public PaymentResponseDto(long? id, string status, string statusDetail)
        {
            Id = id;
            Status = status;
            StatusDetail = statusDetail;
        }

        public long? Id { get; set; }
        public string Status { get; set; }
        public string StatusDetail { get; set; }
    }
}
