using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Pradip";
            string lastName = "Jathar";

            var fullName = firstName + " " + lastName;                      // String concatenation using +.
            fullName = string.Concat(firstName, lastName);                  // String concatenation using Concat.
            fullName = string.Format("{0} {1}", firstName, lastName);       // String formatting.
            fullName = $"{firstName} {lastName}";                           // String interpolation

            Console.WriteLine(fullName);

            var names = new string[4] { "PJ", "AK", "RA", "RK" };
            string allNames = string.Join(", ", names);                     // String join.
            Console.WriteLine(allNames);

            var text = "Hi Pradip,\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";     // String with escape characters.
            Console.WriteLine(text);

            text = @"Hi Pradip,                                                             
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";                                                        // Verbatim string.

            Console.WriteLine(text);

        }
    }
}
