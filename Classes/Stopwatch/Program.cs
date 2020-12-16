using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Stopwatch or Exit...\n1. Stopwatch\n2. Exit");
            var choice = Console.ReadLine();
            Console.Clear();

            if (choice == "Stopwatch")
            {
                StopWatch();
            }
            else if (choice == "Exit")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }

        private static void StopWatch()
        {
            var stopWatch = new Stopwatch();
            Console.WriteLine("Choose and type: start or stop the stopwatch");

            while (true)
            {
                var command = Console.ReadLine().ToLower();
                if (command == "start")
                {
                    stopWatch.Start();
                }
                else if (command == "stop")
                {
                    stopWatch.Stop();
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    }
}
