namespace B2BAPI.Models.Bkash
{
    public class BkashModel
    {
        public decimal amount { get; set; }
        public string currency { get; set; }
        public string merchantInvoiceNumber { get; set; }
        public string intent { get; set; }
        public string paymentID { get; set; }
        public string token { get; set; }
        public string trxID { get; set; }
        public string sku { get; set; }
        public string reason { get; set; }
        public string agreementID { get; set; }
        public string payerReference { get; set; }

    }
    public class GrantTokenResponse
    {
        public string statusCode { get; set; }
        public string statusMessage { get; set; }
        public string id_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string refresh_token { get; set; }

    }

    public class AgreementCreateResponse
    {
        public string statusCode { get; set; }
        public string statusMessage { get; set; }
        public string paymentID { get; set; }
        public string bkashURL { get; set; }
        public string callbackURL { get; set; }
        public string successCallbackURL { get; set; }
        public string failureCallbackURL { get; set; }
        public string cancelledCallbackURL { get; set; }
        public string payerReference { get; set; }
        public string agreementStatus { get; set; }
        public string agreementCreateTime { get; set; }

    }

    public class AgreementExecuteResponse
    {
        public string statusCode { get; set; }
        public string statusMessage { get; set; }
        public string paymentID { get; set; }
        public string agreementID { get; set; }
        public string payerReference { get; set; }
        public string agreementExecuteTime { get; set; }
        public string agreementStatus { get; set; }
        public string customerMsisdn { get; set; }
    }

    public class CreatePaymentResponse
    {

        public string statusCode { get; set; }
        public string statusMessage { get; set; }
        public string paymentID { get; set; }
        public string bkashURL { get; set; }
        public string callbackURL { get; set; }
        public string successCallbackURL { get; set; }
        public string failureCallbackURL { get; set; }
        public string cancelledCallbackURL { get; set; }
        public string amount { get; set; }
        public string intent { get; set; }
        public string currency { get; set; }
        public string agreementID { get; set; }
        public string paymentCreateTime { get; set; }
        public string transactionStatus { get; set; }
        public string merchantInvoiceNumber { get; set; }

    }

    public class ExecutePaymnetResponse: ErrorResponse
    {
        public string statusCode { get; set; }
        public string statusMessage { get; set; }
        public string paymentID { get; set; }
        public string agreementID { get; set; }
        public string payerReference { get; set; }
        public string customerMsisdn { get; set; }
        public string trxID { get; set; }
        public string amount { get; set; }
        public string transactionStatus { get; set; }
        public string paymentExecuteTime { get; set; }
        public string currency { get; set; }
        public string intent { get; set; }
        public string merchantInvoiceNumber { get; set; }
    }

    public class ErrorResponse
    {
        public string errorCode { get; set; }
        public string errorMessage { get; set; }
    }
}
