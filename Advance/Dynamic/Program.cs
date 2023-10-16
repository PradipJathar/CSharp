using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    // Programming Languages:

    // 1] Statically-typed languages - C#, Java.
    //    - Type resolution - at compile-time.
    //    - Benefits - early feedback (at compile-time).

    // 2] Dynamically-typed languages - Ruby, JavaScript, Python.
    //    - Type resolution - at run-time.
    //    - Benefits - easier and faster to code.


    // C# History:
    // - Started as static language
    // - .NET 4 added the dynamic capability, to improve interoperability with
    //   -- COM (eg. writing office applications)
    //   -- Dynamic languages (IronPython)

    class Program
    {
        static void Main(string[] args)
        {

            // dynamic type examples

            dynamic name = "Pradip";        // At run time we can change datatype of variables using dynamic keyword.
            name = 10;
            name = 'P';
            name = true;


            dynamic a = 10;                 // As a and b are dynamic types, c will also become dynamic type.
            dynamic b = 5;
            var c = a + b;


            int i = 5;
            dynamic d = i;                  // we can implicitly cast any datatypes to dynamic
            long l = d;                     
        }
    }
}
