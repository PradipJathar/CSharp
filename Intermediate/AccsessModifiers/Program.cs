using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccsessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.Promote();                             // Public - Promote() method is decleared as Public so it can be accessible form everywhere.

            // customer.CalculateRating();                  // Private - CalculateRating() method is decleared as Private so it accessible only in the same class.

            // int offer = customer.OfferPercentage();      // Protected - OfferPercentage() method is decleared as Protected so it accessible only in the same class and its derived class.


            AccessModifiersAndProperties.Person person = new AccessModifiersAndProperties.Person(new DateTime(2023, 09, 28));

            DateTime birthday = person.Birtdate;            // Birthdate is Public property, so it can be accessible form different assembly. 

            // int age = person.Age;                        // Internal - Age is Internal property, so it can not accessible in different assembly. 
        }
    }
}
