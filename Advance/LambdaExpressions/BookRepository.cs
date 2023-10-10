using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "Bhagwat Gita",  Price = 299},
                new Book(){Title = "Ramayan",  Price = 499},
                new Book(){Title = "Mahabharat",  Price = 799},
                new Book(){Title = "Rich Dad Poor Dad",  Price = 125}
            };
        }
    }
}
