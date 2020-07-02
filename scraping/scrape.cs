using System.Diagnostics;
using System.IO;
using System;

namespace WgetScraper
{
    public class Scraper
    {
        public string scrape(string url)
        {
            Process execution = new Process();
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.FileName = "/bin/wget";
            processInfo.Arguments = "-q --output-document=WgetScraperData.html " + url;
            execution.StartInfo = processInfo;
            execution.Start();
            execution.WaitForExit();
            string info = "";
            try
            {
                info = File.ReadAllText("./WgetScraperData.html").Replace("    ", "").Replace("\n", "");
                File.Delete("./WgetScraperData.html");
                File.Delete("./wget-log");
                File.Delete("./search");
            }
            catch (Exception) {}
            return info;
        }
    }
}