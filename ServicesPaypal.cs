﻿using Newtonsoft.Json;
using PayPal.NET.Models.Paypal;
using PayPal.NET.Models.Paypal.Models;
using PayPal.NET.Models.Paypal.Requests.Orders;
using PayPal.NET.Models.Paypal.Requests.Payments;
using PayPal.NET.Models.Paypal.Responses.Orders;
using PayPal.NET.Models.Paypal.Responses.Payments;
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

        public virtual async Task<OrdersGetOrderResponse> OrdersGetOrderDetailsAsync(string id, string fields = null)
        {
            return await OrdersGetOrderDetailsAsync<OrdersGetOrderResponse, PurchaseUnitResponse, Item, Amount>(id, fields);
        }
        public virtual async Task<OrdersGetOrderBreakdownResponse> OrdersGetOrderDetailsBreakdownAsync(string id, string fields = null)
        {
            return await OrdersGetOrderDetailsAsync<OrdersGetOrderBreakdownResponse, PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>(id, fields);
        }
        protected virtual async Task<U> OrdersGetOrderDetailsAsync<U, PUR, I, A>(string id, string fields = null) 
            where U : OrdersGetOrderBase<PUR, I, A>
            where PUR : PurchaseUnitBaseResponse<I, A>
            where I : ItemBase<A>
            where A : Amount
        {
            return await Get<U>($"v2/checkout/orders/{id}" + (fields != null && fields.Length > 0 ? $"fields={fields}" : ""));
        }
        public virtual async Task<OrdersCreateOrderResponse> OrdersCreateOrderAsync(OrdersCreateOrderRequest request)
        {
            return await OrdersCreateOrderAsync<OrdersCreateOrderRequest, OrdersCreateOrderResponse, PurchaseUnit, PurchaseUnitResponse, Item, Amount>(request);
        }
        public virtual async Task<OrdersCreateOrderBreakdownResponse> OrdersCreateOrderBreakdownAsync(OrdersCreateOrderBreakdownRequest request)
        {
            return await OrdersCreateOrderAsync<OrdersCreateOrderBreakdownRequest, OrdersCreateOrderBreakdownResponse, PurchaseUnitBreakdown, PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>(request);
        }
        protected virtual async Task<U> OrdersCreateOrderAsync<T, U, PU, PUR, I, A>(T request)
            where T : OrdersCreateOrderRequestBase<PU, I, A>
            where U : OrdersCreateOrderBase<PUR, I, A>
            where PU : PurchaseUnitBase<I, A>
            where PUR : PurchaseUnitBaseResponse<I, A>
            where I : ItemBase<A>
            where A : Amount
        {
            return await Post<T, U>(request, $"v2/checkout/orders");
        }

        public virtual async Task<OrdersCapturePaymentForOrderResponse> OrdersCapturePaymentForOrderAsync(OrdersCapturePaymentForOrderRequest request)
        {
            return await OrdersCapturePaymentForOrderAsync<OrdersCapturePaymentForOrderResponse, PurchaseUnitResponse, Item, Amount>(request);
        }
        public virtual async Task<OrdersCapturePaymentForOrderBreakdownResponse> OrdersCapturePaymentForOrderBreakdownAsync(OrdersCapturePaymentForOrderRequest request)
        {
            return await OrdersCapturePaymentForOrderAsync<OrdersCapturePaymentForOrderBreakdownResponse, PurchaseUnitBreakdownResponse, ItemBreakdown, AmountBreakdown>(request);
        }
        protected virtual async Task<T> OrdersCapturePaymentForOrderAsync<T, PUR, I, A>(OrdersCapturePaymentForOrderRequest request)
            where T : OrdersCapturePaymentForOrderBase<PUR, I, A>
            where PUR : PurchaseUnitBaseResponse<I, A>
            where I : ItemBase<A>
            where A : Amount
        {
            return await Post<OrdersCapturePaymentForOrderRequest, T>(request, $"v2/checkout/orders/{request.orderID}/capture");
        }

        public virtual async Task<PaymentsRefundCapturedPaymentResponse> PaymentsRefundCapturedPaymentAsync(string captureId, PaymentsRefundCapturedPaymentRequest request = null)
        {
            return await Post< PaymentsRefundCapturedPaymentRequest, PaymentsRefundCapturedPaymentResponse>(request, $"v2/payments/captures/{captureId}/refund");
        }

        protected virtual async Task<T> Get<T>(string path)
        {
            using (var httpClient = _httpClientFactory != null ? _httpClientFactory.CreateClient() : new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_paypalPoll.AccessCode}");

                var url = _paypalPoll.EnvironmentType == EnvironmentType.Sandbox ? Statics.PAYPAL_URL_SANDBOX : Statics.PAYPAL_URL_PRODUCTION;
                var response = await httpClient.GetAsync($"{url}/{path}").ConfigureAwait(false);

                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return JsonConvert.DeserializeObject<T>(content);
            }
        }

        protected virtual async Task<U> Post<T, U>(T request, string path)
        {
            using (var httpClient = _httpClientFactory != null ? _httpClientFactory.CreateClient() : new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_paypalPoll.AccessCode}");

                var url = _paypalPoll.EnvironmentType == EnvironmentType.Sandbox ? Statics.PAYPAL_URL_SANDBOX : Statics.PAYPAL_URL_PRODUCTION;
                var response = await httpClient.PostAsync($"{url}/{path}",
                    new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json")).ConfigureAwait(false);

                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                return JsonConvert.DeserializeObject<U>(content);
            }
        }
    }
}
