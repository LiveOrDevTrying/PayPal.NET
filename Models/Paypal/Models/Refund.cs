using PayPal.NET.Models.Responses;

namespace PayPal.NET.Models.Paypal.Models
{
    public class Refund
    {
        /// <summary>
        /// The status of the refund.
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// The details of the refund status.
        /// </summary>
        public StatusDetailsRefund status_details { get; set; }
        /// <summary>
        /// The amount that the payee refunded to the payer.
        /// </summary>
        public Amount amount { get; set; }
        /// <summary>
        /// The PayPal-generated ID for the refund.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        public string invoice_id { get; set; }
        /// <summary>
        /// An array of related HATEOAS links.
        /// </summary>
        public Link[] links { get; set; }
        /// <summary>
        /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        public string note_to_payer { get; set; }
        /// <summary>
        /// The breakdown of the refund.
        /// </summary>
        public SellerPayableBreakdown seller_payable_breakdown { get; set; }
        /// <summary>
        /// The date and time when the transaction occurred, in Internet date and time format.
        ///
        /// Minimum length: 20.
        /// Maximum length: 64.
        /// Pattern: ^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T, t] ([0 - 1][0 - 9]|2[0-3]):[0-5][0-9]:([0 - 5][0 - 9]|60)([.][0 - 9]+)? ([Zz]|[+-][0-9]{2}:[0-9] { 2})$.
        /// </summary>
        public string create_time { get; set; }
        /// <summary>
        /// The date and time when the transaction was last updated, in Internet date and time format.
        ///
        /// Minimum length: 20.
        /// Maximum length: 64.
        /// Pattern: ^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T, t] ([0 - 1][0 - 9]|2[0-3]):[0-5][0-9]:([0 - 5][0 - 9]|60)([.][0 - 9]+)? ([Zz]|[+-][0-9]{2}:[0-9] { 2})$.
        /// </summary>
        public string update_time { get; set; }
    }
}