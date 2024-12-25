using Flurl;
using Flurl.Http;
using System.Text.Json;

namespace ChapaNET;
public enum TransactionStatus
{
    Completed, Incomplete, Error
}
public partial class Chapa
{
    ChapaConfig Config { get; set; }
    public static string GetUniqueRef() => "tx" + DateTime.Now.Ticks;
    public Chapa(string SECRET_KEY)
    {
        if (SECRET_KEY == null)
            throw new Exception("Secret Key can't be null");
        Config = new() { API_SECRET = SECRET_KEY };

    }
    public Chapa(ChapaConfig config) : this(config.API_SECRET) { }
    public async Task<ChapaResponse> RequestAsync<T>(ChapaRequest<T> request)
    {
        
        var body = new
        {
            email = request.Email,
            amount = request.Amount,
            first_name = request.FirstName,
            last_name = request.LastName,
            tx_ref = request.TransactionReference,
            currency = request.Currency,
            phone_number = request.PhoneNo,
            callback_url = request.CallbackUrl,
            return_url = request.ReturnUrl,
            meta = new
            {
                custom_fields = request.Meta!.custom_fields
            }
        };
        var result = await "https://api.chapa.co/v1/transaction/initialize"
            .WithHeader(ChapaConfig.AUTH_HEADER, $"Bearer {Config.API_SECRET}")
            .PostJsonAsync(body);
        var response = await result.GetJsonAsync<ChapaResponse>();
        return response;
    }
    public async Task<ValidityReport?> VerifyAsync(string txRef)
    {
        try
        {
            var validityResponse = await $"https://api.chapa.co/v1/transaction/verify/{txRef}"
                        .WithHeader(ChapaConfig.AUTH_HEADER, $"Bearer {Config.API_SECRET}")
                        .GetJsonAsync<ValidityReport>();
            return validityResponse;
        }
        catch (Exception)
        {
            return null;
        }
    }
    public async Task<IEnumerable<Bank>> GetBanksAsync()
    {
        var response =
            await "https://api.chapa.co/v1"
                .WithHeader(ChapaConfig.AUTH_HEADER, $"Bearer {Config.API_SECRET}")
                .AppendPathSegment("banks")
                .GetJsonAsync<BankResponse>();

        return response.data!;
    }
}

