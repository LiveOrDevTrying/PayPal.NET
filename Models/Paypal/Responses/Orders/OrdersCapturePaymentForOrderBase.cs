using PayPal.NET.Models.Paypal.Models;
using PayPal.NET.Models.Responses;
using System;

namespace PayPal.NET.Models.Paypal.Responses.Orders
{
    public abstract class OrdersCapturePaymentForOrderBase<PUR, I, A> where PUR : PurchaseUnitBaseResponse<I, A> where I : ItemBase<A> where A : Amount
    {
        /// <summary>
        /// The date and time when the transaction occurred, in Internet date and time format.

        ///Read only.
        ///Minimum length: 20.
        ///Maximum length: 64.
        ///Pattern: ^[0-9]{ 4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T, t] ([0 - 1][0 - 9]|2[0-3]):[0-5][0-9]:([0 - 5][0 - 9]|60)([.][0 - 9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$.
        /// </summary>
        public string create_time { get; set; }
        /// <summary>
        /// The ID of the order.

        /// Read only.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// The intent to either capture payment immediately or authorize a payment for an order after order creation.

        /// The possible values are:

        /// CAPTURE.The merchant intends to capture payment immediately after the customer makes a payment.
        /// AUTHORIZE.The merchant intends to authorize a payment and place funds on hold after the customer makes a payment.Authorized payments are best captured within three days of authorization but are available to capture for up to 29 days.After the three-day honor period, the original authorized payment expires and you must re-authorize the payment.You must make a separate request to capture payments on demand.This intent is not supported when you have more than one `purchase_unit` within your order
        /// </summary>
        public string intent { get; set; }
        /// <summary>
        /// An array of request-related HATEOAS links. To complete payer approval, use the approve link to redirect the payer. The API caller has 3 hours (default setting, this which can be changed by your account manager to 24/48/72 hours to accommodate your use case) from the time the order is created, to redirect your payer. Once redirected, the API caller has 3 hours for the payer to approve the order and either authorize or capture the order. If you are not using the PayPal JavaScript SDK to initiate PayPal Checkout (in context) ensure that you include application_context.return_url is specified or you will get "We're sorry, Things don't appear to be working at the moment" after the payer approves the payment.

        /// Read only.
        /// </summary>
        public Link[] links { get; set; }
        /// <summary>
        /// The customer who approves and pays for the order. The customer is also known as the payer.
        /// </summary>
        public Payer payer { get; set; }
        /// <summary>
        /// The payment source used to fund the paymen
        /// </summary>
        public PaymentSource payment_source { get; set; }
        /// <summary>
        /// The instruction to process an order.

        /// The possible values are:

        /// ORDER_COMPLETE_ON_PAYMENT_APPROVAL.API Caller expects the Order to be auto completed(i.e. for PayPal to authorize or capture depending on the intent) on completion of payer approval.This option is not relevant for payment_source that typically do not require a payer approval or interaction.This option is currently only available for the following payment_source: Alipay, Bancontact, BLIK, boletobancario, eps, giropay, iDEAL, Multibanco, MyBank, OXXO, P24, PayU, PUI, SafetyPay, SatisPay, Sofort, Trustly, TrustPay, Verkkopankki, WeChat Pay
        /// NO_INSTRUCTION.The API caller intends to authorize v2/checkout/orders/id/authorize or capture v2/checkout/orders/id/capture after the payer approves the order.

        /// Minimum length: 1.
        /// Maximum length: 36.
        /// Pattern: ^[0-9A-Z_]+$.
        /// </summary>
        public string payment_instruction { get; set; }
        /// <summary>
        /// An array of purchase units. Each purchase unit establishes a contract between a customer and merchant. Each purchase unit represents either a full or partial order that the customer intends to purchase from the merchant.
        /// </summary>
        public PUR[] purchase_units { get; set; }
        /// <summary>
        /// The order status.

        /// The possible values are:

        /// CREATED.The order was created with the specified context.
        /// SAVED.The order was saved and persisted.The order status continues to be in progress until a capture is made with final_capture = true for all purchase units within the order.
        /// APPROVED.The customer approved the payment through the PayPal wallet or another form of guest or unbranded payment.For example, a card, bank account, or so on.
        /// VOIDED.All purchase units in the order are voided.
        /// COMPLETED.The payment was authorized or the authorized payment was captured for the order.
        /// PAYER_ACTION_REQUIRED.The order requires an action from the payer (e.g. 3DS authentication). Redirect the payer to the "rel":"payer-action" HATEOAS link returned as part of the response prior to authorizing or capturing the order.

        /// Read only.
        /// Minimum length: 1.
        /// Maximum length: 255.
        /// Pattern: ^[0-9A-Z_]+$.
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// The date and time when the transaction was last updated, in Internet date and time format.

        /// Read only.
        /// Minimum length: 20.
        /// Maximum length: 64.
        /// Pattern: ^[0-9]{ 4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])[T, t] ([0 - 1][0 - 9]|2[0-3]):[0-5][0-9]:([0 - 5][0 - 9]|60)([.][0 - 9]+)?([Zz]|[+-][0-9]{2}:[0-9]{2})$.
        /// </summary>
        public string update_time { get; set; }
    }
}
