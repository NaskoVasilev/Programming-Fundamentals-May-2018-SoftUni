using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surfacePattern = @"^[^A-Za-z0-9]+$";
            string mantlePattern = @"^[0-9_]+$";
            string pattern = @"^[^A-Za-z0-9]+[0-9_]+([A-Za-z]+)[0-9_]+[^A-Za-z0-9]+$";
            string[] lines = new string[5];
            int coreLength = 0;
            for (int i = 0; i < 5; i++)
            {
                lines[i] = Console.ReadLine();
            }

            int countOfMatches = 0;

            if (Regex.IsMatch(lines[0],surfacePattern))
            {
                countOfMatches++;
            }
            if (Regex.IsMatch(lines[1], mantlePattern))
            {
                countOfMatches++;
            }
            if (Regex.IsMatch(lines[2], pattern))
            {
                countOfMatches++;
                Match match = Regex.Match(lines[2], pattern);
                coreLength = match.Groups[1].Value.Length;
            }
            if (Regex.IsMatch(lines[3], mantlePattern))
            {
                countOfMatches++;
            }
            if (Regex.IsMatch(lines[4], surfacePattern))
            {
                countOfMatches++;
            }

            if(countOfMatches==5)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(coreLength);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
