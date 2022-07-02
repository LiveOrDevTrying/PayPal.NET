using PayPal.NET.Models.Responses;

namespace PayPal.NET.Models.Paypal.Models
{
    public class Capture
    {
        /// <summary>
        /// The status of the captured payment.
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// The details of the captured payment status.
        /// </summary>
        public StatusDetails status_details { get; set; }
        /// <summary>
        /// The amount for this captured payment.
        /// </summary>
        public Amount amount { get; set; }
        /// <summary>
        /// The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in transaction and settlement reports.

        /// Maximum length: 127.
        /// </summary>
        public string custom_id { get; set; }
        /// <summary>
        /// The funds that are held on behalf of the merchant.
        /// </summary>
        public string dispersement_mode { get; set; }
        /// <summary>
        /// Indicates whether you can make additional captures against the authorized payment. Set to true if you do not intend to capture additional payments against the authorization. Set to false if you intend to capture additional payments against the authorization.
        /// </summary>
        public bool final_capture { get; set; }
        /// <summary>
        /// The PayPal-generated ID for the captured payment.
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
        /// An object that provides additional processor information for a direct credit card transaction.
        /// </summary>
        public ProcessorResponse processor_response { get; set; }
        /// <summary>
        /// The level of protection offered as defined by PayPal Seller Protection for Merchants.
        /// </summary>
        public SellerProtection seller_protection { get; set; }
        /// <summary>
        /// The detailed breakdown of the capture activity. This is not available for transactions that are in pending state.
        /// </summary>
        public SellerProtectionBreakdown seller_receivable_breakdown { get; set; }
        /// <summary>
        /// The date and time when the transaction occurred, in Internet date and time format.

        /// Minimum length: 20.
        /// Maximum length: 64.
        /// Pattern: ^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T, t] ([0 - 1][0 - 9]|2[0-3]):[0-5][0-9]:([0 - 5][0 - 9]|60)([.][0 - 9]+)? ([Zz]|[+-][0-9]{2}:[0-9] { 2})$.
        /// </summary>
        public string create_time { get; set; }
        /// <summary>
        /// The date and time when the transaction was last updated, in Internet date and time format.

        /// Minimum length: 20.
        /// Maximum length: 64.
        /// Pattern: ^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T, t] ([0 - 1][0 - 9]|2[0-3]):[0-5][0-9]:([0 - 5][0 - 9]|60)([.][0 - 9]+)? ([Zz]|[+-][0-9]{2}:[0-9] { 2})$.
        /// </summary>
        public string update_time { get; set; }
    }
}