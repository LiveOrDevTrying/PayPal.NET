namespace PayPal.NET.Models.Paypal.Models
{
    public abstract class ItemBase<A> where A : Amount
    {
        // The item name or title.

        // Minimum length: 1.
        // Maximum length: 127.
        public string name { get; set; }
        // The item quantity.Must be a whole number.

        // Maximum length: 10.
        // Pattern: ^[1-9][0-9]{0,9}$.
        public int quantity { get; set; }
        // The item price or rate per unit.If you specify unit_amount, purchase_units[].amount.breakdown.item_total is required.Must equal unit_amount* quantity for all items.unit_amount.value can not be a negative number.
        public A unit_amount { get; set; }
        // The item category type.

        // The possible values are:

        // DIGITAL_GOODS.Goods that are stored, delivered, and used in their electronic format.This value is not currently supported for API callers that leverage the PayPal for Commerce Platform product.
        // PHYSICAL_GOODS.A tangible item that can be shipped with proof of delivery.
        // DONATION.A contribution or gift for which no good or service is exchanged, usually to a not for profit organization.

        // Minimum length: 1.
        // Maximum length: 20.
        public string category { get; set; } = "DIGITAL_GOODS";
        // The detailed item description.

        // Maximum length: 127.
        public string description { get; set; }
        // The stock keeping unit (SKU) for the item.

        // Maximum length: 127.
        public string sku { get; set; }
        // The item tax for each unit. If tax is specified, purchase_units[].amount.breakdown.tax_total is required. Must equal tax * quantity for all items. tax.value can not be a negative number.
        public Amount tax { get; set; }
    }
}