using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    // Lambda Expressions:
    // An anonymous method with no access modifier, no name, and no return statement.
    // args => expression

    // Lambda Expression Types:
    // 1. () => 2 * 3                                   --> Without arguments.
    // 2. x => x.Price * x.Quantity                     --> With one argument.
    // 3. (x, y, z) => x.Price + y.Price + z.Price      --> With multiple arguments.

    class Program
    {
        static void Main(string[] args)
        {
            
            Func<int, int> areaOfSquare = side => side * side;             // Lambda Expressions with delegate.
            Console.WriteLine($"Area of Square : {areaOfSquare(25)}");


            int rate = 10;
            int years = 3;

            Func<int, int> interest = principalAmount => principalAmount * rate * years;
            Console.WriteLine($"Interest Amount : {interest(10000)}");


            Console.WriteLine();


            List<Book> books = new BookRepository().GetBooks();
            List<Book> cheapBooks = books.FindAll(b => b.Price < 300);          // Lambda Expressions

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
