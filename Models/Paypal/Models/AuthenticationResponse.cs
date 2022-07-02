using PayPal.NET.Models.Responses;

namespace PayPal.NET.Models.Paypal.Models
{
    public class AuthenticationResponse
    {
        // Liability shift indicator. The outcome of the issuer's authentication.

        // The possible values are:

        // YES.Liability has shifted to the card issuer.Available only after order is authorized or captured.
        // NO.Liability is with the merchant.
        // POSSIBLE.Liability may shift to the card issuer.Available only before order is authorized or captured.
        // UNKNOWN.The authentication system is not available.

        // Minimum length: 1.
        // Maximum length: 255.
        // Pattern: ^[0-9A-Z_]+$.
        public string liability_shift { get; set; } = LiabilityShiftType.UNKNOWN.ToString();
        // Results of 3D Secure Authentication.
        public ThreeDSecureAuthenticationRespose three_d_secure { get; set; }
    }
}
