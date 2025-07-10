using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        var address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        var customer1 = new Customer("John Doe", address1);
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25.00m, 2));

        // Customer 2 (International)
        var address2 = new Address("45 King St", "Toronto", "ON", "Canada");
        var customer2 = new Customer("Jane Smith", address2);
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "C789", 300.00m, 1));
        order2.AddProduct(new Product("Stylus", "D012", 15.00m, 3));

        // Display results
        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 40));
    }
}