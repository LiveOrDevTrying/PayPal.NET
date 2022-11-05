namespace PayPal.NET.Models.Paypal.Models
{
    public class NetworkTransactionReference
    {
        // Transaction reference id returned by the scheme.For Visa and Amex, this is the "Tran id" field in response.For MasterCard, this is the "BankNet reference id" field in response.For Discover, this is the "NRID" field in response.

        // Minimum length: 9.
        // Maximum length: 15.
        // Pattern: ^[a-zA-Z0-9]+$.
        public string id { get; set; }
        // Name of the card network through which the transaction was routed.

        // The possible values are:

        // VISA.Visa card.
        // MASTERCARD.Mastecard card.
        // DISCOVER.Discover card.
        // AMEX.American Express card.
        // SOLO.Solo debit card.
        // JCB.Japan Credit Bureau card.
        // STAR.Military Star card.
        // DELTA.Delta Airlines card.
        // SWITCH.Switch credit card.
        // MAESTRO.Maestro credit card.
        // CB_NATIONALE.Carte Bancaire (CB) credit card.
        // CONFIGOGA.Configoga credit card.
        // CONFIDIS.Confidis credit card.
        // ELECTRON.Visa Electron credit card.
        // CETELEM.Cetelem credit card.
        // CHINA_UNION_PAY.China union pay credit card.
        public string network { get; set; } = "VISA";
        // The date that the transaction was authorized by the scheme.For MasterCard, this is the "BankNet reference date" field in response.

        // Minimum length: 4.
        // Maximum length: 4.
        // Pattern: ^[0-9]+$.
        public string date { get; set; }
    }
}