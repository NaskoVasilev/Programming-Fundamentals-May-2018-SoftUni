using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"32656 19759 32763 0 (\d+) 0 (([1-9][0-9]* )+)";
            Regex regex = new Regex(pattern);
            StringBuilder mergedInput = new StringBuilder();
            List<string> words = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Visual Studio crash")
                {
                    break;
                }
                mergedInput.Append(input + " ");
            }

            MatchCollection matches = regex.Matches(mergedInput.ToString());
            foreach (Match match in matches)
            {
                int length = int.Parse(match.Groups[1].Value);
                string ASCICodesAsString = match.Groups[2].Value.Trim();
                int[] ASCICodes = ASCICodesAsString.Split(' ').Select(int.Parse).ToArray();

                StringBuilder sb = new StringBuilder();

                foreach (var code in ASCICodes)
                {
                    sb.Append((char)code);
                }

                words.Add(sb.ToString());
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
