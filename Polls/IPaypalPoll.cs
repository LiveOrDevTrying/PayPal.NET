using PayPal.NET.Enums;
using System;

namespace PayPal.NET.Polls
{
    public interface IPaypalPoll : IDisposable
    {
        string AccessCode { get; }

        EnvironmentType EnvironmentType { get; }
    }
}