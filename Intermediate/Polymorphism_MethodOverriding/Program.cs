using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method Overriding - Modifying implementation of an inherited method.

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            Canvas canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
