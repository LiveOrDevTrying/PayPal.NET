using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Responses
{
    public class PaypalOrderBreakdownResponse : PaypalOrderResponseBase<PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>
    {
    }
}
