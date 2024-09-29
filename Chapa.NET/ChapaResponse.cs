using Newtonsoft.Json;

namespace ChapaNET;

public class ChapaResponse
{
    public string? Message { get; set; }
    public string? Status { get; set; }
    public Data? Data { get; set; } = new();
    public override string ToString() => JsonConvert.SerializeObject(this);
}
public class Data
{
    public string? checkout_url { get; set; }
}