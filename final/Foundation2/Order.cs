using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalShipping() 
    {
        
        if (_customer.IsInUSA())
        {
            return 5;
        } 
        else
        {
            return 35;
        }
    }

    public double GetTotalPrice()
    {
        double totalprice = 0;
        foreach (Product product in _products) 
        {
            double price = product.GetQuantityPrice();
            totalprice += price;
        }
        totalprice += GetTotalShipping();
        return totalprice;
    }

    public string GetPackingLabel()
    {
        int num = 0;
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products) 
        {
            num++;
            packingLabel += $"{num}. ID: {product.GetProductId()} - Product: {product.GetName()} x {product.GetQuantity()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label:\nName: {_customer.GetName()}\nAddress: {_customer.GetCustomerAddress()}\n";
        return shippingLabel;
    }

    public void DisplayPackingShippingLabel()
    {
        Console.WriteLine(this.GetPackingLabel());
        Console.WriteLine(this.GetShippingLabel());
    }

    public void DisplayTotalBilling()
    {
        int num = 0;
        string totalBilling = "Final Price for Billing:\n";
        foreach (Product product in _products) 
        {
            num++;
            totalBilling += $"{num}. {product.GetProductId()} - {product.GetName()} \n   Price: ${product.GetPrice().ToString("00.00")} x {product.GetQuantity()}\n";
        }
        totalBilling += $"Shipping Cost: ${this.GetTotalShipping()}\nTotal Billing: ${this.GetTotalPrice().ToString("00.00")}";

        Console.WriteLine(totalBilling);
    }
}