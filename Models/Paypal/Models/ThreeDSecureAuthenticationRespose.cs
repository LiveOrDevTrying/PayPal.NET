using PayPal.NET.Models.Responses;

namespace PayPal.NET.Models.Paypal.Models
{
    public class ThreeDSecureAuthenticationRespose
    {
        // The outcome of the issuer's authentication.

        // The possible values are:

        // Y.Successful authentication.
        // N.Failed authentication / account not verified / transaction denied.
        // U.Unable to complete authentication.
        // A.Successful attempts transaction.
        // C.Challenge required for authentication.
        // R.Authentication rejected (merchant must not submit for authorization).
        // D.Challenge required; decoupled authentication confirmed.
        // I.Informational only; 3DS requestor challenge preference acknowledged.
        // Minimum length: 1.

        // Maximum length: 255.

        // Pattern: ^[0-9A-Z_]+$.
        public string authentication_status { get; set; } = AuthenticationStatus.N.ToString();

        // Status of authentication eligibility.

        // The possible values are:

        // Y.Yes.The bank is participating in 3-D Secure protocol and will return the ACSUrl.
        // N.No.The bank is not participating in 3-D Secure protocol.
        // U.Unavailable.The DS or ACS is not available for authentication at the time of the request.
        // B.Bypass.The merchant authentication rule is triggered to bypass authentication.

        // Minimum length: 1.
        // Maximum length: 255.
        // Pattern: ^[0-9A-Z_]+$.
        public string enrollment_status { get; set; } = EnrollmentStatus.N.ToString();
    }
}
