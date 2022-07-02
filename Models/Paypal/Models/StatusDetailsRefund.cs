namespace PayPal.NET.Models.Paypal.Models
{
    public class StatusDetailsRefund
    {
        /// <summary>
        /// The reason why the refund has the PENDING or FAILED status.

        /// The possible values are:

        /// ECHECK.The customer's account is funded through an eCheck, which has not yet cleared.
        /// Pattern: ^[A-Z_]+$.
        /// </summary>
        public string reason { get; set; }
    }
}