﻿namespace PayPal.NET.Models.Paypal.Models
{
    public class ProcessorResponse
    {
        /// <summary>
        /// The address verification code for Visa, Discover, Mastercard, or American Express transactions.

        /// The possible values are:

        /// A.For Visa, Mastercard, or Discover transactions, the address matches but the zip code does not match.For American Express transactions, the card holder address is correct.
        /// B.For Visa, Mastercard, or Discover transactions, the address matches.International A.
        /// C.For Visa, Mastercard, or Discover transactions, no values match.International N.
        /// D.For Visa, Mastercard, or Discover transactions, the address and postal code match. International X.
        /// E.For Visa, Mastercard, or Discover transactions, not allowed for Internet or phone transactions. For American Express card holder, the name is incorrect but the address and postal code match.
        /// F.For Visa, Mastercard, or Discover transactions, the address and postal code match. UK-specific X. For American Express card holder, the name is incorrect but the address matches.
        /// G.For Visa, Mastercard, or Discover transactions, global is unavailable.Nothing matches.
        /// I.For Visa, Mastercard, or Discover transactions, international is unavailable.Not applicable.
        /// M.For Visa, Mastercard, or Discover transactions, the address and postal code match. For American Express card holder, the name, address, and postal code match.
        /// N.For Visa, Mastercard, or Discover transactions, nothing matches. For American Express card holder, the address and postal code are both incorrect.
        /// P.For Visa, Mastercard, or Discover transactions, postal international Z.Postal code only.
        /// R.For Visa, Mastercard, or Discover transactions, re-try the request. For American Express, the system is unavailable.
        /// S.For Visa, Mastercard, Discover, or American Express, the service is not supported.
        /// U.For Visa, Mastercard, or Discover transactions, the service is unavailable.For American Express, information is not available. For Maestro, the address is not checked or the acquirer had no response. The service is not available.
        /// W.For Visa, Mastercard, or Discover transactions, whole ZIP code.For American Express, the card holder name, address, and postal code are all incorrect.
        /// X.For Visa, Mastercard, or Discover transactions, exact match of the address and the nine-digit ZIP code.For American Express, the card holder name, address, and postal code are all incorrect.
        /// Y.For Visa, Mastercard, or Discover transactions, the address and five-digit ZIP code match. For American Express, the card holder address and postal code are both correct.
        /// Z.For Visa, Mastercard, or Discover transactions, the five-digit ZIP code matches but no address.For American Express, only the card holder postal code is correct.
        /// Null.For Maestro, no AVS response was obtained.
        /// 0. For Maestro, all address information matches.
        /// 1. For Maestro, none of the address information matches.
        /// 2. For Maestro, part of the address information matches.
        /// 3. For Maestro, the merchant did not provide AVS information.It was not processed.
        /// 4. For Maestro, the address was not checked or the acquirer had no response. The service is not available.
        
        /// Read only.
        /// </summary>
        public string avs_code { get; set; }
        /// <summary>
        /// The card verification value code for for Visa, Discover, Mastercard, or American Express.

        /// The possible values are:

        /// E.For Visa, Mastercard, Discover, or American Express, error - unrecognized or unknown response.
        /// I.For Visa, Mastercard, Discover, or American Express, invalid or null.
        /// M.For Visa, Mastercard, Discover, or American Express, the CVV2/CSC matches.
        /// N.For Visa, Mastercard, Discover, or American Express, the CVV2/CSC does not match.
        /// P.For Visa, Mastercard, Discover, or American Express, it was not processed.
        /// S.For Visa, Mastercard, Discover, or American Express, the service is not supported.
        /// U.For Visa, Mastercard, Discover, or American Express, unknown - the issuer is not certified.
        /// X.For Visa, Mastercard, Discover, or American Express, no response. For Maestro, the service is not available.
        /// All others. For Visa, Mastercard, Discover, or American Express, error.
        /// 0. For Maestro, the CVV2 matched.
        /// 1. For Maestro, the CVV2 did not match.
        /// 2. For Maestro, the merchant has not implemented CVV2 code handling.
        /// 3. For Maestro, the merchant has indicated that CVV2 is not present on card.
        /// 4. For Maestro, the service is not available.
        
        /// Read only.
        /// </summary>
        public string cvv_code { get; set; }
        /// <summary>
        /// The declined payment transactions might have payment advice codes. The card networks, like Visa and Mastercard, return payment advice codes.

        /// The possible values are:

        /// 01. For Mastercard, expired card account upgrade or portfolio sale conversion.Obtain new account information before next billing cycle.
        /// 02. For Mastercard, over credit limit or insufficient funds. Retry the transaction 72 hours later. For Visa, the card holder wants to stop only one specific payment in the recurring payment relationship. The merchant must NOT resubmit the same transaction. The merchant can continue the billing process in the subsequent billing period.
        /// 03. For Mastercard, account closed as fraudulent.Obtain another type of payment from customer due to account being closed or fraud. Possible reason: Account closed as fraudulent.For Visa, the card holder wants to stop all recurring payment transactions for a specific merchant.Stop recurring payment requests.
        /// 21. For Mastercard, the card holder has been unsuccessful at canceling recurring payment through merchant. Stop recurring payment requests. For Visa, all recurring payments were canceled for the card number requested. Stop recurring payment requests.
        
        /// Read only.
        /// </summary>
        public string payment_advice_code { get; set; }
        /// <summary>
        /// Processor response code for the non-PayPal payment processor errors.

        /// The possible values are:

        /// 0000. APPROVED.
        /// 00N7.CVV2_FAILURE_POSSIBLE_RETRY_WITH_CVV.
        /// 0100. REFERRAL.
        /// 0390. ACCOUNT_NOT_FOUND.
        /// 0500. DO_NOT_HONOR.
        /// 0580. UNAUTHORIZED_TRANSACTION.
        /// 0800. BAD_RESPONSE_REVERSAL_REQUIRED.
        /// 0880. CRYPTOGRAPHIC_FAILURE.
        /// 0R00.CANCELLED_PAYMENT.
        /// 1000. PARTIAL_AUTHORIZATION.
        /// 10BR.ISSUER_REJECTED.
        /// 1300. INVALID_DATA_FORMAT.
        /// 1310. INVALID_AMOUNT.
        /// 1312. INVALID_TRANSACTION_CARD_ISSUER_ACQUIRER.
        /// 1317. INVALID_CAPTURE_DATE.
        /// 1320. INVALID_CURRENCY_CODE.
        /// 1330. INVALID_ACCOUNT.
        /// 1335. INVALID_ACCOUNT_RECURRING.
        /// 1340. INVALID_TERMINAL.
        /// 1350. INVALID_MERCHANT.
        /// 1360. BAD_PROCESSING_CODE.
        /// 1370. INVALID_MCC.
        /// 1380. INVALID_EXPIRATION.
        /// 1382. INVALID_CARD_VERIFICATION_VALUE.
        /// 1384. INVALID_LIFE_CYCLE_OF_TRANSACTION.
        /// 1390. INVALID_ORDER.
        /// 1393. TRANSACTION_CANNOT_BE_COMPLETED.
        /// 5100. GENERIC_DECLINE.
        /// 5110. CVV2_FAILURE.
        /// 5120. INSUFFICIENT_FUNDS.
        /// 5130. INVALID_PIN.
        /// 5135. DECLINED_PIN_TRY_EXCEEDED.
        /// 5140. CARD_CLOSED.
        /// 5150. PICKUP_CARD_SPECIAL_CONDITIONS.Try using another card.Do not retry the same card.
        /// 5160. UNAUTHORIZED_USER.
        /// 5170. AVS_FAILURE.
        /// 5180. INVALID_OR_RESTRICTED_CARD.Try using another card.Do not retry the same card.
        /// 5190. SOFT_AVS.
        /// 5200. DUPLICATE_TRANSACTION.
        /// 5210. INVALID_TRANSACTION.
        /// 5400. EXPIRED_CARD.
        /// 5500. INCORRECT_PIN_REENTER.
        /// 5650. DECLINED_SCA_REQUIRED.
        /// 5700. TRANSACTION_NOT_PERMITTED.Outside of scope of accepted business.
        /// 5710. TX_ATTEMPTS_EXCEED_LIMIT.
        /// 5800. REVERSAL_REJECTED.
        /// 5900. INVALID_ISSUE.
        /// 5910. ISSUER_NOT_AVAILABLE_NOT_RETRIABLE.
        /// 5920. ISSUER_NOT_AVAILABLE_RETRIABLE.
        /// 5930. CARD_NOT_ACTIVATED.
        /// 6300. ACCOUNT_NOT_ON_FILE.
        /// 7600. APPROVED_NON_CAPTURE.
        /// 7700. ERROR_3DS.
        /// 7710. AUTHENTICATION_FAILED.
        /// 7800. BIN_ERROR.
        /// 7900. PIN_ERROR.
        /// 8000. PROCESSOR_SYSTEM_ERROR.
        /// 8010. HOST_KEY_ERROR.
        /// 8020. CONFIGURATION_ERROR.
        /// 8030. UNSUPPORTED_OPERATION.
        /// 8100. FATAL_COMMUNICATION_ERROR.
        /// 8110. RETRIABLE_COMMUNICATION_ERROR.
        /// 8220. SYSTEM_UNAVAILABLE.
        /// 9100. DECLINED_PLEASE_RETRY.Retry.
        /// 9500. SUSPECTED_FRAUD.Try using another card.Do not retry the same card.
        /// 9510. SECURITY_VIOLATION.
        /// 9520. LOST_OR_STOLEN.Try using another card.Do not retry the same card.
        /// 9530. HOLD_CALL_CENTER.The merchant must call the number on the back of the card. POS scenario.
        /// 9540. REFUSED_CARD.
        /// 9600. UNRECOGNIZED_RESPONSE_CODE.
        /// PCNR.CONTINGENCIES_NOT_RESOLVED.
        /// PCVV.CVV_FAILURE.
        /// PPAD.BILLING_ADDRESS.
        /// PPAE.AMEX_DISABLED.
        /// PPAG.ADULT_GAMING_UNSUPPORTED.
        /// PPAI.AMOUNT_INCOMPATIBLE.
        /// PPAR.AUTH_RESULT.
        /// PPAU.MCC_CODE.
        /// PPAV.ARC_AVS.
        /// PPAX.AMOUNT_EXCEEDED.
        /// PPBG.BAD_GAMING.
        /// PPC2.ARC_CVV.
        /// PPCE.CE_REGISTRATION_INCOMPLETE.
        /// PPCO.COUNTRY.
        /// PPCR.CREDIT_ERROR.
        /// PPCT.CARD_TYPE_UNSUPPORTED.
        /// PPCU.CURRENCY_USED_INVALID.
        /// PPD3.SECURE_ERROR_3DS.
        /// PPDC.DCC_UNSUPPORTED.
        /// PPDI.DINERS_REJECT.
        /// PPDV.AUTH_MESSAGE.
        /// PPEF.EXPIRED_FUNDING_INSTRUMENT.
        /// PPEL.EXCEEDS_FREQUENCY_LIMIT.
        /// PPER.INTERNAL_SYSTEM_ERROR.
        /// PPEX.EXPIRY_DATE.
        /// PPFE.FUNDING_SOURCE_ALREADY_EXISTS.
        /// PPFI.INVALID_FUNDING_INSTRUMENT.
        /// PPFR.RESTRICTED_FUNDING_INSTRUMENT.
        /// PPFV.FIELD_VALIDATION_FAILED.
        /// PPGR.GAMING_REFUND_ERROR.
        /// PPH1.H1_ERROR.
        /// PPIF.IDEMPOTENCY_FAILURE.
        /// PPII.INVALID_INPUT_FAILURE.
        /// PPIM.ID_MISMATCH.
        /// PPIT.INVALID_TRACE_ID.
        /// PPLR.LATE_REVERSAL.
        /// PPLS.LARGE_STATUS_CODE.
        /// PPMB.MISSING_BUSINESS_RULE_OR_DATA.
        /// PPMC.BLOCKED_Mastercard.
        /// PPMD.PPMD.
        /// PPNC.NOT_SUPPORTED_NRC.
        /// PPNL.EXCEEDS_NETWORK_FREQUENCY_LIMIT.
        /// PPNT.NETWORK_ERROR.
        /// PPPH.NO_PHONE_FOR_DCC_TRANSACTION.
        /// PPPI.INVALID_PRODUCT.
        /// PPPM.INVALID_PAYMENT_METHOD.
        /// PPQC.QUASI_CASH_UNSUPPORTED.
        /// PPRE.UNSUPPORT_REFUND_ON_PENDING_BC.
        /// PPRF.INVALID_PARENT_TRANSACTION_STATUS.
        /// PPRR.MERCHANT_NOT_REGISTERED.
        /// PPS0.BANKAUTH_ROW_MISMATCH.
        /// PPS1.BANKAUTH_ROW_SETTLED.
        /// PPS2.BANKAUTH_ROW_VOIDED.
        /// PPS3.BANKAUTH_EXPIRED.
        /// PPS4.CURRENCY_MISMATCH.
        /// PPS5.CREDITCARD_MISMATCH.
        /// PPS6.AMOUNT_MISMATCH.
        /// PPSC.ARC_SCORE.
        /// PPSD.STATUS_DESCRIPTION.
        /// PPSE.AMEX_DENIED.
        /// PPTE.VERIFICATION_TOKEN_EXPIRED.
        /// PPTF.INVALID_TRACE_REFERENCE.
        /// PPTI.INVALID_TRANSACTION_ID.
        /// PPTR.VERIFICATION_TOKEN_REVOKED.
        /// PPTT.TRANSACTION_TYPE_UNSUPPORTED.
        /// PPTV.INVALID_VERIFICATION_TOKEN.
        /// PPUA.USER_NOT_AUTHORIZED.
        /// PPUC.CURRENCY_CODE_UNSUPPORTED.
        /// PPUE.UNSUPPORT_ENTITY.
        /// PPUI.UNSUPPORT_INSTALLMENT.
        /// PPUP.UNSUPPORT_POS_FLAG.
        /// PPUR.UNSUPPORTED_REVERSAL.
        /// PPVC.VALIDATE_CURRENCY.
        /// PPVE.VALIDATION_ERROR.
        /// PPVT.VIRTUAL_TERMINAL_UNSUPPORTED.'

        /// Read only.
        /// </summary>
        public string response_code { get; set; }
    }
}