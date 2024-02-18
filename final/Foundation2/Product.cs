using System;

public class Product
{
    private string _prouctId;
    private string _name;
    private double _price;
    private int _quantity; // Is the quantity per product

    public Product(string productId, string name, double price, int quantity)
    {
        _prouctId = productId;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetProductId()
    {
        return _prouctId;
    }

    public void SetProductId(string productId)
    {
        _prouctId = productId;
    }
    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double GetQuantityPrice()
    {
        double totalPrice = _price * _quantity;
        return Math.Round(totalPrice, 2);
    }
}