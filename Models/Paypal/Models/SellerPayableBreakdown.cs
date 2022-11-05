namespace PayPal.NET.Models.Paypal.Models
{
    public class SellerPayableBreakdown
    {
        /// <summary>
        /// The amount that the payee refunded to the payer.
        ///
        /// Read only.
        /// </summary>
        public Amount gross_amount { get; set; }
        /// <summary>
        /// The net amount that the payee's account is debited in the transaction currency. The net amount is calculated as gross_amount minus paypal_fee minus platform_fees.
        ///
        /// Read only.
        /// </summary>
        public Amount net_amount { get; set; }
        /// <summary>
        /// An array of breakdown values for the net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the payee holds their funds.
        ///
        /// Read only.
        /// </summary>
        public NetAmountBreakdown net_amount_breakdown { get; set; }
        /// <summary>
        /// The net amount that the payee's account is debited in the receivable currency. Returned only in cases when the receivable currency is different from transaction currency. Example 'CNY'.
        ///
        /// Read only.
        /// </summary>
        public Amount net_amount_in_receivable_currency { get; set; }
        /// <summary>
        /// The PayPal fee that was refunded to the payer in the currency of the transaction. This fee might not match the PayPal fee that the payee paid when the payment was captured.
        ///
        /// Read only.
        /// </summary>
        public Amount paypal_fee { get; set; }
        /// <summary>
        /// The PayPal fee that was refunded to the payer in the receivable currency. Returned only in cases when the receivable currency is different from transaction currency. Example 'CNY'.
        ///
        /// Read only.
        /// </summary>
        public Amount paypal_fee_in_receivable_currency { get; set; }
        /// <summary>
        /// An array of platform or partner fees, commissions, or brokerage fees for the refund.
        /// </summary>
        public PlatformFee[] platform_fees { get; set; }
        /// <summary>
        /// The total amount refunded from the original capture to date. For example, if a payer makes a $100 purchase and was refunded $20 a week ago and was refunded $30 in this refund, the gross_amount is $30 for this refund and the total_refunded_amount is $50.
        /// </summary>
        public Amount total_refunded_amount { get; set; }
    }
}