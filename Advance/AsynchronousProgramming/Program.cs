using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{

    // Synchronous Program Execution:
    // - Program is executed line by line, one at a time.
    // - When function is called, program execution has to wait until the function returns.

    // Asynchronous Program Execution:
    // - When function is called, program execution continues to the next line, without waiting for the function to complete.
    // - It is used for accessing the web, working with files and databases, working with images.
    // - eg. Windows Media Player, Web Browser.

    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();


            // Asynchronous Method
            program.DownloadHtmlAsync("http://www.google.com");             // Program execution continues to the next line, without waiting for the function to complete.
            Console.WriteLine("Async Program Exexuted.");       

            Thread.Sleep(3000);
            Console.WriteLine("\n---------------------------\n");

            // Synchronous Method
            program.DownloadHtml("http://www.google.com");                  // Program execution has to wait until the function execute.
            Console.WriteLine("Program Exexuted.");
        }

        public async Task DownloadHtmlAsync(string url)                     // Use async while declearing Asynchronous method.
        {
            WebClient webClient = new WebClient();

            string html = await webClient.DownloadStringTaskAsync(url);     // Use await which will take more time for execution.

            Console.WriteLine(html.Substring(0, 50));
        }

        public void DownloadHtml(string url)
        {
            WebClient webClient = new WebClient();
            string html = webClient.DownloadString(url);
            Console.WriteLine(html.Substring(0, 50));
        }
    }
}
