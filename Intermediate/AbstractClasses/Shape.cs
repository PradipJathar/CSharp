using System;

namespace AbstractClasses
{

    // Abstract Class:
    // Abstract Modifier - Indicates that a class or a member is missing implementation.
    // Abstract members does not include implementation, they will be implement in derived classes.
    // If a member is declared as abstract, the containing class needs to be declared as abstract too.
    // Derived classes must implement all abstract members in base abstract class.
    // Abstract class can not be instantiated.
    // Abstract class can have non abstract members.


    public abstract class Shape                                 // If a member is declared as abstract, the containing class needs to be declared as abstract too.
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void Draw();                            // Abstract members does not include implementation, they will be implement in derived classes.

        public void Copy()                                      // Abstract class can have non-abstract members.
        {
            Console.WriteLine("Copy shape into clipboard.");
        }
    }



    public class Circle : Shape
    {
        public override void Draw()                             // Derived classes must implement all abstract members in base abstract class.
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
}
