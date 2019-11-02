namespace PayPal.NET.Models.Requests
{
    public class PurchaseCreateRequest
    {
        public string Id { get; set; }
        public float Subtotal { get; set; }
        public float DiscountApplied { get; set; }
        public float AmountCharged { get; set; }
        public string PayerId { get; set; }
        public string OrderId { get; set; }
        public bool WasChargeAccepted { get; set; }
    }
}
