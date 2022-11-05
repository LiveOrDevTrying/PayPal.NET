namespace PayPal.NET.Models.Paypal.Models
{
    public class AmountBreakdown : Amount
    {
        // The breakdown of the amount.Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.
        public Breakdown breakdown { get; set; }
    }
}