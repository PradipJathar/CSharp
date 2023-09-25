using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }


        // Default constructor
        public Customer()
        {
            this.Orders = new List<Order>();
        }


        // Constructor with one parameter
        public Customer(int id) : this()
        {
            this.Id = id;
        }


         // Constructor with two parameter
        public Customer(int id, string Name): this(id)
        {
            this.Name = Name;
        }
    }
}
