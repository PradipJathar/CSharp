using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{

    class Program
    {
        static void Main(string[] args)
        {
            // Shape shape = new Shape();       // Abstract class can not be instantiated.

            Circle circle = new Circle();
            circle.Draw();                      // Draw() - Abstract Method.
            circle.Copy();                      // Copy() - Non-Abstract Method.


            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
            rectangle.Copy();

        }
    }
}
