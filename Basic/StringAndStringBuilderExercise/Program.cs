using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilderExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nPlease select valid option:");
            Console.WriteLine("1. Enter a few numbers separated by a hyphen. If the numbers are consecutive display a message: \"Consecutive\" otherwise, display \"Not Consecutive\".");
            Console.WriteLine("2. Enter a few numbers separated by a hyphen or Enter, without supplying an input to exit immediately. If there are duplicates display \"Duplicate\" on the console.");
            Console.WriteLine("3. Enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display \"Ok\"; otherwise, display \"Invalid Time\".");
            Console.WriteLine("4. Enter a few words separated by a space. Use the words to create a variable name with PascalCase.");
            Console.WriteLine("5. Enter an English word. Program will count the number of vowels (a, e, o, u, i) in the word.");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option <= 5)
            {
                switch (option)
                {
                    case 1:
                        {
                            Exercise1();
                        }
                        break;

                    case 2:
                        {
                            Exercise2();
                        }
                        break;

                    case 3:
                        {
                            Exercise3();
                        }
                        break;

                    case 4:
                        {
                            Exercise4();
                        }
                        break;

                    case 5:
                        {
                            Exercise5();
                        }
                        break;
                }

            }
            else
            {
                Console.WriteLine("Please select valid option between 1 to 5.");
            }

            Main(args);
        }

        private static void Exercise1()
        {
            Console.Write("Enter a few numbers separated by a hyphen (eg 1-2-3-4): ");
            string input = Console.ReadLine();

            string[] numberStr = input.Split('-');

            bool isConsecutive = true;

            for (int i = 0; i < numberStr.Length; i++)
            {
                if (i == numberStr.Length - 1)
                {
                    break;
                }

                int num1 = Convert.ToInt32(numberStr[i]);
                int num2 = Convert.ToInt32(numberStr[i + 1]);

                if (num1 + 1 != num2)                
                {
                    isConsecutive = false;
                    break;
                }              
            }

            string massage = isConsecutive ? "Consecutive." : "Not Consecutive.";

            Console.WriteLine(massage);
        }
    
        private static void Exercise2()
        {
            while (true)
            {
                Console.Write("Enter a few numbers separated by a hyphen (eg 1-2-3-4) or Enter without value to exit: ");
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                List<int> numbers = new List<int>();
                foreach (var number in input.Split('-'))
                {
                    numbers.Add(Convert.ToInt32(number));
                }

                List<int> uniqueNumbers = new List<int>(); 
                bool includesDuplicates = false;
                foreach (var number in numbers)
                {
                    if (uniqueNumbers.Contains(number))
                    {
                        includesDuplicates = true;
                        break;
                    }
                    else
                    {                   
                        uniqueNumbers.Add(number);
                    }
                }

                string massage = includesDuplicates ? "Contain Duplicates." : "Not Contain Duplicates.";

                Console.WriteLine(massage);
            }
        }

        private static void Exercise3()
        {
            Console.Write("Enter a time value in the 24-hour time format (e.g. 19:00): ");
            string input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time.");
                return;
            }

            try
            {
                DateTime time = Convert.ToDateTime(input);
                Console.WriteLine("Ok");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time.");
            }     
        }
    
        private static void Exercise4()
        {
            Console.Write("Enter a few words separated by a space: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            List<string> newWords = new List<string>();
            foreach (var word in words)
            {
                string newWord = word[0].ToString().ToUpper() + word.Substring(1).ToLower();
                newWords.Add(newWord);
            }

            Console.WriteLine(String.Join("", newWords));
        }
    
        private static void Exercise5()
        {
            Console.Write("Enter the word: ");
            string input = Console.ReadLine();

            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'};

            int vowelsCount = 0;
            foreach (var c in input.ToLower())
            {
                if (vowels.Contains(c))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine($"Number of vowels are {vowelsCount}.");
        }
    }
}
