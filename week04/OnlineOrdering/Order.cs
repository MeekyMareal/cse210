using System;
using System.Collections.Generic;
namespace OnlineOrdering;
public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double TotalCost()
    {
        double total = 0;
        foreach(Product products in _products)
        {
            total += products.Total();
        }
        bool shipment = _customer.ClientInUsa();
        double reduceFee = 5.0;
        double increaseFee = 5.0;
        if (shipment == true)
        {
            return total + reduceFee;
        }
        else
        {
            return total + increaseFee;
        }
        
    }
    public string GetPackageDetails()
    {
        string label = "";
        foreach(Product products in _products)
        {
            label += products.GetPackageInfo();
        }
        return label;
    }
    public string GetShippingDetails()
    {
        return $"Shipping Details: {_customer.GetShippingDetail()}";
    }
}
