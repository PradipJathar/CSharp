using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // if-else

            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour > 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }



            // conditional operator 

            bool isGoldCustomer = true;

            int price = isGoldCustomer ? 20 : 30;

            Console.WriteLine(price);



            // switch-case

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }



        }
    }
}
