using PayPal.NET.Enums;
using System;

namespace PayPal.NET
{
    public interface IPaypalPoll : IDisposable
    {
        string AccessCode { get; }

        EnvironmentType EnvironmentType { get; }
    }
}