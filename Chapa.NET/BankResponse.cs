namespace ChapaNET;
public partial class Chapa
{
    class BankResponse
    {
        public string? message { get; set; }

        public IEnumerable<Bank>? data { get; set; }
    }
}

