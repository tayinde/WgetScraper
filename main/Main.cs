using System;

namespace WgetScraper
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "--h" || args[0] == "--help" || args[0] == "h" || args[0] == "help") Manual.Help();
            Scraper scraper = new Scraper();
            string info = scraper.scrape(args[0]);

            Parser parser = new Parser();
            string data = args.Length == 2 ? parser.parse(info, args[1]) : parser.parse(info, args[1], args[2]);

            Console.WriteLine(data);
        }
    }
}
