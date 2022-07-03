using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Responses
{
    public class OrdersCapturePaymentForOrderBreakdownResponse : OrdersCapturePaymentForOrderBase<PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>
    {
    }
}
