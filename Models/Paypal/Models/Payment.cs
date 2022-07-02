namespace PayPal.NET.Models.Paypal.Models
{
    public class Payment
    {
        /// <summary>
        /// An array of authorized payments for a purchase unit. A purchase unit can have zero or more authorized payments.
        /// </summary>
        public Authorization[] authorizations { get; set; }
        /// <summary>
        /// An array of captured payments for a purchase unit. A purchase unit can have zero or more captured payments.
        /// </summary>
        public Capture[] captures { get; set; }
        /// <summary>
        /// An array of refunds for a purchase unit. A purchase unit can have zero or more refunds.
        /// </summary>
        public Refund[] refunds { get; set; }
    }
}