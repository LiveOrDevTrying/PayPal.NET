namespace PayPal.NET.Models.Paypal.Models
{
    public class SellerProtection
    {
        /// <summary>
        /// An array of conditions that are covered for the transaction.

        /// Read only.
        /// </summary>
        public DisputeCategory[] dispute_categories { get; set; }
        /// <summary>
        /// Indicates whether the transaction is eligible for seller protection. For information, see PayPal Seller Protection for Merchants.

        /// The possible values are:

        /// ELIGIBLE.Your PayPal balance remains intact if the customer claims that they did not receive an item or the account holder claims that they did not authorize the payment.
        /// PARTIALLY_ELIGIBLE.Your PayPal balance remains intact if the customer claims that they did not receive an item.
        /// NOT_ELIGIBLE.This transaction is not eligible for seller protection.

        /// Read only.
        /// </summary>
        public string status { get; set; }
    }
}