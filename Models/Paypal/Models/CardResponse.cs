namespace PayPal.NET.Models.Paypal.Models
{
    public class CardResponse
    {
        // Results of Authentication such as 3D Secure.
        public AuthenticationResponse authentication_result { get; set; }

        // The billing address for this card. Supports only the address_line_1, address_line_2, admin_area_1, admin_area_2, postal_code, and country_code properties.
        public AddressBilling billing_address { get; set; }
        public string brand { get; set; }
        public string last_digits { get; set; }
        // The card holder's name as it appears on the card.

        // Maximum length: 300.
        public string name { get; set; }
        // The payment card type.

        // The possible values are:

        // CREDIT.A credit card.
        // DEBIT.A debit card.
        // PREPAID.A Prepaid card.
        // UNKNOWN.Card type cannot be determined.

        // Read only.
        public string type { get; set; }
    }
}
