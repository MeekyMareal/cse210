using System;
using System.Collections.Generic;
namespace OnlineOrdering 
{

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("4844 Birch Avenue", "Duluth", "Minnesota", "USA");
        Customer customer1 = new Customer("George Ekpo", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "MK-101", 24.50, 2));
        order1.AddProduct(new Product("Anti Blue Light", "MK-204", 15.00, 1));
        order1.AddProduct(new Product("USB-C Cable", "MK-309", 9.99, 3));
        orders.Add(order1);

        Address address2 = new Address("Ikpokpan Close", "Benin", "Edo State", "Nigeria");
        Customer customer2 = new Customer("Joshua Ekpo", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mechanical Keyboard", "MK-410", 79.00, 1));
        order2.AddProduct(new Product("Laptop Stand", "MK-512", 32.50, 2));
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackageDetails());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingDetails());
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${order.TotalCost()}");
            Console.WriteLine();
        }
    }
}
}