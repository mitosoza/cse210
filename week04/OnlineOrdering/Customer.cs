using System;

class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _customerAddress = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }

    public void SetCustomerAddress(Address customerAddress)
    {
        _customerAddress = customerAddress;
    }

    public string GetCustomerDisplayAddress()
    {
        return _customerAddress.GetFullAddress();
    }

    public bool LivesInUSA()
    {
        return _customerAddress.IsInUSA();
    }
}