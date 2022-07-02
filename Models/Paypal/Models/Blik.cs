namespace PayPal.NET.Models.Paypal.Models
{
    public class Blik
    {
        // The two-character ISO 3166-1 country code.
        public string country_code { get; set; }
        // The email address of the account holder associated with this payment method.

        // Minimum length: 3.
        // Maximum length: 254.
        // Pattern: ^.+@[^"\-].+$.
        public string email { get; set; }

        // The name of the account holder associated with this payment method.
        public string name { get; set; }
    }
}
