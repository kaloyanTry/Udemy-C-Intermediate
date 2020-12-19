using System;
using System.Collections.Generic;

namespace StackLiFO
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Welcome! This is a LISP example project. Add, remove and clear from a stack. The following commands:";
            string options = "Options\n" +
                "Add: 'a'\n" +
                "Remove: 'r'\n" +
                "Clear: 'c'\n" +
                "Quit: 'q'";

            ConsoleSpace.Spacing(welcome, options);
            Stack stack = new Stack();
            int stackCount = 0;
            string stackCountView = $"Current stack count is: {stack.StackCount()}";

            while (true)
            {
                try
                {
                    switch (Console.ReadLine().ToLower())
                    {
                        case "a":
                            Console.Clear();
                            ConsoleSpace.Spacing(welcome, options);
                            stack.Push(stackCount++);
                            Console.WriteLine($"Current stack count is: {stack.StackCount()}");
                            break;

                        case "r":
                            Console.Clear();
                            ConsoleSpace.Spacing(welcome, options);
                            stack.Pop();
                            Console.WriteLine($"Current stack count is: {stack.StackCount()}");
                            break;

                        case "c":
                            Console.Clear();
                            ConsoleSpace.Spacing(welcome, options);
                            stack.Pop();
                            Console.WriteLine($"Current stack count is: {stack.StackCount()}");
                            break;

                        case "q":
                            return;

                        default:
                            Console.WriteLine("Please input a valid option.");
                            break;
                    }

                }
                catch (InvalidOperationException)
                {
                    Console.Clear();
                    Console.WriteLine("There is nothing in the stack");
                }
            }
        }
    }
}
