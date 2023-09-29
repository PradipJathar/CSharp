using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{

    // Sealed Classes:
    // If Sealed applied to a class, prevents derivation from that class.
    // If Sealed applied to a method, prevents overriding of that method in a derived class.
    // The string class is declared as sealed, and that’s why we cannot inherit from it.


    // Sealed Classes
    public sealed class MathSealed                  // If Sealed keyword applied to a class, prevents derivation from that class.
    {
        public void Add()
        {
        }
    }

    //public class Operation : MathSealed           // Prevents derivation from Sealed class (MathSealed).
    //{
    //}



    public class Math
    {
        public virtual void Add()
        {
        }
    }
    
    public class Operation1 : Math
    {
        public sealed override void Add()           // In case of method, sealed keyword is applied on override method.                
        {
        }
    }

    //public class Operation2 : Operation1
    //{
    //    public override void Add()                // If Sealed applied to a method, Prevents overriding of Add() method in a derived class.    
    //    {
    //    }
    //}


    class Program 
    {
        static void Main(string[] args)
        {
        }
    }
}
