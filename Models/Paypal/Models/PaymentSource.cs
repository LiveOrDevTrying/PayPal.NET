namespace PayPal.NET.Models.Paypal.Models
{
    /// <summary>
    /// The payment source used to fund the payment.
    /// </summary>
    public class PaymentSource
    {
        /// <summary>
        /// Information used to pay Bancontact.
        /// </summary>
        public BanContact bancontact { get; set; }
        /// <summary>
        /// Information used to pay using BLIK.
        /// </summary>
        public Blik blik { get; set; }
        /// <summary>
        /// The payment card to use to fund a payment. Card can be a credit or debit card.
        /// </summary>
        public CardResponse card { get; set; }
        /// <summary>
        /// Information used to pay using eps.
        /// </summary>
        public EPS eps { get; set; }
        /// <summary>
        /// Information needed to pay using giropay.
        /// </summary>
        public GiroPay giropay { get; set; }
        /// <summary>
        /// Information used to pay using iDEAL.
        /// </summary>
        public Ideal ideal { get; set; }
        /// <summary>
        /// Information used to pay using MyBank.
        /// </summary>
        public MyBank mybank { get; set; }
        /// <summary>
        /// Information used to pay using P24(Przelewy24).
        /// </summary>
        public P24 p24 { get; set; }
        /// <summary>
        /// Information used to pay using Sofort.
        /// </summary>
        public SoFort sofort { get; set; }
        /// <summary>
        /// Information needed to pay using Trustly.
        /// </summary>
        public Trustly trustly { get; set; }
    }
}
