using PayPal.NET.Models.Paypal.Requests;
using PayPal.NET.Models.Paypal.Responses;
using PayPal.NET.Models.Responses;
using System.Threading.Tasks;

namespace PayPal.NET
{
    public interface IServicesPaypal
    {
        Task<PaypalOrderResponse> CreateOrderAsync(PaypalOrderRequest purchase);
        Task<PaypalOrderBreakdownResponse> CreateOrderBreakdownAsync(PaypalOrderBreakdownRequest purchase);

        Task<PaypalCaptureResponse> CapturePaymentForOrderAsync(string orderId, PaypalCaptureRequest request);
        Task<PaypalCaptureBreakdownResponse> CapturePaymentForOrderBreakdownAsync(string orderId, PaypalCaptureRequest request);
    }
}