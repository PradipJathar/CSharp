using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(new DateTime(1999, 03, 01));

            // person.Birtdate = new DateTime(1999, 03, 01);        // Not allowed to set birthdate because of private setter

            Console.WriteLine(person.Age);

            // person.Age = 23;            //  Age became readonly because setter is not declared for age.
        }
    }
}
