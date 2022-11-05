namespace PayPal.NET.Models.Paypal.Models
{
    public class EPS
    {
        /// <summary>
        /// The bank identification code (BIC).
        /// </summary>
        public string bic { get; set; }
        /// <summary>
        /// The two-character ISO 3166-1 country code.
        /// </summary>
        public string country_code { get; set; }
        /// <summary>
        /// The name of the account holder associated with this payment method.
        /// </summary>
        public string name { get; set; }
    }
}
