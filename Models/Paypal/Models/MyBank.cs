namespace PayPal.NET.Models.Paypal.Models
{
    public class MyBank
    {
        // The bank identification code (BIC).
        public string bic { get; set; }
        // The two-character ISO 3166-1 country code.
        public string country_code { get; set; }
        // The last characters of the IBAN used to pay.
        public string iban_last_chars { get; set; }
        // The name of the account holder associated with this payment method.
        public string name { get; set; }
    }
}
