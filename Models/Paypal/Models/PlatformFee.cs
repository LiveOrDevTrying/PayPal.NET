namespace PayPal.NET.Models.Paypal.Models
{
    public class PlatformFee
    {
        /// <summary>
        /// The fee for this transaction.
        /// </summary>
        public Amount amount { get; set; }
        /// <summary>
        /// The recipient of the fee for this transaction. If you omit this value, the default is the API caller.
        /// </summary>
        public Payee payee { get; set; }
    }
}