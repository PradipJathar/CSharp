using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable<DateTime> date = null;

            DateTime? date = null;                 // We can use DateTime? instead of Nullable<DateTime>
            DateTime date2;

            Console.WriteLine($"date.GetValueOrDefault(): {date.GetValueOrDefault()}");     // Get default date if date is null
            Console.WriteLine($"date.HasValue(): {date.HasValue}");
            // Console.WriteLine($"date.Value(): {date.Value}");     


            // Set Today if date is null

            // 1] Using normal way
            if (date != null)
            {
                date2 = date.GetValueOrDefault();
            }
            else
            {
                date2 = DateTime.Today;
            }


            // 2] Using ternary operator
            date2 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;


            // 3] Using Null Coalescing Operator
            date2 = date ?? DateTime.Today;

        }
    }
}
