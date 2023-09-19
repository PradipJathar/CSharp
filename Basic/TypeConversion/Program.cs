using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit Conversion:");
            byte b1 = 1;
            int i1 = b1;
            Console.WriteLine(i1);

            Console.WriteLine("\nExplicit Conversion:");
            int i2 = 1;
            byte b2 = (byte)i2;             // Use datatype infornt of variable for types conversion. 
            Console.WriteLine(b2);
             
            Console.WriteLine("\nNon Compatible Types Conversion:");
            string s = "123";
            int i = Convert.ToInt32(s);     // Use Convert class (Convert.ToInt32(s)) or Parse (int.Parse(s)) for type conversion.
            Console.WriteLine(i);
        }
    }
}
