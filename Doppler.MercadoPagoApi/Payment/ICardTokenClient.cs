using Doppler.MercadoPagoApi.Payment.Models;
using System.Threading.Tasks;

namespace Doppler.MercadoPagoApi.Payment
{
    public interface ICardTokenClient
    {
        Task<CardToken> CreateTokenAsync(Card card);
    }
}
