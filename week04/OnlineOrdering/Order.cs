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
        foreach(Product product in _products)
        {
            total += product.Total();
        }
        bool shipment = _customer.IsClientInUsa();
        double reduce = 5.0;
        double increase = 35.0;
        if (shipment == true)
        {
            return total + reduce;
        }
        else
        {
            return total + increase;
        }  
    }
    public string GetPackageDetails()
    {
        string label = "";
        foreach(Product product in _products)
        {
            label += product.GetPackageInfo();
        }
        return label;
    }
    public string GetShippingDetails()
    {
        return $"Shipping Details: {_customer.GetShipping()}";
    }
}
