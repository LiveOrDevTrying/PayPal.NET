namespace PayPal.NET.Models.Paypal.Models
{
    public class Amount
    {
        // The three-character ISO-4217 currency code that identifies the currency.

        // Minimum length: 3.
        // Maximum length: 3.
        public string currency_code { get; set; } = "USD";
        // The value, which might be:
        // An integer for currencies like JPY that are not typically fractional.
        // A decimal fraction for currencies like TND that are subdivided into thousandths.
        // For the required number of decimal places for a currency code, see Currency Codes.

        // Maximum length: 32.
        // Pattern: ^((-?[0-9]+)|(-?([0 - 9]+)?[.][0-9]+))$.
        public string value { get; set; }
    }
}