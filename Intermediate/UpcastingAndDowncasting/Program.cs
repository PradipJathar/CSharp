using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Shape shape = circle;                   // Upcasting - Conversion form a derive class to a base class.

            Shape shape1 = new Circle();
            Circle circle1 = (Circle) shape1;       // Downcasting - Conversion form a base class to a derive class.

            shape1.X = 100;
            circle1.X = 200;

            Console.WriteLine($"Shape X: {shape1.X}");
            Console.WriteLine($"Circle X: {circle1.X}");    // Both shape and circle share same object (Refrence Types) so they print same value.


            Circle circle2 = shape1 as Circle;      // As - Try to convert shape to circle if possible otherwise return null.

            if (circle2 != null)
            {
                // ....
            }
            
        }
    }
}
