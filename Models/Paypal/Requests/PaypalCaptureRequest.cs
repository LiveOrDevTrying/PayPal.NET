using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Requests
{
    // Captures payment for an order.
    // To successfully capture payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request.
    // A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order respons
    public class PaypalCaptureRequest
    {
        public string payerID { get; set; }
        public string orderID { get; set; }
        // The payment source definition.
        public PaymentSourceCapture payment_source { get; set; }
    }
}
