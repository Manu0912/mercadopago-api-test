using Doppler.MercadoPagoApi.Payment.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Doppler.MercadoPagoApi.Payment
{
    public class CardTokenClient : ICardTokenClient
    {
        public async Task<CardToken> CreateTokenAsync(Card card)
        {
            var publicKey = "TEST-991cc2c1-bed3-44ae-b181-0b522b1e6eed";
            var url = $"https://api.mercadopago.com/v1/card_tokens?public_key={publicKey}";

            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(url, card);

                var result = await response.Content.ReadFromJsonAsync<CardToken>();

                return result;
            }
        }
    }
}
