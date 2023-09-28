using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            object obj = number;            // Boxing - Conversion of a value type to reference type.

            object obj1 = 20;
            int number1 = (int) obj1;       // Unboxing - Conversion of a reference type to value type.

        }
    }
}
