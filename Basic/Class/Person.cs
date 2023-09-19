using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi, My name is {FirstName} {LastName}.");
        }
    }
}
