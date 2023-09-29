using System;

namespace Polymorphism_MethodOverriding
{

    // For Method Overriding use virtual keyword with base class method and override keyword with derived class method.

    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {

        }
    }


    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle.");
        }
    }


    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle.");
        }
    }


    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle.");
        }
    }
}
