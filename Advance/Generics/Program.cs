using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{    
    partial class Program
    {
        static void Main(string[] args) 
        {

            // Generic List
            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(1);
            numbers.Add(2);

            GenericList<Book> books = new GenericList<Book>();
            books.Add(new Book());


            // Generic Dictionary
            GenericDictionary<int, string> names = new GenericDictionary<int, string>();
            names.Add(1, "Pradip");
            names.Add(2, "Abhi");

            GenericDictionary<string, Book> myBooks = new GenericDictionary<string, Book>();
            myBooks.Add("Math", new Book());



            // Make int as nullable using "where T : struct"
            var num = new Nullable<int>();
            Console.WriteLine($"Has Value? : {num.HasValue}");
            Console.WriteLine($"Value : {num.GetValueOrDefault()}");

            var num1 = new Nullable<int>(5);
            Console.WriteLine($"Has Value? : {num1.HasValue}");
            Console.WriteLine($"Value : {num1.GetValueOrDefault()}");

        }


        // Constraints
        // where T : IComparable
        // where T : Product
        // where T : struct
        // where T : class
        // where T : new()


        // where T : IComparable
        public class Number<T> where T : IComparable
        {
            public T Max(T a, T b)
            {
                return a.CompareTo(b) > 0 ? a : b;
            }
        }


        // where T : Product
        public class DiscountCalculator<TProduct> where TProduct : Product
        {
            public float DiscountAmount(TProduct product)
            {
                return product.Price * 0.1f;                            // Lets say 10% discount
            }
        }


        // where T : struct
        public class Nullable<T> where T : struct
        {
            private object _value;

            public Nullable()
            {
            }

            public Nullable(T value)
            {
                _value = value;
            }

            public bool HasValue
            {
                get { return _value != null; }
            }

            public T GetValueOrDefault()
            {
                if (HasValue)
                {
                    return (T)_value;
                }

                return default(T);
            }
        }


        // where T : new()
        public class MyClass<T> where T : new()
        {
            public void DoSomething(T value)
            {
                var obj = new T();         // Here
            }
        }
    }
}
