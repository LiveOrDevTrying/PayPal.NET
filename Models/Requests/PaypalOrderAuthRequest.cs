namespace PayPal.NET.Models.Requests
{
    public class PaypalOrderAuthRequest
    {
        public string PayerID { get; set; }
        public string OrderID { get; set; }
        public string Order { get; set; }
    }
}
