using PayPal.NET.Models.Paypal.Requests;
using PayPal.NET.Models.Paypal.Responses;
using PayPal.NET.Models.Responses;
using System.Threading.Tasks;

namespace PayPal.NET
{
    public interface IServicesPaypal
    {
        Task<OrdersCreateOrderResponse> OrdersCreateOrderAsync(OrdersCreateOrderRequest purchase);
        Task<OrdersCreateOrderBreakdownResponse> OrdersCreateOrderBreakdownAsync(OrdersCreateOrderBreakdownRequest purchase);

        Task<OrdersCapturePaymentForOrderResponse> OrdersCapturePaymentForOrderAsync(OrdersCapturePaymentForOrderRequest request);
        Task<OrdersCapturePaymentForOrderBreakdownResponse> OrdersCapturePaymentForOrderBreakdownAsync(OrdersCapturePaymentForOrderRequest request);

        Task<PaymentsRefundCapturedPaymentResponse> PaymentsRefundCapturedPaymentAsync(string captureId, PaymentsRefundCapturedPaymentRequest request);
    }
}