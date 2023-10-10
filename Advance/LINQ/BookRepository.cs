using System.Collections.Generic;

namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "The Ultimate C# Series", Price = 10},
                new Book() {Title = "The Complete ASP.NET MVC 5 Course", Price = 29.99f},
                new Book() {Title = "Entity Framework In Depth The Complete Guide", Price = 24.99f},
                new Book() {Title = "Complete SQL Mastery", Price = 15},
                new Book() {Title = "The Ultimate Git Mastery", Price = 8}
            };
        }
    }
}
