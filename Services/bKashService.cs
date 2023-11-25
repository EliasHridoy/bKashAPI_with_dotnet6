using B2BAPI.Models.Bkash;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace bKashAPI_with_dotnet6.Services
{
    public class bKashService : IbKashService
    {

        public readonly string BaseURL = "https://tokenized.sandbox.bka.sh/v1.2.0-beta/tokenized/checkout/";
        public readonly string app_key = "<app_key>";
        public readonly string app_secret = "<app_secret>";        
        public async Task<GrantTokenResponse> getGenerateTokenBkash()
        {
            try
            {
                string userName = "<bKash User name>";
                string Password = "<password>";
                var req = new
                {
                    app_key = app_key,
                    app_secret = app_secret
                };
                var jsonObj = JsonConvert.SerializeObject(req);
                var client = new RestClient(BaseURL + "token/grant");

                var request = new RestRequest(string.Empty, Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                request.AddHeader("username", userName);
                request.AddHeader("password", Password);
                request.AddParameter("application/json", jsonObj, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
                GrantTokenResponse responseObj = JsonConvert.DeserializeObject<GrantTokenResponse>(response.Content.ToString());
                return responseObj;
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        public async Task<CreatePaymentResponse> getPaymentCreateBkash(BkashModel obj)
        {
            try
            {
                var req = new
                {
                    mode = "0000",
                    payerReference = obj.payerReference,
                    callbackURL = "http://localhost:5018/swagger/index.html", // your application url 
                    amount = obj.amount,
                    currency = "BDT",
                    merchantInvoiceNumber = obj.merchantInvoiceNumber,
                    intent = "sale"
                };
                var jsonObj = JsonConvert.SerializeObject(req);
                var client = new RestClient(BaseURL + "create");
                var request = new RestRequest(string.Empty, Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                request.AddHeader("authorization", obj.token);
                request.AddHeader("x-app-key", app_key);
                request.AddParameter("application/json", jsonObj, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
                CreatePaymentResponse CreateResponse = JsonConvert.DeserializeObject<CreatePaymentResponse>(response.Content);
                return CreateResponse;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<ExecutePaymnetResponse> getPaymentExecuteBkash(BkashModel obj)
        {
            try
            {
                var token = obj.token;
                var req = new
                {
                    paymentID = obj.paymentID
                };
                var jsonObj = JsonConvert.SerializeObject(req);
                var client = new RestClient(BaseURL + "execute");
                var request = new RestRequest(string.Empty, Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("authorization", token);
                request.AddHeader("x-app-key", app_key);
                request.AddParameter("application/json", jsonObj, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
                return JsonConvert.DeserializeObject<ExecutePaymnetResponse>(response.Content.ToString());
            }
            catch (Exception)
            {
                throw ;
            }
        }
    }
}
