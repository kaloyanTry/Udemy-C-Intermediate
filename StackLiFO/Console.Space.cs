using System;

public static class ConsoleSpace
{
    public static void Spacing(string welcome, string options)
    {
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        Console.WriteLine(welcome);
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        Console.WriteLine(options);
        Console.SetCursorPosition(0, Console.CursorTop + 1);
    }
}
