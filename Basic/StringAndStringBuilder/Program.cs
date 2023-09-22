using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // String 
            Console.WriteLine("String");

            string fullName = "Pradip Jathar ";
            Console.WriteLine($"fullName: {fullName}");
            Console.WriteLine($"Trim: {fullName.Trim()}");
            Console.WriteLine($"ToUpper: {fullName.Trim().ToUpper()}");
            Console.WriteLine($"ToLower: {fullName.Trim().ToLower()}");

            int index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, index);
            string lastName = fullName.Substring(index + 1);
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");

            string[] names = fullName.Split(' ');
            Console.WriteLine($"First Name: {names[0]}");
            Console.WriteLine($"Last Name: {names[1]}");

            Console.WriteLine($"Replace: {fullName.Replace("Pradip", "Mr. Pradip")}");

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid.");
            }

            string ageStr = "25";

            byte age = Convert.ToByte(ageStr);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C4"));
            Console.WriteLine(price.ToString("C0"));

            Console.WriteLine();

            // Summerize Text
            Console.WriteLine("Summerize Text");
            string sentence = "This is very very very very evry long text.";
            string summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

            Console.WriteLine();

            // String Builder
            Console.WriteLine("String Builder");

            var builder = new StringBuilder();

            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine($"First Char: {builder[0]}");
        }
    }
}
