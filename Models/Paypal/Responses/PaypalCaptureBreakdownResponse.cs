using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Responses
{
    public class PaypalCaptureBreakdownResponse : PaypalCaptureResponseBase<PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>
    {
    }
}
