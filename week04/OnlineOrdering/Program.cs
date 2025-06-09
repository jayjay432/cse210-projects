using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Order 1 (USA)
        Address addr1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "LP100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 25.50, 2));

        // Order 2 (International)
        Address addr2 = new Address("456 Rue de Paris", "Paris", "Île-de-France", "France");
        Customer cust2 = new Customer("Marie Curie", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Notebook", "NB300", 3.75, 5));
        order2.AddProduct(new Product("Pen Set", "PN400", 12.40, 1));

        // Display orders
        List<Order> orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}\n");
        }
    }
}