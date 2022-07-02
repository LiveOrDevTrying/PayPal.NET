using PayPal.NET.Models.Paypal;
using System;

namespace PayPal.NET.Polls
{
    public interface IPaypalPoll : IDisposable
    {
        string AccessCode { get; }

        EnvironmentType EnvironmentType { get; }
    }
}