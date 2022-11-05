namespace PayPal.NET.Models.Paypal.Models
{
    public class Payer
    {
        /// <summary>
        /// The email address of the payer.
        ///
        /// Maximum length: 254.
        /// Pattern: (?:[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-zA-Z0-9-]*[a-zA-Z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\]).
        /// </summary>
        public string email_address { get; set; }
        /// <summary>
        /// The PayPal-assigned ID for the payer.
        ///
        /// Minimum length: 13.
        /// Maximum length: 13.
        /// Pattern: ^[2-9A-HJ-NP-Z]{ 13}$.
        /// </summary>
        public string payer_id { get; set; }
        /// <summary>
        /// The address of the payer.Supports only the address_line_1, address_line_2, admin_area_1, admin_area_2, postal_code, and country_code properties.Also referred to as the billing address of the customer.
        /// </summary>
        public Address address { get; set; }
        /// <summary>
        /// The birth date of the payer in YYYY-MM-DD format.
        /// </summary>
        public string birth_date { get; set; }
        /// <summary>
        /// The name of the payer. Supports only the given_name and surname properties.
        /// </summary>
        public Name name { get; set; }
        /// <summary>
        /// The phone number of the customer. Available only when you enable the Contact Telephone Number option in the Profile & Settings for the merchant's PayPal account. The phone.phone_number supports only national_number.
        /// </summary>
        public PhoneWithType phone { get; set; }
        /// <summary>
        /// The tax information of the payer.Required only for Brazilian payer's. Both tax_id and tax_id_type are required.
        /// </summary>
        public TaxInfo tax_info { get; set; }
    }
}