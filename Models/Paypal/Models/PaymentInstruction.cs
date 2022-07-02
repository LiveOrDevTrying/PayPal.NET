namespace PayPal.NET.Models.Paypal.Models
{
    public class PaymentInstruction
    {
        // This field is only enabled for selected merchants/partners to use and provides the ability to trigger a specific pricing rate/plan for a payment transaction.The list of eligible 'payee_pricing_tier_id' would be provided to you by your Account Manager.Specifying values other than the one provided to you by your account manager would result in an error.

        // Minimum length: 1.
        // Maximum length: 20.
        public string payee_pricing_tier_id { get; set; }
        // FX identifier generated returned by PayPal to be used for payment processing in order to honor FX rate(for eligible integrations) to be used when amount is settled/received into the payee account.

        // Minimum length: 1.
        // Maximum length: 4000.
        public string payee_receivable_fx_rate_id { get; set; }
        // An array of various fees, commissions, tips, or donations.This field is only applicable to merchants that been enabled for PayPal Commerce Platform for Marketplaces and Platforms capability.
        public PlatformFee[] platform_fees { get; set; }
    }
}