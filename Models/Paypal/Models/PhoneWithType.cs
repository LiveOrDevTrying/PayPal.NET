namespace PayPal.NET.Models.Paypal.Models
{
    public class PhoneWithType
    {
        // The phone number, in its canonical international E.164 numbering plan format. Supports only the national_number property.
        public PhoneWithTypePhone phone_number { get; set; }
        // The phone type.

        // Possible values: FAX,HOME,MOBILE,OTHER,PAGER.
        public string phone_type { get; set; } = PhoneType.MOBILE.ToString();
    }
}