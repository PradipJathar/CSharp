using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAndTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime
            Console.WriteLine("DateTime");

            DateTime dateTime = new DateTime(1999, 03, 01);
            Console.WriteLine($"Birthday: {dateTime}");

            DateTime now = DateTime.Now;
            Console.WriteLine($"Now: {now}");

            DateTime today = DateTime.Today;
            Console.WriteLine($"Today: {today}");

            Console.WriteLine($"Now.Hour: {now.Hour}");
            Console.WriteLine($"Now.Minute: {now.Minute}");

            Console.WriteLine($"Now.ToLongDateString(): {now.ToLongDateString()}");
            Console.WriteLine($"Now.ToShortDateString(): {now.ToShortDateString()}");
            Console.WriteLine($"Now.ToLongTimeString(): {now.ToLongTimeString()}");
            Console.WriteLine($"Now.ToShortTimeString(): {now.ToShortTimeString()}");
            Console.WriteLine($"Now.ToString(): {now.ToString()}");
            Console.WriteLine($"Now.ToString(): {now.ToString("yyyy-MM-dd HH:mm")}");

            Console.WriteLine();

            // TimeSpan
            Console.WriteLine("TimeSpan");

            // TimeSpan - Creating
            TimeSpan timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine($"TimeSpan(1, 2, 3): {timeSpan}");

            TimeSpan timeSpan1 = new TimeSpan(1, 0, 0);
            Console.WriteLine($"TimeSpan(1, 0, 0): {timeSpan1}");

            TimeSpan timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine($"TimeSpan.FromHours(1): {timeSpan2}");

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(2);
            TimeSpan duration = end - start;
            Console.WriteLine($"DateTime.Now - DateTime.Now.AddMinutes(2): {duration}");

            // Properties
            Console.WriteLine($"timeSpan.Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"timeSpan.TotalMinutes: {timeSpan.TotalMinutes}");

            // Add / Subtract
            Console.WriteLine($"timeSpan.Add(TimeSpan.FromMinutes(8)): {timeSpan.Add(TimeSpan.FromMinutes(8))}");
            Console.WriteLine($"timeSpan.Subtract(TimeSpan.FromMinutes(8)): {timeSpan.Subtract(TimeSpan.FromMinutes(2))}");

            // ToString()
            Console.WriteLine($"timeSpan.ToString(): {timeSpan.ToString()}");

            // Parse
            Console.WriteLine($"TimeSpan.Parse(\"01:02:03\"): {TimeSpan.Parse("01:02:03")}");
        }
    }
}
