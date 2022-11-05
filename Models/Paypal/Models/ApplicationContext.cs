namespace PayPal.NET.Models.Paypal.Models
{
    public class ApplicationContext
    {
        // The label that overrides the business name in the PayPal account on the PayPal site.

        // Minimum length: 1.
        // Maximum length: 127.
        public string brand_name { get; set; }
        // The URL where the customer is redirected after the customer cancels the payment.
        public string cancel_url { get; set; }
        // The type of landing page to show on the PayPal site for customer checkout.

        // The possible values are:

        // LOGIN.When the customer clicks PayPal Checkout, the customer is redirected to a page to log in to PayPal and approve the payment.
        // BILLING.When the customer clicks PayPal Checkout, the customer is redirected to a page to enter credit or debit card and other relevant billing information required to complete the purchase.
        // NO_PREFERENCE.When the customer clicks PayPal Checkout, the customer is redirected to either a page to log in to PayPal and approve the payment or to a page to enter credit or debit card and other relevant billing information required to complete the purchase, depending on their previous interaction with PayPal.
        
        // Minimum length: 1.
        // Maximum length: 13.
        // Pattern: ^[0-9A-Z_]+$.
        public string landing_page { get; set; } = "NO_PREFERENCE";
        // The BCP 47-formatted locale of pages that the PayPal payment experience shows.PayPal supports a five-character code. For example, da-DK, he-IL, id-ID, ja-JP, no-NO, pt-BR, ru-RU, sv-SE, th-TH, zh-CN, zh-HK, or zh-TW.

        // Minimum length: 2.
        // Maximum length: 10.
        // Pattern: ^[a-z]{2}(?:-[A-Z][a-z]{3})?(?:-(?:[A-Z]{2}))?$.
        public string locale { get; set; }
        // The customer and merchant payment preferences.
        public PaymentMethod payment_method { get; set; }
        public string return_url { get; set; }
        // The shipping preference:
        // Displays the shipping address to the customer.
        // Enables the customer to choose an address on the PayPal site.
        // Restricts the customer from changing the address during the payment-approval process.

        // The possible values are:

        // GET_FROM_FILE.Use the customer-provided shipping address on the PayPal site.
        // NO_SHIPPING.Redact the shipping address from the PayPal site. Recommended for digital goods.
        // SET_PROVIDED_ADDRESS.Use the merchant-provided address. The customer cannot change this address on the PayPal site.

        // Minimum length: 1.
        // Maximum length: 20.
        // Pattern: ^[0-9A-Z_]+$.
        public string shipping_preference { get; set; } = "NO_SHIPPING";
        // Provides additional details to process a payment using a payment_source that has been stored or is intended to be stored (also referred to as stored_credential or card-on-file).
        // Parameter compatibility:
        // payment_type = ONE_TIME is compatible only with payment_initiator = CUSTOMER.
        // usage = FIRST is compatible only with payment_initiator=CUSTOMER.
        // previous_transaction_reference or previous_network_transaction_reference is compatible only with payment_initiator=MERCHANT.
        // Only one of the parameters - previous_transaction_reference and previous_network_transaction_reference - can be present in the request.
        public StoredPaymentSource stored_payment_source { get; set; }
        // Configures a Continue or Pay Now checkout flow.

        // The possible values are:

        // CONTINUE.After you redirect the customer to the PayPal payment page, a Continue button appears. Use this option when the final amount is not known when the checkout flow is initiated and you want to redirect the customer to the merchant page without processing the payment.
        // PAY_NOW.After you redirect the customer to the PayPal payment page, a Pay Now button appears.Use this option when the final amount is known when the checkout is initiated and you want to process the payment immediately when the customer clicks Pay Now.

        // Minimum length: 1.
        // Maximum length: 8.
        // Pattern: ^[0-9A-Z_]+$.
        public string user_action { get; set; } = "PAY_NOW";
    }
}