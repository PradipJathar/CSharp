using System;

namespace ClassesExerciseStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                Console.Write("Enter a command: 'start', 'stop', 'quit': ");
                var input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "start":
                        try
                        {
                            stopwatch.Start();
                            Console.WriteLine("Stopwatch started.");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "stop":
                        try
                        {
                            stopwatch.Stop();
                            var duration = stopwatch.GetDuration();
                            if (duration.HasValue)
                            {
                                Console.WriteLine($"Duration: {duration.Value.TotalSeconds} seconds");
                            }
                            else
                            {
                                Console.WriteLine("Stopwatch hasn't been started yet.");
                            }
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "quit":
                        return;

                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }
            }
        }
    }
}