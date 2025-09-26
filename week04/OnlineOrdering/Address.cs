using System.Security.Authentication;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    public Address(string street, string city, string stateOrProvence, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvence;
        _country = country;
    }

    public bool IsUsa()
    {
        return _country == "USA";
    }

    public string MakeAddress()
    {
        return $"{_street}, {_city}, {_stateOrProvince}";
    }

    // Need Order.cs class
}