using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Pradip";
            Console.WriteLine(cookie["name"]);
        }
    }
}
