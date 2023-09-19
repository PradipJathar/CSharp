using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables:");

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Pradip";
            bool isWorking = false;
            
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("\nPlaceholders:");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            Console.WriteLine("\nConstants:");
            const float Pi = 3.14f;
            Console.WriteLine(Pi);
        }
    }
}
