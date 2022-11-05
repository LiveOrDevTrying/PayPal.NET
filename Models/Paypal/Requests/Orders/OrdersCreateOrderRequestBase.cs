using PayPal.NET.Models.Paypal.Models;

namespace PayPal.NET.Models.Paypal.Requests.Orders
{
    public abstract class OrdersCreateOrderRequestBase<PU, I, A>
        where PU : PurchaseUnitBase<I, A>
        where I : ItemBase<A>
        where A : Amount
    {
        // The intent to either capture payment immediately or authorize a payment for an order after order creation.

        // The possible values are:

        // CAPTURE.The merchant intends to capture payment immediately after the customer makes a payment.
        // AUTHORIZE.The merchant intends to authorize a payment and place funds on hold after the customer makes a payment.Authorized payments are best captured within three days of authorization but are available to capture for up to 29 days.After the three-day honor period, the original authorized payment expires and you must re-authorize the payment.You must make a separate request to capture payments on demand.This intent is not supported when you have more than one `purchase_unit` within your order.
        public string intent { get; set; } = "CAPTURE";
        // An array of purchase units.Each purchase unit establishes a contract between a payer and the payee.Each purchase unit represents either a full or partial order that the payer intends to purchase from the payee.
        public PU[] purchase_units { get; set; }
        // Customize the payer experience during the approval process for the payment with PayPal.
        public ApplicationContext application_context { get; set; }
        // The customer who approves and pays for the order. The customer is also known as the payer.
        public Payer payer { get; set; }
        // The instruction to process an order.

        // The possible values are:

        // ORDER_COMPLETE_ON_PAYMENT_APPROVAL.API Caller expects the Order to be auto completed (i.e. for PayPal to authorize or capture depending on the intent) on completion of payer approval.This option is not relevant for payment_source that typically do not require a payer approval or interaction.This option is currently only available for the following payment_source: Alipay, Bancontact, BLIK, boletobancario, eps, giropay, iDEAL, Multibanco, MyBank, OXXO, P24, PayU, PUI, SafetyPay, SatisPay, Sofort, Trustly, TrustPay, Verkkopankki, WeChat Pay
        // NO_INSTRUCTION.The API caller intends to authorize v2/checkout/orders/id/authorize or capture v2/checkout/orders/id/capture after the payer approves the order.
        public string processing_instruction { get; set; } = "NO_INSTRUCTION";
    }
}