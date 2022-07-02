namespace PayPal.NET.Models.Paypal.Models
{
    public abstract class PurchaseUnitBaseResponse<I, A> : PurchaseUnitBase<I, A>
        where I : ItemBase<A>
        where A : Amount
    {
        /// <summary>
        /// The PayPal-generated ID for the purchase unit. This ID appears in both the payer's transaction history and the emails that the payer receives. In addition, this ID is available in transaction and settlement reports that merchants and API callers can use to reconcile transactions. This ID is only available when an order is saved by calling v2/checkout/orders/id/save.

        /// Minimum length: 1.
        /// Maximum length: 19.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The comprehensive history of payments for the purchase unit.

        /// Read only.
        /// </summary>
        public Payment[] payments { get; set; }
    }
}