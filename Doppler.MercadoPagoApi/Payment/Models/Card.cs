namespace Doppler.MercadoPagoApi.Payment.Models
{
    public class Card
    {
        public string CardNumber { get; set; }
        public CardHolder Cardholder { get; set; }
        public string ExpirationYear { get; set; }
        public string ExpirationMonth { get; set; }
        public string SecurityCode { get; set; }
    }

    public class CardHolder
    {
        public IdentificationDto Identification { get; set; }
        public string Name { get; set; }
    }
}
