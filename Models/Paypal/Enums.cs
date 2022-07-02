namespace PayPal.NET.Models.Paypal
{
    public enum EnvironmentType
    {
        Sandbox,
        Production
    }

    public enum TaxIdType
    {
        BR_CPF,
        BR_CNPJ
    }

    public enum PhoneType
    {
        FAX,
        HOME,
        MOBILE,
        OTHER,
        PAGER
    }

    public enum ProcessingInstruction
    {
        ORDER_COMPLETE_ON_PAYMENT_APPROVAL,
        NO_INSTRUCTION
    }

    public enum Category
    {
        DIGITAL_GOODS,
        PHYSICAL_GOODS,
        DONATION
    }

    public enum BrandType
    {
        VISA,
        MASTERCARD,
        DISCOVER,
        AMEX,
        SOLO,
        JCB,
        STAR,
        DELTA,
        SWITCH,
        MAESTRO,
        CB_NATIONALE,
        CONFIGOGA,
        CONFIDIS,
        ELECTRON,
        CETELEM,
        CHINA_UNION_PAY
    }

    public enum Usage
    {
        FIRST,
        SUBSEQUENT,
        DERIVED
    }

    public enum PaymentType
    {
        ONE_TIME,
        RECURRING,
        UNSCHEDULED
    }

    public enum PaymentInitiator
    {
        CUSTOMER,
        MERCHANT
    }

    public enum UserAction
    {
        CONTINUE,
        PAY_NOW
    }

    public enum PayeePreferred
    {
        UNRESTRICTED,
        INMMEDIATE_PAYMENT_REQUIRED
    }

    public enum LandingPage
    {
        LOGIN,
        BILLING,
        NO_PREFERENCE
    }

    public enum Intent
    {
        CAPTURE,
        AUTHORIZE
    }

    public enum ShippingType
    {
        SHIPPING,
        PICKUP
    }

    public enum CardType
    {
        CREDIT,
        DEBIT,
        PREPAID,
        UNKNOWN
    }

    public enum EnrollmentStatus
    {
        Y,
        N,
        U,
        B
    }

    public enum AuthenticationStatus
    {
        Y,
        N,
        U,
        A,
        C,
        R,
        D,
        I
    }

    public enum LiabilityShiftType
    {
        YES,
        NO,
        POSSIBLE,
        UNKNOWN
    }

    public enum TokenType
    {
        BILLING_AGREEMENT
    }

    public enum Status
    {
        CREATED,
        SAVED,
        APPROVED,
        VOIDED,
        COMPLETED,
        PAYER_ACTION_REQUIRED
    }
}
