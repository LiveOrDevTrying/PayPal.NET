using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Requests
{
    public class OrdersCreateOrderBreakdownRequest : OrdersCreateOrderRequestBase<PurchaseUnitBreakdown, ItemBreakdown, AmountBreakdown>
    {
    }
}