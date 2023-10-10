using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    // LINQ
    // LINQ - Language Integrated Query.
    // LINQ gives you the capability to query objects.

    // You can query - 
    // 1. Objects in memory e.g Collections (LINQ to Objects)
    // 2. Database (LINQ to Entities)
    // 3. XMl (LINQ to XML)
    // 4. ADO.Net Data Sets (LINQ to Data Sets)

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Book> books = new BookRepository().GetBooks();


            // 1] LINQ using query operators

            Console.WriteLine("LINQ using query operators:");

            var cheaperBooks = from b in books                                      // LINQ using query operators.
                               where b.Price < 20
                               orderby b.Title
                               select b;

            foreach (var book in cheaperBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
            }


       
            // 2] LINQ using extension methods

            Console.WriteLine("\nLINQ using extension methods");

            var expensiveBooks = books.Where(b => b.Price > 20)                     // LINQ using extension methods.
                                  .OrderBy(b => b.Price)
                                  .Select(b => b);

            foreach (var book in expensiveBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
            }


            Console.WriteLine("\nbooks.Skip(2).Take(3)");

            var skipTwoTakeThree = books.Skip(2).Take(3);

            foreach (var book in skipTwoTakeThree)
            {
                Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
            }



            // More Extension Methods

            books.Where(b => b.Price > 20);
            books.Single(b => b.Price > 20);
            books.SingleOrDefault(b => b.Price > 20);

            books.First(b => b.Price > 20);
            books.FirstOrDefault(b => b.Price > 20);

            books.Last(b => b.Price > 20);
            books.LastOrDefault(b => b.Price > 20);

            books.Min(b => b.Price);
            books.Max(b => b.Price);
            books.Sum(b => b.Price);
            books.Average(b => b.Price);
            books.Count(b => b.Price > 20);

            books.Skip(2).Take(3);
        }
    }
}
