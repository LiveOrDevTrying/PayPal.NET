using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Responses.Orders
{
    public class OrdersGetOrderBreakdownResponse : OrdersGetOrderBase<PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>
    {
    }
}
