using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease select valid option:");
            Console.WriteLine("1. Check valid number (Between 1 to 10).");
            Console.WriteLine("2. Displays the maximum number of the two.");
            Console.WriteLine("3. Tell if the image is landscape or portrait.");
            Console.WriteLine("4. Program for a speed camera.");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option <= 4)
            {
                switch (option)
                {
                    case 1:
                        {
                            Console.Write("Enter your number: ");
                            int number = Convert.ToInt32(Console.ReadLine());

                            if (number >= 0 && number <= 10)
                            {
                                Console.WriteLine("This is valid number.");
                            }
                            else
                            {
                                Console.WriteLine("This is invalid number.");
                            }
                        }
                        break;

                    case 2:
                        {
                            Console.Write("Enter first number: ");
                            int firstNumber = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter second number: ");
                            int secondNumber = Convert.ToInt32(Console.ReadLine());

                            if (firstNumber > secondNumber)
                            {
                                Console.WriteLine($"{firstNumber} is the maximum number.");
                            }
                            else
                            {
                                Console.WriteLine($"{secondNumber} is the maximum number.");
                            }
                        }
                        break;

                    case 3:
                        {
                            Console.Write("Enter the width of image: ");
                            int width = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter the height of image: ");
                            int height = Convert.ToInt32(Console.ReadLine());

                            if (width > height)
                            {
                                Console.WriteLine("This image is Landscape.");
                            }
                            else if (width < height)
                            {
                                Console.WriteLine("This image is portrait.");
                            }
                            else
                            {
                                Console.WriteLine("It's a perfect square.");
                            }
                        }
                        break;

                    case 4:
                        {
                            Console.Write("What is the speed limit?: ");
                            var speedLimit = Convert.ToInt32(Console.ReadLine());

                            Console.Write("What is the speed of this car?: ");
                            var speed = Convert.ToInt32(Console.ReadLine());

                            if (speed <= speedLimit)
                            {
                                Console.WriteLine("Ok");
                            }
                            else
                            {
                                const int kmPerDemeritPoint = 5;
                                var demeritPoints = (speed - speedLimit) / kmPerDemeritPoint;

                                if (demeritPoints > 12)
                                {
                                    Console.WriteLine("License Suspended.");
                                }
                                else
                                {
                                    Console.WriteLine("Demerit points: " + demeritPoints);
                                }
                            }

                        }
                        break;
                }

            }
            else
            {
                Console.WriteLine("Please select valid option between 1 to 4.");
            }

            Main(args);
        }
    }
}
