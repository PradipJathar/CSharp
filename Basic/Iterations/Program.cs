using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop

            for (int i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }



            // foreach loop

            var name = "Pradip Jathar";

            foreach (var c in name)
            {
                Console.WriteLine(c);
            }



            // while loop

            int j = 1;
            
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }

                j++;
            }



            // do while loop

            int k = 105;

            do
            {
                Console.WriteLine(k);
            } while (k < 100);



            // random class

            Console.Write("Random Numbers: ");
            var randomNumber = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(randomNumber.Next(0, 9));
            }

            Console.Write("\nRandom Characters: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write((char)(randomNumber.Next(97, 122)));
            }

            Console.WriteLine();

        }
    }
}
