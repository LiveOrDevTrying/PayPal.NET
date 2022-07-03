using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Requests
{
    public class OrdersCapturePaymentForOrderRequest
    {
        public string payerID { get; set; }
        public string orderID { get; set; }
        // The payment source definition.
        public PaymentSourceCapture payment_source { get; set; }
    }
}
