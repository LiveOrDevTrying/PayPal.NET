using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Requests
{
    public class PaypalOrderBreakdownRequest : PaypalOrderRequestBase<PurchaseUnitBreakdown, ItemBreakdown, AmountBreakdown>
    {
    }
}