using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Responses
{
    public class PaypalOrderResponse : PaypalOrderResponseBase<PurchaseUnitResponse, Item, Amount>
    {
    }
}
