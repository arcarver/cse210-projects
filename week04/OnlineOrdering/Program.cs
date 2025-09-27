using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        //order info
        Product product1 = new Product("apples", "a124", 1.59, 7);
        Product product2 = new Product("banana", "k557", 2.13, 4);
        Product product3 = new Product("pickleball racket", "b547", 5.79, 6);
        Product product4 = new Product("puzzle", "p324", 12.78, 1);
        Product product5 = new Product("chair", "q784", 2.21, 3);
        Product product6 = new Product("wrench", "k576", 6.15, 8);
        Product product7 = new Product("t shirt", "l578", 19.18, 1);

        //customer address
        Address address1 = new Address("548 Curtis Ave.", "Olympia", "Washington", "USA");
        Address address2 = new Address("547 Cherry Cirle", "Paris", "Bordeoux", "France");
        Address address3 = new Address("12 Round Street", "Berlin", "Saxon", "Germany");
        Address address4 = new Address("74 Cactus Rd.", "Mexico City", "Ojaxa", "Mexico");
        Address address5 = new Address("957 Miller Lane", "Columbus", "Ohio", "USA");
        Address address6 = new Address("65 Red Butte Circle", "Vancouver", "Ontario", "Canada");
        Address address7 = new Address("74 Baker Street", "Orem", "Utah", "USA");

        //customer info
        Customer customer1 = new Customer("Sue Shellton", address1);
        Customer customer2 = new Customer("Daryl Jones", address2);
        Customer customer3 = new Customer("Walter Cronkite", address3);
        Customer customer4 = new Customer("Stephen King", address4);
        Customer customer5 = new Customer("Dianna Wynden", address5);
        Customer customer6 = new Customer("Linden Gilbert", address6);
        Customer customer7 = new Customer("Bridget Lorder", address7);


    }
}