using System;
using System.Text.RegularExpressions;

namespace WgetScraper
{
    public class Parser
    {
        public string parse(string html, string query)
        {
            int open = html.IndexOf($"<{query}");
            int openEndArrow = open + 1;
            try
            {
            for (int i = open; html[i] != '>'; i++)
                openEndArrow++;
            } catch (Exception)
            {
                Console.WriteLine("Not found.");
                Environment.Exit(0);
            }
            if (Regex.Match(query, @"\bimg|link|hr|br|script src\w*\b").Success)
            {
                Console.WriteLine(html.Substring(open, openEndArrow - open));
                Environment.Exit(0);
            }
            int close = 0;
            for (int i = openEndArrow; i < html.Length - query.Length - 3; i++)
                if (html.Substring(i, query.Split(' ')[0].Length + 3) != $@"</{query.Split(' ')[0]}>")
                    close++;
                else
                    break;
            return html.Substring(openEndArrow, close);
        }
    }
}