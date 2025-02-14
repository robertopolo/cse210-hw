using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Calgary", "Alberta", "Canadá");
        Customer customer1 = new Customer("José Mendez", address1);
        List<Product> productsOrder1 = new List<Product>();
        productsOrder1.Add(new Product("Laptop", "LPTP-001", 1800, 1));
        productsOrder1.Add(new Product("Smartphone", "SP-001", 1000, 1));
        productsOrder1.Add(new Product("Tablet", "TBLT-001", 500, 2));
        Order order1 = new Order(customer1, productsOrder1);

        order1.PackingLabel();
        order1.ShippingLabel();
        Console.WriteLine($"Total: ${order1.Total():0.00}");

        Address address2 = new Address("456 Florence Street", "Salt Lake City", "Utah", "USA");
        Customer customer2 = new Customer("Cole Rowley", address2);
        List<Product> productsOrder2 = new List<Product>();
        productsOrder2.Add(new Product("SmarTV", "SMRTV-001", 850, 2));
        productsOrder2.Add(new Product("Headphone Bluetooth", "HPBT-001", 59.95, 3));
        productsOrder2.Add(new Product("Smartwatch", "SMRTW-001", 39.99, 3));
        Order order2 = new Order(customer2, productsOrder2);

        order2.PackingLabel();
        order2.ShippingLabel();
        Console.WriteLine($"Total: ${order2.Total():0.00}");
    }
}