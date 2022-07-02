namespace PayPal.NET.Models.Paypal.Models
{
    public class TaxInfo
    {
        // The customer's tax ID value.

        // Minimum length: 1.
        // Maximum length: 14.
        public string tax_id { get; set; }
        // The customer's tax ID type.

        // The possible values are:

        // BR_CPF.The individual tax ID type, typically is 11 characters long.
        // BR_CNPJ.The business tax ID type, typically is 14 characters long.

        // Minimum length: 1.
        // Maximum length: 14.
        public string tax_id_type { get; set; }
    }
}