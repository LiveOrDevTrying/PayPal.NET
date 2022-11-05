using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Responses.Orders
{
    public class OrdersCreateOrderBreakdownResponse : OrdersCreateOrderBase<PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>
    {
    }
}
