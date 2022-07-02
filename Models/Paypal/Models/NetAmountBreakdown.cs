namespace PayPal.NET.Models.Paypal.Models
{
    public class NetAmountBreakdown
    {
        /// <summary>
        /// The converted payable amount.
        ///
        /// Read only.
        /// </summary>
        public Amount converted_amount { get; set; }

        /// <summary>
        /// The exchange rate that determines the amount that was debited from the merchant's PayPal account.
        ///
        /// Read only.
        /// </summary>
        public ExchangeRate exchange_rate { get; set; }
        /// <summary>
        /// The net amount debited from the merchant's PayPal account.
        ///
        /// Read only.
        /// </summary>
        public Amount payable_amount { get; set; }
    }
}