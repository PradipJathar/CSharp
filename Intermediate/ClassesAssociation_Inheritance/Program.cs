using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssociation_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            text.Height = 20;
            text.AddHyperLink("www.google.com");    // Own method.
            text.Copy();                            // Inheritaded method.
        }
    }
}
