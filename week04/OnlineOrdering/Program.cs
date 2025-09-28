using System;

class Program
{
    static void Main(string[] args)
    {
       
   
        // Customers and addresses
        Address addr1 = new Address("63rd St", "Chicago", "CH", "USA");
        Customer cust1 = new Customer("David Radcliff", addr1);

        Address addr2 = new Address("54 S ", "North Carolina", "NC", "USA");
        Customer cust2 = new Customer("Mary Williams", addr2);

        // Orders
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "LAP01", 2, 5));
        order1.AddProduct(new Product("Rose", "ROSE02", 2, 4));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Noodles", "NOODLES03", 7, 2));
        order2.AddProduct(new Product("Conditioner", "COND04", 4, 3));

        // Display orders
        order1.DisplayOrder();
        order2.DisplayOrder();
    }
}