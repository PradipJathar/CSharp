using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    // Extension Methods
    // Allow us to add methods to an existing class without
    // - Changing its source code or
    // - Creating a new class that inherits form it.

    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be very very very long post.";

            string shortPost = post.Shorten(5);                                // Shorten() - Extension Methods

            Console.WriteLine(shortPost);
        }
    }
}
