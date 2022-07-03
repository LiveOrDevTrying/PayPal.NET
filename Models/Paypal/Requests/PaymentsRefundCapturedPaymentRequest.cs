using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Requests
{
    public class PaymentsRefundCapturedPaymentRequest
    {
        /// <summary>
        /// The amount to refund. To refund a portion of the captured amount, specify an amount. If amount is not specified, an amount equal to captured amount - previous refunds is refunded. The amount must be a positive number and in the same currency as the one in which the payment was captured.
        /// </summary>
        public Amount amount { get; set; }
        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.

        /// Minimum length: 1.
        /// Maximum length: 127.
        /// Pattern: ^[0-9A-Za-z-]+$.
        /// </summary>
        public string invoice_id { get; set; }
        /// <summary>
        /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.

        /// Minimum length: 1.
        /// Maximum length: 255.
        /// Pattern: ^[0-9A-Za-z]+$.
        /// </summary>
        public string note_to_payer { get; set; }
    }
}
