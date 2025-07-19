using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Apple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B123", 12.99, 2));
        order1.AddProduct(new Product("Pen", "P456", 1.99, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        Address address2 = new Address("456 Mango Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "N789", 3.49, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
    }
}