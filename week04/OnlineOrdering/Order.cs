using System;

class Order
{
    private List<Product> _productsList;
    private Customer _customer;
    private decimal _shippingCost;
    private decimal _orderTotalCost;

    public Order(Customer customer)
    {
        _productsList = new List<Product>();
        _customer = customer;
        _shippingCost = CalculateShippingCost();
        _orderTotalCost = _shippingCost;
    }

    public decimal CalculateShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public void AddProduct(Product product)
    {
        _productsList.Add(product);
        _orderTotalCost += product.GetProductTotalCost();
    }

        public decimal CalculateTotalCost()
    {
        return _orderTotalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _productsList)
        {
            packingLabel += $"- {product.GetProductName()} ({product.GetProductID()})\n";
        }

        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = $"{_customer.GetCustomerName()}\n";
        shippingLabel += $"{_customer.GetCustomerDisplayAddress()}\n";

        return shippingLabel;
    }


}