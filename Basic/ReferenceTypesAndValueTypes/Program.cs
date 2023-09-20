using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types: (int, float, bool, char, struct)
            // When we copy the value type (a) to another variable (b),
            // New memory is created in stack for that variable (b) and a copy of value type (a) is stored in it (b).

            // when we change value of b it will not change the value of a.

            int a = 10;
            int b = a;
            b++;
            Console.WriteLine($"a:{a}, b:{b}\n");


            // Reference Types: (string, object, class, interface, delegate)
            // When we create the reference type (array1) the object is created in heap and
            // On runtime the address of that object is assign to the reference type (array1) as value in stack.

            // When we copy the reference type (array1) to another variable (array2),
            // The runtime create variable (array2) on the stack and
            // The value of reference type (array1) which is the address of (array1) object is assign to variable (array2) as value in stack.

            // When we change the value of array2 it chenges the value of object in heap which is also refered by array1.
            // Hence it changes value of array1 as well.

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[1] = 0;
            Console.WriteLine($"array1: {string.Join(", ", array1)}\narray2: {string.Join(", ", array2)}");



            // Stack Memory:
            // The stack is used for storing value types (e.g., integers, characters, booleans) and method call information.
            // It is a region of memory that operates in a last-in, first-out (LIFO) manner.
            // They are automatically deallocated when they go out of scope.
            // Stack memory is usually smaller in size compared to heap memory.


            // Heap Memory:
            // The heap is used for storing reference types (e.g., objects).
            // They are allocated explicitly using new or implicitly when an object is created.
            // This is typically handled by the garbage collector, which automatically reclaims memory from objects that are no longer reachable.



            // One More Example:

            int number = 1;
            Increment(number);                          // int number is value type it will not modify its value after visting Increment method.
            Console.WriteLine(number);

            Person person = new Person() { Age = 20 };
            MakeOld(person);                            // class person is reference type it will modify its value after visting MakeOld method.
            Console.WriteLine(person.Age);

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }

    public class Person
    {
        public int Age { get; set; }
    }
}
