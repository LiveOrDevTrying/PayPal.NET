namespace PayPal.NET.Models.Paypal.Models
{
    public class P24
    {
        // The two-character ISO 3166-1 country code.
        public string country_code { get; set; }
        // The email address of the account holder associated with this payment method.
        public string email { get; set; }
        // Friendly name of the payment scheme or bank used for the payment.

        // Minimum length: 1.
        // Maximum length: 2000.
        public string method_description { get; set; }
        // Numeric identifier of the payment scheme or bank used for the payment.

        // Minimum length: 1.
        // Maximum length: 300.
        public string method_id { get; set; }
        // The name of the account holder associated with this payment method.
        public string name { get; set; }
        // P24 generated payment description.

        // Minimum length: 1.
        // Maximum length: 2000.
        public string payment_descriptor { get; set; }
    }
}
