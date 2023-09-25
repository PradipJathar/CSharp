using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();

            // Creating object of class using Default constructor
            Customer customer = new Customer();
            customer.Orders.Add(order);
            Console.WriteLine($"Id: {customer.Id}");
            Console.WriteLine($"Name: {customer.Name}");

            // Creating object of class using Constructor with one parameter
            Customer customer1 = new Customer(1);
            customer1.Orders.Add(order);
            Console.WriteLine($"Id: {customer1.Id}");
            Console.WriteLine($"Name: {customer1.Name}");

            // Creating object of class using Constructor with two parameter
            Customer customer2 = new Customer(2, "Pradip");
            customer2.Orders.Add(order);
            Console.WriteLine($"Id: {customer2.Id}");
            Console.WriteLine($"Name: {customer2.Name}");


            // Creating object of class using Constructor with Object Initializers.
            Customer customer3 = new Customer
                                    {
                                        Id = 3, 
                                        Name = "Abhi" 
                                    };
            customer3.Orders.Add(order);
            Console.WriteLine($"Id: {customer3.Id}");
            Console.WriteLine($"Name: {customer3.Name}");
        }
    }
}
