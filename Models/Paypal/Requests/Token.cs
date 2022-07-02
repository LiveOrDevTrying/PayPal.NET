namespace PayPal.NET.Models.Paypal.Requests
{
    public class Token
    {
        /// <summary>
        /// The PayPal-generated ID for the token.

        /// Minimum length: 1.
        /// Maximum length: 255.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// The tokenization method that generated the ID.

        /// The possible values are:

        /// BILLING_AGREEMENT.The PayPal billing agreement ID.References an approved recurring payment for goods or services.
        
        /// Minimum length: 1.
        /// Maximum length: 255.
        /// Pattern: ^[0-9A-Z_-]+$.
        /// </summary>
        public string type { get; set; }
    }
}
