using System;
using Models;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my store!");
            Customer newCustomer = new Customer();
            newCustomer.Name = "Goofball";
            newCustomer.Age = 1000;
            
            StoreFront myStore = new StoreFront () {
                Name = "My Store",
                Address = "Goofball Ave., Vanadzor, Azerbaijan"
            };

            Console.WriteLine(myStore.ToString());
            myStore.Name = Console.ReadLine();
            Console.WriteLine(myStore.ToString());
        }
    }
}