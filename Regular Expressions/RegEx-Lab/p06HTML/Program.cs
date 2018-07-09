using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace p06HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a.*? href.*?=(.*)>(.*?)<\/a>";
            string replecement = @"[URL href=$1]$2[/URL]";
            string input = Console.ReadLine();
            List<string> replecedText = new List<string>();

            while (input != "end")
            {
                string repleced = Regex.Replace(input, pattern, replecement);
                Console.WriteLine(repleced);
                input = Console.ReadLine();
            }

        }
    }
}
