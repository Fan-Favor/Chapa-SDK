namespace ChapaNET;

public class ChapaRequest
{
    public double Amount { get; set; }
    public string? Email { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string TransactionReference { get; set; }
    public string? PhoneNo { get; set; }
    public string? Currency { get; set; }
    public string? CallbackUrl { get; set; }
    public string? ReturnUrl { get; set; }
    public string? CustomTitle { get; set; }
    public string? CustomDescription { get; set; }
    public string? CustomLogo { get; set; }
    public ChapaRequest(
          double amount
        , string tx_ref
        , string? phoneNo = null
        , string? currency = "ETB"
        , string? callback_url = null
        , string? return_url = null
        , string? customTitle = null
        , string? customDescription = null
        , string? customLogo = null
        , string? email = null
        , string? firstName = null
        , string? lastName = null)
    {
        Amount = amount;
        Currency = currency;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        PhoneNo = phoneNo;
        TransactionReference = tx_ref;
        CallbackUrl = callback_url;
        ReturnUrl = return_url;
        CustomTitle = customTitle;
        CustomDescription = customDescription;
        CustomLogo = customLogo;
    }
}
