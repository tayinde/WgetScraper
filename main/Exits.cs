using System;

namespace WgetScraper
{
    public static class Exit
    {
        public static void Code(string msg, int code)
        {
            Console.WriteLine(msg);
            Environment.Exit(code);
        }

        public static void Code(int code)
        {
            Environment.Exit(code);
        }
    }
}