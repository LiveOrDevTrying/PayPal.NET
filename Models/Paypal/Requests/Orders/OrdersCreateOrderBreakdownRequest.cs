using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Requests.Orders
{
    public class OrdersCreateOrderBreakdownRequest : OrdersCreateOrderRequestBase<PurchaseUnitBreakdown, ItemBreakdown, AmountBreakdown>
    {
    }
}