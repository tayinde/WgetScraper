using System;

namespace WgetScraper
{
    public class Program
    {
        static void Main(string[] args)
        {
            Scraper scraper = new Scraper();
            string info = scraper.scrape(args[0]);

            Parser parser = new Parser();
            string data = parser.parse(info, args[1]);

            Console.WriteLine(data);
        }
    }
}