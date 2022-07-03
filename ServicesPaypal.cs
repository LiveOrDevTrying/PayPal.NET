using Newtonsoft.Json;
using PayPal.NET.Models.Paypal;
using PayPal.NET.Models.Paypal.Models;
using PayPal.NET.Models.Paypal.Requests;
using PayPal.NET.Models.Paypal.Responses;
using PayPal.NET.Models.Responses;
using PayPal.NET.Polls;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PayPal.NET
{
    public class ServicesPaypal : IServicesPaypal
    {
        protected readonly IPaypalPoll _paypalPoll;
        protected readonly IHttpClientFactory _httpClientFactory;

        public ServicesPaypal(IPaypalPoll paypalPoll, IHttpClientFactory httpClientFactory = null)
        {
            _paypalPoll = paypalPoll;
            _httpClientFactory = httpClientFactory;
        }

        public virtual async Task<PaypalOrderResponse> CreateOrderAsync(PaypalOrderRequest request)
        {
            return await CreateOrderAsync<PaypalOrderRequest, PaypalOrderResponse, PurchaseUnit, PurchaseUnitResponse, Item, Amount>(request);
        }
        public virtual async Task<PaypalOrderBreakdownResponse> CreateOrderBreakdownAsync(PaypalOrderBreakdownRequest request)
        {
            return await CreateOrderAsync<PaypalOrderBreakdownRequest, PaypalOrderBreakdownResponse, PurchaseUnitBreakdown, PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>(request);
        }
        protected virtual async Task<U> CreateOrderAsync<T, U, PU, PUR, I, A>(T request)
            where T : PaypalOrderRequestBase<PU, I, A>
            where U : PaypalOrderResponseBase<PUR, I, A>
            where PU : PurchaseUnitBase<I, A>
            where PUR : PurchaseUnitBaseResponse<I, A>
            where I : ItemBase<A>
            where A : Amount
        {
            using (var httpClient = _httpClientFactory != null ? _httpClientFactory.CreateClient() : new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_paypalPoll.AccessCode}");

                var url = _paypalPoll.EnvironmentType == EnvironmentType.Sandbox ? Statics.PAYPAL_URL_SANDBOX : Statics.PAYPAL_URL_PRODUCTION;
                var response = await httpClient.PostAsync($"{url}/v2/checkout/orders",
                    new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json")).ConfigureAwait(false);

                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return JsonConvert.DeserializeObject<U>(content);
            }
        }

        public virtual async Task<PaypalCaptureResponse> CapturePaymentForOrderAsync(PaypalCaptureRequest request)
        {
            return await CapturePaymentForOrderAsync<PaypalCaptureResponse, PurchaseUnitResponse, Item, Amount>(request);
        }
        public virtual async Task<PaypalCaptureBreakdownResponse> CapturePaymentForOrderBreakdownAsync(PaypalCaptureRequest request)
        {
            return await CapturePaymentForOrderAsync<PaypalCaptureBreakdownResponse, PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>(request);
        }
        protected virtual async Task<T> CapturePaymentForOrderAsync<T, PUR, I, A>(PaypalCaptureRequest request)
            where T : PaypalCaptureResponseBase<PUR, I, A>
            where PUR : PurchaseUnitBaseResponse<I, A>
            where I : ItemBase<A>
            where A : Amount
        {
            using (var httpClient = _httpClientFactory != null ? _httpClientFactory.CreateClient() : new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_paypalPoll.AccessCode}");

                var url = _paypalPoll.EnvironmentType == EnvironmentType.Sandbox ? Statics.PAYPAL_URL_SANDBOX : Statics.PAYPAL_URL_PRODUCTION;
                var response = await httpClient.PostAsync($"{url}/v2/checkout/orders/{request.orderID}/capture",
                    new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json")).ConfigureAwait(false);

                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return JsonConvert.DeserializeObject<T>(content);
            }
        }
    }
}
