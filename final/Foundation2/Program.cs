using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program 2: Encapsulation with Online Ordering");
        Console.WriteLine();

        List<Order> orders = new List<Order>();
        // Order 01
        Address addressOrder01 = new Address("120 Ocaña St", "Chacabuco", "Cordoba", "Argentina");
        Customer customer01 = new Customer("Jose Martinez", addressOrder01);
        List<Product> allProducts01 = new List<Product>();

        Product product01 = new Product("L1001", "Laptop", 799.99, 1);
        Product product02 = new Product("H1003", "Headphones", 85.70, 2);
        Product product03 = new Product("S1006", "Speaker", 129.99, 4);

        allProducts01.Add(product01);
        allProducts01.Add(product02);
        allProducts01.Add(product03);

        Order order01 = new Order(allProducts01, customer01);
        orders.Add(order01);

        // Order 02
        Address addressOrder02 = new Address("831 W Lancaster Blvd", "Lancaster", "California", "USA");
        Customer customer02 = new Customer("Erick Matts", addressOrder02);
        List<Product> allProducts02 = new List<Product>();

        Product product04 = new Product("T1007", "Tablet", 250, 3);
        Product product05 = new Product("S1008", "Smartwatch", 135.55, 2);
        Product product06 = new Product("C1006", "Camera", 599.99, 1);

        allProducts02.Add(product04);
        allProducts02.Add(product05);
        allProducts02.Add(product06);

        Order order02 = new Order(allProducts02, customer02);
        orders.Add(order02);

        // Order 02
        Address addressOrder03 = new Address("525 S Center St", "Rexburg", "Idaho", "USA");
        Customer customer03 = new Customer("Lara Mikeson", addressOrder03);
        List<Product> allProducts03 = new List<Product>();

        Product product07 = new Product("T1027", "Pencil Case", 5.50, 4);
        Product product08 = new Product("L1001", "Laptop", 799.99, 1);
        Product product09 = new Product("S1048", "Smartwatch", 135.55, 5);

        allProducts03.Add(product07);
        allProducts03.Add(product08);
        allProducts03.Add(product09);

        Order order03 = new Order(allProducts03, customer03);
        orders.Add(order03);

        int num = 0;
        foreach (Order order in orders)
        {
            num++;
            Console.WriteLine($"Online Order: 0{num}");
            Console.WriteLine();
            order.DisplayPackingShippingLabel();
            order.DisplayTotalBilling();
            Console.WriteLine();   
        }
    }
}