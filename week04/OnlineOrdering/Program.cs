using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressUSA = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address addressNonUSA = new Address("456 State St", "Toronto", "ON", "Canada");
        Customer customerUSA = new Customer("Tom Cat", addressUSA);
        Customer customerNonUSA = new Customer("Peter Park", addressNonUSA);

        Product product1 = new Product("Laptop", "ABC-123", 599.99m, 1);
        Product product2 = new Product("Smartphone", "XYZ-456", 299.99m, 2);
        Product product3 = new Product("Headphones", "LMN-789", 99.99m, 3);
        Product product4 = new Product("Tablet", "DEF-012", 399.99m, 2);
        Product product5 = new Product("Monitor", "GHI-345", 199.99m, 2);
        Product product6 = new Product("Keyboard", "JKL-678", 49.99m, 1);
        Product product7 = new Product("Mouse", "MNO-901", 29.99m, 1);
        Product product8 = new Product("Printer", "PQR-234", 149.99m, 1);

        Order orderOne = new Order(customerUSA);
        orderOne.AddProduct(product1);
        orderOne.AddProduct(product2);
        orderOne.AddProduct(product3);
        orderOne.AddProduct(product4);

        Order orderTwo = new Order(customerNonUSA);
        orderTwo.AddProduct(product5);
        orderTwo.AddProduct(product6);
        orderTwo.AddProduct(product7);
        orderTwo.AddProduct(product8);

        Console.WriteLine("**** Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(orderOne.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(orderOne.GetShippingLabel());
        Console.WriteLine($"Total: ${orderOne.CalculateTotalCost():N2}");

        Console.WriteLine();
        Console.WriteLine("**** Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(orderTwo.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(orderTwo.GetShippingLabel());
        Console.WriteLine($"Total: ${orderTwo.CalculateTotalCost():N2}");
    }
}