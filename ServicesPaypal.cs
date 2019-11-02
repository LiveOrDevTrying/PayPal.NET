using Newtonsoft.Json;
using PayPal.NET.Models.Requests;
using PayPal.NET.Models.Responses;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PayPal.NET
{
    public class ServicesPaypal : IServicesPaypal
    {
        protected readonly IPaypalPoll _paypalPoll;

        public ServicesPaypal(IPaypalPoll paypalPoll)
        {
            _paypalPoll = paypalPoll;
        }

        public virtual async Task<PaypalOrderResponse> CreatePaypalOrderAsync(PurchaseCreateRequest purchase)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var request = new PaypalOrderRequest
                    {
                        intent = "CAPTURE",
                        purchase_units = new PaypalOrderRequest.Purchase_Units[]
                        {
                            new PaypalOrderRequest.Purchase_Units
                            {
                                amount = new PaypalOrderRequest.Purchase_Units.Amount
                                {
                                    currency_code = "USD",
                                    value = purchase.Subtotal.ToString()
                                }
                            }
                        }
                    };

                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_paypalPoll.AccessCode}");

                    var url = _paypalPoll.EnvironmentType == Enums.EnvironmentType.Sandbox ? Globals.PAYPAL_URL_SANDBOX : Globals.PAYPAL_URL_PRODUCTION;
                    var response = await httpClient.PostAsync($"{url}/v2/checkout/orders",
                        new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));

                    var content = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<PaypalOrderResponse>(content);
                }
            }
            catch
            { }

            return null;
        }

        public virtual async Task<PaypalOrderAuthResponse> CapturePaypalTransactionAsync(PurchaseCreateRequest purchase)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_paypalPoll.AccessCode}");

                    var url = _paypalPoll.EnvironmentType == Enums.EnvironmentType.Sandbox ? Globals.PAYPAL_URL_SANDBOX : Globals.PAYPAL_URL_PRODUCTION;
                    var response = await httpClient.PostAsync($"{url}/v2/checkout/orders/{purchase.OrderId}/capture",
                        new StringContent(string.Empty, Encoding.UTF8, "application/json"));

                    var content = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<PaypalOrderAuthResponse>(content);
                }
            }
            catch
            { }

            return null;
        }
    }
}
