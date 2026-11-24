using System;
namespace OnlineOrdering;
public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;
    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public double Total()
    {
        double  total = _price * _quantity;
        return total;
    }
    public string GetPackageInfo()
    {
        return $"Product Name: {_name} | Product ID: {_id} | Quantity: {_quantity} -- ";
    }
} 
