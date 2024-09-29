//Import Chapa.NET
using ChapaNET;

//Initialize your Chapa Instance
string APIKEY = "CHASECK_TEST-dHB0y8EqWxjR7FoWzmXZFLVP2nSmiycF";
Chapa chapa = new(APIKEY);

//Get a unique transaction ID
var ID = Chapa.GetUniqueRef();


//Get Banks
//Console.WriteLine("-----Fetching Banks------");
//await chapa.GetBanksAsync();
//var banks = await chapa.GetBanksAsync();
//Console.WriteLine(string.Join("\n------",banks.AsEnumerable()));

//Make a request

Console.WriteLine("-----Making A Request------");
var Request = new ChapaRequest(
    amount: 100,
    tx_ref: ID,
    phoneNo: "0910737676"
    );


//Process the request and get a response asynchronously
var Result = await chapa.RequestAsync(Request);



//Print out the checkout link
Console.WriteLine("Checkout Url:" + Result.Data!.checkout_url);


//Wait for validation
Console.WriteLine("----Press Any Key To Validate Transaction----");
Console.ReadKey();


//Verify Transaction - temporarly not working
Console.WriteLine("-----Verifying Transaction------");
var validity = await chapa.VerifyAsync(ID);
Console.WriteLine("Validity: " + validity == null?"Error!":validity?.status);