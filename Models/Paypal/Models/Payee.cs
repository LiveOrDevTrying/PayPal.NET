namespace PayPal.NET.Models.Paypal.Models
{
    public class Payee
    {
        // The email address of merchant.
        public string email_address { get; set; }
        // The encrypted PayPal account ID of the merchant.
        public string merchant_id { get; set; }
    }
}