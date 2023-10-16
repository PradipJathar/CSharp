using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            // Example 1

            StreamWriter streamWriter = null;

            try
            {
                Calculator calculator = new Calculator();
                int result = calculator.Divide(5, 0);

                streamWriter = new StreamWriter(@"c:\path.txt");
                streamWriter.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)                                // We can use more than one catch block for form more specific exception to more generic exception.
            {                                                               // Only one catch block will exicute at a time.
                Console.WriteLine("You cannot divide by 0.");               
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Got arithmetic exception.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occured.");
            }
            finally                         // In finally block, Code always executes, even if an exception is thrown.
            {                               // Uses of the finally block is to ensure that resources like files, database connections, network sockets, or other unmanaged resources are properly released, closed, or disposed.
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }                
            }



            // Example 2 - Custom Exception and Inter Expansion

            try
            {
                YouTubeApi api = new YouTubeApi();
                List<Video> videos = api.GetVideos("Pradip");
            }
            catch (Exception ex)                                            // Add watch on ex and we can see the InnerException.
            {
                Console.WriteLine("Sorry, an unexpected error occured.");
            }



            // Using Block:
            // The using statement is used to ensure that resources are properly disposed of when they are no longer needed.
            // When the code block within the using statement is exited, the Dispose method of the resource is automatically called, releasing any associated unmanaged resources.
            // Unmanaged resources - files, database connections, network sockets.

            using (StreamReader streamReader = new StreamReader(@"c:\path.txt"))   
            {
                string content = streamReader.ReadToEnd();                
            }

            // After using block streamReader.Dispose() is automatically called.

        }
    }
}
