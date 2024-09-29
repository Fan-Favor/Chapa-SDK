namespace ChapaNET;
public partial class Chapa
{
    public class ValidityReport
    {
        public bool IsSuccess => status == "success";
        public string message { get; set; }
        public string status { get; set; }
        public Data data { get; set; }
        public class Data
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string currency { get; set; }
            public double amount { get; set; }
            public double charge { get; set; }
            public string mode { get; set; }
            public string method { get; set; }
            public string type { get; set; }
            public string status { get; set; }
            public string reference { get; set; }
            public string tx_ref { get; set; }
            public Customization customization { get; set; }
            public object meta { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }

        public class Customization
        {
            public string title { get; set; }
            public string description { get; set; }
            public string logo { get; set; }
        }
    }
}

