namespace PayPal.NET.Models.Paypal.Models
{
    public class AddressBilling
    {
        /// <summary>
        /// The two-character ISO 3166-1 code that identifies the country or region.
        /// Note: The country code for Great Britain is GB and not UK as used in the top-level domain names for that country.Use the C2 country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.
        /// </summary>
        public string country_code { get; set; }
        /// <summary>
        /// The first line of the address. For example, number or street. For example, 173 Drury Lane. Required for data entry and compliance and risk checks. Must contain the full address.

        /// Maximum length: 300.
        /// </summary>
        public string address_line_1 { get; set; }
        /// <summary>
        /// The second line of the address. For example, suite or apartment number.

        /// Maximum length: 300.
        /// </summary>
        public string address_line_2 { get; set; }
        /// <summary>
        /// The highest level sub-division in a country, which is usually a province, state, or ISO-3166-2 subdivision.Format for postal delivery.For example, CA and not California. Value, by country, is:
        /// UK.A county.
        /// US.A state.
        /// Canada.A province.
        /// Japan.A prefecture.
        /// Switzerland.A kanton.

        /// Maximum length: 300.
        /// </summary>
        public string address_area_1 { get; set; }
        /// <summary>
        /// A city, town, or village.Smaller than admin_area_level_1.

        /// Maximum length: 120.
        /// </summary>
        public string address_area_2 { get; set; }
        /// <summary>
        /// The postal code, which is the zip code or equivalent. Typically required for countries with a postal code or an equivalent. See postal code.

        /// Maximum length: 60.
        /// </summary>
        public string postal_code { get; set; }
    }
}