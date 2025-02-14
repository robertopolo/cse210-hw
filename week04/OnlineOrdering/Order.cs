using System.ComponentModel;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double Total()
    {
        double totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if(_customer.IsFromUsa())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public void PackingLabel()
    {
        Console.Write("\n");
        Console.WriteLine("Packing label:");
        foreach(Product product in _products)
        {
            Console.WriteLine(product.GetPackingLabel());
        }
    }

    public void ShippingLabel()
    {
        Console.Write("\n");
        Console.WriteLine("Shipping label:");
        Console.WriteLine(_customer.GetShippingLabel());
    }
}