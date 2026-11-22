using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}

Online Ordering Start

Address 
private string _street
private string _city
private string _state
private string _country
public Address(string street, string city, string state, string country)
public bool inUsa()
public string GetAddress()

Product 
private string _name
private string _id
private double _unitPrice
private int _quantity
public Product(string name, string id, double unitPrice, int quantity)
public double Total()
public string GetPackageDetails()


Customer 
private string _name to
private Address _address
public Customer(string name, Address address)
public bool ClientInUsa()
public string GetShippingDetails()


Order
private List<Product> _products
private Customer _customer
public Order(Customer customer)
public void AddProduct(Product product)
public double totalCost()
public string GetPackageDetails()
public string GetShippingDetails()

Ordering online Ends
Copyright 2026 BYU-Pathway Worldwide