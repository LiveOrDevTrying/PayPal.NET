namespace PayPal.NET.Models.Paypal.Models
{
    public class BanContact
    {
        // The bank identification code (BIC).

        // Minimum length: 8.
        // Maximum length: 11.
        public string bic { get; set; }
        // The last digits of the card used to fund the Bancontact payment.

        // Minimum length: 4.
        // Maximum length: 4.
        // Pattern: [0-9]{ 4}.
        public string card_last_digits { get; set; }
        // The two-character ISO 3166-1 country code.
        public string country_code { get; set; }
        // The last characters of the IBAN used to pay.
        public string iban_last_chars { get; set; }
        // The name of the account holder associated with this payment method.
        public string name { get; set; }
    }
}
