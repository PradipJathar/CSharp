using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);                 // enum to int
            Console.WriteLine(method.ToString());           // enum to string

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);    // int to enum

            var methodName = "RegularAirMail";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);    // string to enum
            Console.WriteLine((int)shippingMethod);         // enum to int
        }
    }
}
