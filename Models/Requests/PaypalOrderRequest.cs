namespace PayPal.NET.Models.Requests
{
    public class PaypalOrderRequest
    {
        public string intent { get; set; }
        public Purchase_Units[] purchase_units { get; set; }

        public class Purchase_Units
        {
            public Amount amount { get; set; }

            public class Amount
            {
                public string currency_code { get; set; }
                public string value { get; set; }
            }
        }
    }
}
