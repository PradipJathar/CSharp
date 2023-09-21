using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nPlease select valid option:");
            Console.WriteLine("1. Number of people who like your facebook post. Enter different names, until the user presses Enter without supplying a name.");
            Console.WriteLine("2. Reverse the name.");
            Console.WriteLine("3. Enter 5 unique numbers, sort them and display the result on the console.");
            Console.WriteLine("4. Continuously enter a number may include duplicates or type \"Quit\" to exit. Display the unique numbers.");
            Console.WriteLine("5. Supply a list of comma separated numbers, display \"Invalid List\" when list is empty or includes less than 5 numbers otherwise, display the 3 smallest numbers.");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option <= 5)
            {
                switch (option)
                {
                    case 1:
                        {
                            List<string> names = new List<string>();

                            while (true)
                            {
                                Console.Write("Enter Friend's Name: ");

                                string name = Console.ReadLine();

                                if (name == "")
                                {
                                    break;
                                }

                                names.Add(name);
                            }

                            if (names.Count == 0)
                            {
                                Console.WriteLine("No one like your post.");
                            }
                            else if (names.Count == 1)
                            {
                                Console.WriteLine($"{names[0]} likes your post.");
                            }
                            else if (names.Count == 2)
                            {
                                Console.WriteLine($"{names[0]} and {names[1]} like your post.");
                            }
                            else 
                            {
                                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
                            }
                        }
                        break;


                    case 2:
                        {
                            Console.Write("Enter your name: ");
                            var name = Console.ReadLine();

                            var array = new char[name.Length];

                            for (int i = name.Length; i > 0; i--)
                            {
                                array[name.Length - i] = name[i - 1];
                            }

                            var reversedName = new string(array);

                            Console.WriteLine($"Your reversed name: {reversedName}");
                        }
                        break;


                    case 3:
                        {
                            List<int> numbers = new List<int>();

                            while (numbers.Count < 5)
                            {
                                Console.Write("Enter a number: ");
                                int number = Convert.ToInt32(Console.ReadLine());

                                if (numbers.Contains(number))
                                {
                                    Console.WriteLine($"You have previously enterd {number}");
                                    continue;
                                }

                                numbers.Add(number);
                            }

                            numbers.Sort();

                            foreach (var n in numbers)
                            {
                                Console.WriteLine(n);
                            }
                        }
                        break;


                    case 4:
                        {
                            List<int> numbers = new List<int>();

                            while (true)
                            {
                                Console.Write("Enter a number (or 'Quit' to exit): ");
                                var input = Console.ReadLine();

                                if (input.ToLower() == "quit")
                                {
                                    break;
                                }

                                numbers.Add(Convert.ToInt32(input));
                            }

                            List<int> uniqueNumbers = new List<int>();

                            foreach (var number in numbers)
                            {
                                if (!uniqueNumbers.Contains(number))
                                {
                                    uniqueNumbers.Add(number);
                                }
                            }

                            Console.WriteLine("Unique numbers are as follows");
                            foreach (var number in uniqueNumbers)
                            {
                                Console.WriteLine(number);
                            }
                        }
                        break;


                    case 5:
                        {
                            Console.Write("Enter comma separated numbers: ");
                            var input = Console.ReadLine();

                            
                            if (String.IsNullOrWhiteSpace(input))
                            {

                                Console.WriteLine("Invalid list.");
                            }
                            else
                            {
                                string[] elements = input.Split(',');

                                if (elements.Length > 5)
                                {
                                    Console.WriteLine("Inavalid list.");
                                }
                                else
                                {
                                    List<int> numbers = new List<int>();
                                    foreach (var number in elements)
                                    {
                                        numbers.Add(Convert.ToInt32(number));
                                    }

                                    List<int> smallests = new List<int>();
                                    while (smallests.Count < 3)
                                    {
                                        var min = numbers[0];

                                        foreach (var number in numbers)
                                        {
                                            if (number < min)
                                            {
                                                min = number;
                                            }
                                        }

                                        smallests.Add(min);
                                        numbers.Remove(min);
                                    }

                                    Console.WriteLine("Three smallest numbers are ");
                                    foreach (var number in smallests)
                                    {
                                        Console.WriteLine(number);
                                    }
                                }
                            }

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
    }
}
