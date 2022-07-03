using PayPal.NET.Models.Paypal.Models;
using PayPal.NET.Models.Responses;

namespace PayPal.NET.Models.Paypal.Requests
{
    public class PaymentsRefundCapturedPaymentResponse
    {
        /// <summary>
        /// The amount that the payee refunded to the payer.
        ///
        /// Read only.
        /// </summary>
        public Amount amount { get; set; }
        /// <summary>
        /// The date and time when the transaction occurred, in Internet date and time format.
        ///
        /// Read only.
        /// </summary>
        public string create_time { get; set; }
        /// <summary>
        /// The PayPal-generated ID for the refund.
        ///
        /// Read only.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        ///
        /// Read only.
        /// </summary>
        public string invoice_id { get; set; }
        /// <summary>
        /// An array of related HATEOAS links.
        ///
        /// Read only.
        /// </summary>
        public Link[] links { get; set; }
        /// <summary>
        /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
        ///
        /// Read only.
        /// </summary>
        public string note_to_payer { get; set; }
        /// <summary>
        /// The breakdown of the refund.
        ///
        /// Read only.
        /// </summary>
        public SellerPayableBreakdown seller_payable_breakdown { get; set; }
        /// <summary>
        /// The status of the refund.

        /// The possible values are:

        /// CANCELLED.The refund was cancelled.
        /// PENDING.The refund is pending.For more information, see status_details.reason.
        /// COMPLETED.The funds for this transaction were debited to the customer's account.
        ///
        /// Read only.
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// The details of the refund status.
        ///
        /// Read only.
        /// </summary>
        public StatusDetailsRefund status_details { get; set; }
        /// <summary>
        /// The date and time when the transaction was last updated, in Internet date and time format.
        ///
        /// Read only.
        /// </summary>
        public string update_time { get; set; }
    }
}
