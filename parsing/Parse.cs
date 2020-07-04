using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace WgetScraper
{
    public class Parser
    {
        public string emptyElements = @"\bimg|link|hr|br|script src|meta\w*\b";
        public string[] formatArgs =
        {
            "inclusive",
            "inside",
            "link",
            "tag"
        };
        public string parse(string html, string query)
        {
            int open = html.IndexOf($"<{query}");
            int openEndArrow = 0;
            try {openEndArrow = html.Remove(0, open).IndexOf('>') + open + 1;} 
            catch {Exit.Code("Not found", 1);}
            if (Regex.Match(query, emptyElements).Success)
                Exit.Code(html.Substring(open, openEndArrow - open), 0);

            int close = 0;
            for (int i = openEndArrow; i < html.Length - query.Length - 3; i++)
                if (html.Substring(i, query.Split(' ')[0].Length + 3) != $@"</{query.Split(' ')[0]}>")
                    close++;
                else
                    break;
            return html.Substring(openEndArrow, close);
        }
        
        // overload
        public string parse(string html, string query, string format)
        {
            try {format = format.IndexOf("--") == -1 ? format : format.Remove(format.IndexOf("--"), 2);}
            catch {Exit.Code("Third argument in command was formatted incorrectly", 1);}
            if ((format == "inside") || (Regex.Match(query, emptyElements).Success) && (Array.IndexOf(this.formatArgs, format) == -1) || (Array.IndexOf(this.formatArgs, format)) == -1) return this.parse(html, query);
            else if (format == "link")
            {
                int open = html.IndexOf($"<{query}");
                int end = 0;
                try {end = html.Remove(0, open).IndexOf('>') + open + 1;}
                catch {Exit.Code("Not found", 1);}
                char[] tagRange = html.ToCharArray()[open..end];
                string tag = string.Join(String.Empty, tagRange)
                    .Replace("\"", "");
                string href = null;
                href = Regex.Match(tag.Insert(tag.Length - 1, " "), @"href=([^\s]+)").Value;
                try {return href.Remove(0, 5);}
                catch {Exit.Code("Not found", 1);}
                return null;
            }
            else if (format == "inclusive")
            {
                return "Method not implemented yet";
            }
            else if (format == "tag")
            {
                int open = html.IndexOf($"<{query}");
                int end = 0;
                try {end = html.Remove(0, open).IndexOf('>') + open + 1;}
                catch {Console.WriteLine("Not found"); Environment.Exit(1);}
                char[] tagRange = html.ToCharArray()[open..end];
                string tag = string.Join(String.Empty, tagRange);
                return tag;
            }
            else return "";
        }
    }
}