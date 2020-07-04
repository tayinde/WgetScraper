using System;

namespace WgetScraper
{
    public static class Manual
    {
        public static string[] commands =
        {
            "dotnet run <website url> <element> - Gets the first element from the specified URL",
            "[tip] typing something such as 'link rel=\"https://a' in the <element> field will help specify your search. Doing this will make the program look for the first occurence of a element that starts with '<link rel=\"https://a'",
            "dotnet run 'website url' 'element' --link - Finds a link inside of an element's href label",
        };
        public static void Help()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nCommands");
            for (int i = 0; i < Console.BufferWidth; i++) Console.Write('=');
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");
            foreach (string s in commands) Console.WriteLine(s + '\n');
            Exit.Code(0);
        }
    }
}