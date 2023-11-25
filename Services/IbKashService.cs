using B2BAPI.Models.Bkash;

namespace bKashAPI_with_dotnet6.Services
{
    public interface IbKashService
    {
        Task<GrantTokenResponse> getGenerateTokenBkash();
        Task<CreatePaymentResponse> getPaymentCreateBkash(BkashModel obj);
        Task<ExecutePaymnetResponse> getPaymentExecuteBkash(BkashModel obj);
    }
}
