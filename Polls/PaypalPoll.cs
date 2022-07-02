using Newtonsoft.Json;
using PayPal.NET.Models.Paypal;
using PayPal.NET.Polls.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PayPal.NET.Polls
{
    public class PaypalPoll : IPaypalPoll
    {
        protected PaypalToken _token;
        protected DateTime _lastTokenRefresh;
        protected Timer _timer;
        protected string _payPalClientId;
        protected string _payPalClientSecret;
        protected EnvironmentType _environmentType;
        protected volatile bool _isPollRunning;

        public PaypalPoll(string payPalClientId, string payPalClientSecret, EnvironmentType environmentType, int pollingIntervalMS)
        {
            _payPalClientId = payPalClientId;
            _payPalClientSecret = payPalClientSecret;
            _environmentType = environmentType;

            _timer = new Timer(TimerTick, null, 0, pollingIntervalMS);
        }

        protected virtual void TimerTick(object state)
        {
            if (!_isPollRunning)
            {
                _isPollRunning = true;

                Task.Run(async () =>
                {
                    try
                    {
                        if (_token == null ||
                            (_lastTokenRefresh + TimeSpan.FromSeconds(_token.Expires_in) * 0.8 < DateTime.UtcNow))
                        {
                            var pass = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_payPalClientId}:{_payPalClientSecret}"));
                            using (var httpClient = new HttpClient())
                            {
                                var url = _environmentType == EnvironmentType.Sandbox ? Statics.PAYPAL_URL_SANDBOX : Statics.PAYPAL_URL_PRODUCTION;
                                var request = new HttpRequestMessage(HttpMethod.Post, $"{url}/v1/oauth2/token");

                                request.Headers.Add("Authorization", "Basic " + pass);

                                var body = new List<KeyValuePair<string, string>>
                                {
                                    new KeyValuePair<string, string>("grant_type", "client_credentials")
                                };

                                request.Content = new FormUrlEncodedContent(body);

                                var response = await httpClient.SendAsync(request);
                                var result = await response.Content.ReadAsStringAsync();
                                _token = JsonConvert.DeserializeObject<PaypalToken>(result);
                                _lastTokenRefresh = DateTime.UtcNow;
                            }
                        }
                    }
                    catch
                    { }

                    _isPollRunning = false;
                });
            }

        }

        public string AccessCode
        {
            get
            {
                return _token != null ? _token.Access_token : string.Empty;
            }
        }

        public virtual void Dispose()
        {
            if (_timer != null)
            {
                _timer.Dispose();
                _timer = null;
            }
        }

        public EnvironmentType EnvironmentType
        {
            get
            {
                return _environmentType;
            }
        }
    }
}
