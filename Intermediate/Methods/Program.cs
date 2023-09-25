using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method overloading
            UsePoint();

            // Param modifier
            UseParams();

            // Out modifier
            UseOut();
        }


        public static void UsePoint()
        {
            // Method Overloading

            Point point = new Point(10, 20);
            point.Move(new Point(50, 100));
            Console.WriteLine($"New Point: ({point.X}, {point.Y}).");

            point.Move(200, 300);
            Console.WriteLine($"New Point: ({point.X}, {point.Y}).");
        }


        public static void UseParams()
        {
            // params modifier as argument
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6}));

        }


        public static void UseOut()
        {
            // out modifier as argument

            //var number = int.Parse("abc"); // error

            int number = 0;

            bool result = int.TryParse("123", out number);

            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

    }    
}
