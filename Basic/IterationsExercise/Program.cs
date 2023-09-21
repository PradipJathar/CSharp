using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nPlease select valid option:");
            Console.WriteLine("1. Disply count of numbers between 1 and 100 are divisible by 3 with no remainder.");
            Console.WriteLine("2. Continuously ask the user to enter a number or \"ok\" to exit. Calculate the sum of all the previously entered numbers and display it on the console.");
            Console.WriteLine("3. Ask the user to enter a number. Compute the factorial of the number and print it on the console.");
            Console.WriteLine("4. Ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console.");
            Console.WriteLine("5. Program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display \"You won\"; otherwise, display \"You lost\".\n");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option <= 5)
            {
                switch (option)
                {
                    case 1:
                        {
                            int count = 0;
                            for (int i = 1; i <= 100; i++)
                            {
                                if (i % 3 == 0)
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine(count);
                        }
                        break;


                    case 2:
                        {
                            int sum = 0;
                            while (true)
                            {
                                Console.Write("Enter number: ");
                                var input = Console.ReadLine();

                                if (input == "ok")
                                {
                                    Console.Write($"Sum of all entered number: {sum}.");
                                    break;
                                }
                                sum += Convert.ToInt32(input);
                            }                           
                        }
                        break;


                    case 3:
                        {
                            Console.Write("Enter the the number to calculate it's factorial: ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            var factorial = 1;

                            for (int i = 1; i <= number; i++)
                            {
                                factorial *= i;
                            }

                            Console.WriteLine($"{number}! = {factorial}");
                        }
                        break;


                    case 4:
                        {
                            Console.Write("Enter a series of numbers separated by comma: ");
                            var input = Console.ReadLine();

                            var numbers = input.Split(',');

                            var max = Convert.ToInt32(numbers[0]);

                            foreach (var str in numbers)
                            {
                                var number = Convert.ToInt32(str);

                                if (number > max)
                                {
                                    max = number;
                                }
                            }

                            Console.WriteLine($"Max number is {max}.");
                        }
                        break;


                    case 5:
                        {
                            var number = new Random().Next(1, 10);                                                   

                            for (int i = 0; i < 4; i++)
                            {
                                Console.Write("Guess the secret number: ");

                                var guess = Convert.ToInt32(Console.ReadLine());

                                if (guess == number)
                                {
                                    Console.WriteLine("You Won!");
                                    return;
                                }
                            }
                            Console.WriteLine("You Lost!");
                            Console.WriteLine($"Secret is {number}");
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
