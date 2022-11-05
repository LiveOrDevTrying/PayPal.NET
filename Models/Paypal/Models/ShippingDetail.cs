namespace PayPal.NET.Models.Paypal.Models
{
    public class ShippingDetail
    {
        /// <summary>
        /// The address of the person to whom to ship the items. Supports only the address_line_1, address_line_2, admin_area_1, admin_area_2, postal_code, and country_code properties.
        /// </summary>
        public ShippingDetailAddress address { get; set; }
        /// <summary>
        /// The name of the person to whom to ship the items. Supports only the full_name property.
        /// </summary>
        public ShippingDetailName name { get; set; }
        /// <summary>
        /// The method by which the payer wants to get their items from the payee e.g shipping, in-person pickup.Either type or options but not both may be present.

        /// The possible values are:

        /// SHIPPING.The payer intends to receive the items at a specified address.
        /// PICKUP_IN_PERSON.The payer intends to pick up the items from the payee in person.

        /// Minimum length: 1.
        /// Maximum length: 255.
        /// Pattern: ^[0-9A-Z_]+$.
        /// </summary>
        public string type { get; set; }
    }
}