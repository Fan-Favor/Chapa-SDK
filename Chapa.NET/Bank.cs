namespace ChapaNET;

public class Bank
{
    public string ID;
    public string SwiftCode;
    public string Name;
    public int AccLen;
    public int CountryID;
    public Bank(string id, string swift, string name, int accLen, int country_id)
    {
        ID = id;
        SwiftCode = swift;
        Name = name;
        AccLen = accLen;
        CountryID = country_id;
    }
    public override string ToString()
    {
        return
        $@"ID: {ID}
Name: {Name}
Swift Code: {SwiftCode}
AcctLen: {AccLen}
Country ID: {CountryID}";
    }
}

