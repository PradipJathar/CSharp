using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine(a + b * c);

            Console.WriteLine("\nComparison Operators:");
            Console.WriteLine(a > b);

            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine(c > b && c > a);
        }
    }
}
