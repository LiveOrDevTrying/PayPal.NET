using PayPal.NET.Models.Requests;
using PayPal.NET.Models.Responses;
using System.Threading.Tasks;

namespace PayPal.NET
{
    public interface IServicesPaypal
    {
        Task<PaypalOrderResponse> CreatePaypalOrderAsync(PurchaseCreateRequest purchase);
        Task<PaypalOrderAuthResponse> CapturePaypalTransactionAsync(PurchaseCreateRequest purchase);
    }
}