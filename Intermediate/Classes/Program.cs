using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object
            Person person = new Person();
            person.Name = "Pradip";
            person.Introduce("Abhi");


            // Parse to person
            Person p = Person.Parse("Rohan");
            p.Introduce("Abhi");
        }
    }
}
