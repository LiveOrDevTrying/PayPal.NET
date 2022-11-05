namespace PayPal.NET.Models.Paypal.Models
{
    /// <summary>
    /// The detailed breakdown of the capture activity. This is not available for transactions that are in pending state.
    /// </summary>
    public class SellerProtectionBreakdown
    {
        /// <summary>
        /// The amount for this captured payment in the currency of the transaction.
        /// </summary>
        public Amount gross_amount { get; set; }
        /// <summary>
        /// The exchange rate that determines the amount that is credited to the payee's PayPal account. Returned when the currency of the captured payment is different from the currency of the PayPal account where the payee wants to credit the funds.

        /// Read only.
        /// </summary>
        public ExchangeRate exchange_rate { get; set; }
        /// <summary>
        /// The net amount that the payee receives for this captured payment in their PayPal account. The net amount is computed as gross_amount minus the paypal_fee minus the platform_fees.
        /// </summary>
        public Amount net_amount { get; set; }
        /// <summary>
        /// The applicable fee for this captured payment in the currency of the transaction.
        /// </summary>
        public Amount paypal_fee { get; set; }
        /// <summary>
        /// The applicable fee for this captured payment in the receivable currency. Returned only in cases the fee is charged in the receivable currency. Example 'CNY'.
        /// </summary>
        public Amount paypal_fee_in_receivable_currency { get; set; }
        /// <summary>
        /// An array of platform or partner fees, commissions, or brokerage fees that associated with the captured payment.
        /// </summary>
        public PlatformFee[] playform_fees { get; set; }
        /// <summary>
        /// The net amount that is credited to the payee's PayPal account. Returned only when the currency of the captured payment is different from the currency of the PayPal account where the payee wants to credit the funds. The amount is computed as net_amount times exchange_rate.
        /// </summary>
        public Amount receivable_amount { get; set; }
    }
}