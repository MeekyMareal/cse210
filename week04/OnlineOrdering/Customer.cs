using System;
namespace OnlineOrdering;
public class Customer 
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsClientInUsa()
    {
        return _address.IsInUsa();
    }
    public string GetShipping()
    {
        return $"{_name}, {_address.GetAddress()}";
    }
}
