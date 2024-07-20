using System;

class Program
{
    static void Main(string[] args)
    {
        var order1 = new Order(
            new Customer("John Doe", new Address("123 Main St", "Anytown", "NY", "USA")),
            new List<Product>
            {
                new Product("Widget", "101", 19.99, 3),
                new Product("Whatzit", "102", 29.99, 1),
            }
        );

        var order2 = new Order(
            new Customer("Jane Smith", new Address("456 Elm St", "Othertown", "ON", "Canada")),
            new List<Product>
            {
                new Product("Thingamajig", "201", 39.99, 2),
                new Product("Whozit", "202", 9.99, 5),
            }
        );

        Console.WriteLine("Order 1\n--------");

        Console.WriteLine($"Packing Label:\n{order1.PackingLabel()}");

        Console.WriteLine($"\nShipping Label:\n{order1.ShippingLabel()}");

        Console.WriteLine($"\nTotal Cost: ${order1.TotalCost():0.00}");

        Console.WriteLine("\nOrder 2\n--------");

        Console.WriteLine($"Packing Label:\n{order2.PackingLabel()}");

        Console.WriteLine($"\nShipping Label:\n{order2.ShippingLabel()}");

        Console.WriteLine($"\nTotal Cost: ${order2.TotalCost():0.00}");
    }
}