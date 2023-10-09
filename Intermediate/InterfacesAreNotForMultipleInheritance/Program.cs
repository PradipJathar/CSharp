using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAreNotForMultipleInheritance
{

    // Notes:
    // Multiple inheritance is not supported in C#.
    // In case of Inheritance - Class inherits the members form base class.
    // In case of Interfaces - Class implements all the members of interface.
    // Interfaces are not used for implementing multiple inheritance.
    // Interfaces are use for loosely coupled, extensible, and tastable applications. 

    public class Text : UiControl, IDroppable, IDraggable       // Multiple inheritance is not supported in C#. Interfaces are not used for implementing multiple inheritance.
    {
        public void Drag()
        {
            Console.WriteLine("Drag");
        }

        public void Drop()
        {
            Console.WriteLine("Drop");
        }
    }

    public class UiControl
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            Console.WriteLine("Shape Drawn");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
