using System;
using System.Net.Sockets;
namespace OnlineOrdering;
public class Product
{
    private string _name;
    private string _id;
    private double _unitPrice;
    private int _quantity;
    public Product(string name, string id, double unitPrice, int quantity)
    {
        _name = name;
        _id = id;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }
    public double Total()
    {
        double  total = _unitPrice * _quantity;
        return total;
    }
    public string GetPackageInfo()
    {
        return $"Product Name: {_name} | Product ID: {_id} | Quantity: {_quantity} -- ";
    }
} 
