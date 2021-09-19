using System;
using Models;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cat Facts LLC.");
            Customer newCustomer = new Customer();
            newCustomer.Name = "Default";
            newCustomer.Age = 1000;
            Console.WriteLine("Enter username:");

            string username = Console.ReadLine();
            //TODO implement
            Customer customer = GetOrCreateCustomer(username);
            
            StoreFront myStore = new StoreFront () {
                Name = "Goofball's Fine Goods",
                Address = "Goofball Ave., Vanadzor, Azerbaijan"
            };

            Console.WriteLine("[1] Place an order");
            Console.WriteLine("[2] View order history");
            Console.WriteLine("[3] Select store location");
            Console.WriteLine("[x] Exit");

            Console.WriteLine(myStore.ToString());
            myStore.Name = Console.ReadLine();
            Console.WriteLine(myStore.ToString());
        }
    }
}