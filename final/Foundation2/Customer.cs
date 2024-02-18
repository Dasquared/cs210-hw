using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer()
    {
        _customerName = "N/A";
    }

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string GetName()
    {
        return _customerName;
    }
    public void SetName(string name)
    {
        _customerName = name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUsa();
    }

    public string GetCustomerAddress()
    {
        return _address.GetAddress();
    }
}