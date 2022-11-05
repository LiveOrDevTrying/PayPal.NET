namespace PayPal.NET.Models.Paypal.Models
{
    public class Breakdown
    {
        // The discount for all items within a given purchase_unit.discount.value can not be a negative number.
        public Amount discount { get; set; }
        // The handling fee for all items within a given purchase_unit. handling.value can not be a negative number.
        public Amount handling { get; set; }
        // The insurance fee for all items within a given purchase_unit.insurance.value can not be a negative number.
        public Amount insurance { get; set; }
        // The subtotal for all items. Required if the request includes purchase_units[].items[].unit_amount. Must equal the sum of (items[].unit_amount * items[].quantity) for all items. item_total.value can not be a negative number.
        public Amount item_total { get; set; }
        // The shipping fee for all items within a given purchase_unit. shipping.value can not be a negative number.
        public Amount shipping { get; set; }
        // The shipping discount for all items within a given purchase_unit. shipping_discount.value can not be a negative number.
        public Amount shipping_discount { get; set; }
        // The total tax for all items. Required if the request includes purchase_units.items.tax. Must equal the sum of (items[].tax * items[].quantity) for all items. tax_total.value can not be a negative number.
        public Amount tax_total { get; set; }
    }
}