using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Requests
{
    public class OrdersCreateOrderRequest : OrdersCreateOrderRequestBase<PurchaseUnit, Item, Amount>
    {
    }
}