using System;

class Product
{
    private string _productName;
    private string _productID;
    private decimal _price;
    private int _quantity;
    private decimal _totalPrice;

    public Product(string productName, string productID, decimal price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
        _totalPrice = price * quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public void SetProductID(string productID)
    {
        _productID = productID;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
        _totalPrice = _price * _quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
        _totalPrice = _price * _quantity;
    }

    public decimal GetProductTotalCost()
    {
        return _totalPrice;
    }
}