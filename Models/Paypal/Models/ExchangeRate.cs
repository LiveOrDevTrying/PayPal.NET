namespace PayPal.NET.Models.Paypal.Models
{
    public class ExchangeRate
    {
        /// <summary>
        /// The source currency from which to convert an amount.
        /// </summary>
        public string source_currency { get; set; }
        /// <summary>
        /// The target currency to which to convert an amount.
        /// </summary>
        public string target_currency { get; set; }
        /// <summary>
        /// The target currency amount. Equivalent to one unit of the source currency. Formatted as integer or decimal value with one to 15 digits to the right of the decimal point.
        /// </summary>
        public string value { get; set; }
    }
}