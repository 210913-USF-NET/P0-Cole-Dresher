using System;

namespace Models
{
    public class Customer
    {
        //Type members: These are constructors

        //constructor overloading
        //example of polymorphism, the class 'customer' is being used in different ways in case the customer only enters "name"
        public Customer()
        {
            
        }

        public Customer(string name)
        {
            this.Name = name;
        }
        
        public Customer(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // constructor chaining - : this(name) calls name, then executes the rest
        // equivilent of having this.Name = name; with the rest
        // will chain between different constructors until it finds a fit for the data entered
        
        // public Customer(string name, int age) : this(name)
        // {
        //     this.Age = age;
        // }

        public string Name {get; set;}

        public int Age {get; set;}
    }
}