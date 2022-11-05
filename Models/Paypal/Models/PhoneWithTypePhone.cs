namespace PayPal.NET.Models.Paypal.Models
{
    public class PhoneWithTypePhone
    {
        // The national number, in its canonical international E.164 numbering plan format.The combined length of the country calling code(CC) and the national number must not be greater than 15 digits.The national number consists of a national destination code(NDC) and subscriber number(SN).

        // Minimum length: 1.
        // Maximum length: 14.
        // Pattern: ^[0-9]{1,14}?$.
        public string national_number { get; set; }
    }
}