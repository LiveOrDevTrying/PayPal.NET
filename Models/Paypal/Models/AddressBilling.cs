namespace PayPal.NET.Models.Paypal.Models
{
    public class Address
    {
        // The two-character ISO 3166-1 code that identifies the country or region.
        //Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country.Use the C2 country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.


        //Minimum length: 2.
        //Maximum length: 2.
        //Pattern: ^([A - Z]{ 2}|C2)$.
        public string country_code { get; set; } = "US";
        // The non-portable additional address details that are sometimes needed for compliance, risk, or other scenarios where fine-grain address information might be needed. Not portable with common third party and open source. Redundant with core fields.
        // For example, address_portable.address_line_1 is usually a combination of address_details.street_number, street_name, and street_type.
        public int address_details { get; set; }
        // The first line of the address. For example, number or street. For example, 173 Drury Lane. Required for data entry and compliance and risk checks. Must contain the full address.

        // Maximum length: 300.
        public string address_line_1 { get; set; }
        // The second line of the address.For example, suite or apartment number.

        // Maximum length: 300.
        public string address_line_2 { get; set; }
        // The third line of the address, if needed.For example, a street complement for Brazil, direction text, such as next to Walmart, or a landmark in an Indian address.

        // Maximum length: 100.
        public string address_line_3 { get; set; }
        // The highest level sub-division in a country, which is usually a province, state, or ISO-3166-2 subdivision.Format for postal delivery.For example, CA and not California. Value, by country, is:
        // UK.A county.
        // US.A state.
        // Canada.A province.
        // Japan.A prefecture.
        // Switzerland.A kanton.

        // Maximum length: 300.
        public string admin_area_1 { get; set; }
        // A city, town, or village. Smaller than admin_area_level_1.

        // Maximum length: 120.
        public string admin_area_2 { get; set; }
        // A sub-locality, suburb, neighborhood, or district. Smaller than admin_area_level_2. Value is:
        // Brazil.Suburb, bairro, or neighborhood.
        // India.Sub-locality or district.Street name information is not always available but a sub-locality or district can be a very small area.

        // Maximum length: 100.
        public string admin_area_3 { get; set; }
        // The neighborhood, ward, or district.Smaller than admin_area_level_3 or sub_locality.Value is:
        // The postal sorting code for Guernsey and many French territories, such as French Guiana.
        // The fine-grained administrative levels in China.

        // Maximum length: 100.
        public string admin_area_4 { get; set; }
        // The postal code, which is the zip code or equivalent.Typically required for countries with a postal code or an equivalent.See postal code.

        // Maximum length: 60.
        public string postal_code { get; set; }
    }
}