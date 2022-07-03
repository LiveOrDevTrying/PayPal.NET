using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Responses
{
    public class OrdersCreateOrderBreakdownResponse : OrdersCreateOrderBase<PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>
    {
    }
}
