namespace PayPal.NET.Models.Paypal.Models
{
    public class DisputeCategory
    {
        /// <summary>
        /// The condition that is covered for the transaction.

        /// The possible values are:

        /// ITEM_NOT_RECEIVED.The payer paid for an item that they did not receive.
        /// UNAUTHORIZED_TRANSACTION.The payer did not authorize the payment.
        /// </summary>
        public string dispute_category { get; set; }
    }
}