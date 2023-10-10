using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoProcessor processor = new PhotoProcessor();
            PhotoFilters filters = new PhotoFilters();

            // 1] User defined delegate.

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;      // Adding methods in delegate.
            filterHandler += filters.Resize;

            processor.Process("photo.jpg", filterHandler);


            Console.WriteLine();


            // 2] .Net predefined delegates.

            Action<Photo> actionFilterHandler = filters.ApplyContrast;                      // Adding methods in predefined delegate.
            actionFilterHandler += filters.ApplyBrightness;
            actionFilterHandler += filters.Resize;

            processor.Process("photo.jpg", actionFilterHandler);

        }
    }
}
