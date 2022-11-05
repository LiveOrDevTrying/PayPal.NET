using PayPal.NET.Models.Paypal.Requests.Orders;
using PayPal.NET.Models.Paypal.Requests.Payments;
using PayPal.NET.Models.Paypal.Responses.Orders;
using PayPal.NET.Models.Paypal.Responses.Payments;
using System.Threading.Tasks;

namespace PayPal.NET
{
    public interface IServicesPaypal
    {
        Task<OrdersGetOrderResponse> OrdersGetOrderDetailsAsync(string id, string fields = null);
        Task<OrdersGetOrderBreakdownResponse> OrdersGetOrderDetailsBreakdownAsync(string id, string fields = null);
        Task<OrdersCreateOrderResponse> OrdersCreateOrderAsync(OrdersCreateOrderRequest purchase);
        Task<OrdersCreateOrderBreakdownResponse> OrdersCreateOrderBreakdownAsync(OrdersCreateOrderBreakdownRequest purchase);

        Task<OrdersCapturePaymentForOrderResponse> OrdersCapturePaymentForOrderAsync(OrdersCapturePaymentForOrderRequest request);
        Task<OrdersCapturePaymentForOrderBreakdownResponse> OrdersCapturePaymentForOrderBreakdownAsync(OrdersCapturePaymentForOrderRequest request);

        Task<PaymentsRefundCapturedPaymentResponse> PaymentsRefundCapturedPaymentAsync(string captureId, PaymentsRefundCapturedPaymentRequest request = null);
    }
}