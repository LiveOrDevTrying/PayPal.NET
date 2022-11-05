namespace PayPal.NET.Models.Paypal.Models
{
    public abstract class PurchaseUnitBase<I, A> 
        where I : ItemBase<A>
        where A : Amount
    {
        /// <summary>
        /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.
        /// If you specify amount.breakdown, the amount equals item_total plus tax_total plus shipping plus handling plus insurance minus shipping_discount minus discount.
        /// The amount must be a positive number.For listed of supported currencies and decimal precision, see the PayPal REST APIs Currency Codes.
        /// </summary>
        public A amount { get; set; }
        /// <summary>
        /// The API caller-provided external ID.Used to reconcile client transactions with PayPal transactions.Appears in transaction and settlement reports but is not visible to the payer.
        ///
        /// Minimum length: 1.
        /// Maximum length: 127.
        /// </summary>
        public string custom_id { get; set; }
        /// <summary>
        /// The purchase description.The maximum length of the character is dependent on the type of characters used.The character length is specified assuming a US ASCII character.Depending on type of character; (e.g.accented character, Japanese characters) the number of characters that that can be specified as input might not equal the permissible max length.
        ///
        /// Minimum length: 1.
        /// Maximum length: 127.
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// The API caller-provided external invoice number for this order.Appears in both the payer's transaction history and the emails that the payer receives.
        ///
        /// Minimum length: 1.
        /// Maximum length: 127
        /// </summary>
        public string invoice_id { get; set; }
        /// <summary>
        /// An array of items that the customer purchases from the merchant.
        /// </summary>
        public I[] items { get; set; }
        /// <summary>
        /// The merchant who receives payment for this transaction.
        /// </summary>
        public Payee payee { get; set; }
        /// <summary>
        /// Any additional payment instructions to be consider during payment processing. This processing instruction is applicable for Capturing an order or Authorizing an Order.
        /// </summary>
        public PaymentInstruction payment_instruction { get; set; }
        /// <summary>
        /// The API caller-provided external ID for the purchase unit.Required for multiple purchase units when you must update the order through PATCH.If you omit this value and the order contains only one purchase unit, PayPal sets this value to default.
        /// Minimum length: 1.
        /// Maximum length: 256.
        /// </summary>
        public string reference_id { get; set; }
        /// <summary>
        /// The name and address of the person to whom to ship the items.
        /// </summary>
        public ShippingDetail shipping { get; set; }
        /// <summary>
        /// The soft descriptor is the dynamic text used to construct the statement descriptor that appears on a payer's card statement.
        /// If an Order is paid using the "PayPal Wallet", the statement descriptor will appear in following format on the payer's card statement: PAYPAL_prefix+(space)+merchant_descriptor+(space)+ soft_descriptor
        /// Note: The merchant descriptor is the descriptor of the merchant’s payment receiving preferences which can be seen by logging into the merchant account https://www.sandbox.paypal.com/businessprofile/settings/info/edit
        /// The PAYPAL prefix uses 8 characters.Only the first 22 characters will be displayed in the statement.
        
        /// For example, if:
        /// The PayPal prefix toggle is PAYPAL.
        /// The merchant descriptor in the profile is Janes Gift.
        /// The soft descriptor is 800-123-1234.
        /// Then, the statement descriptor on the card is PAYPAL Janes Gift 80.
        
        /// Minimum length: 1.
        /// Maximum length: 22.
        /// </summary>
        public string soft_descriptor { get; set; }
    }
}