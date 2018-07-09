using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string bojoPattern = @"([A-Za-z]+)-([A-Za-z]+)";
            string didiPattern = @"[^A-Za-z-]+";
            string input = Console.ReadLine();
            Regex bojoRegex = new Regex(bojoPattern);
            Regex didiRegex = new Regex(didiPattern);

            while (true)
            {
                Match didiMatch = didiRegex.Match(input);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch);
                    int lastIndex = input.IndexOf(didiMatch.Value);
                    input = input.Remove(0, lastIndex + didiMatch.Value.Length);
                }
                else
                {
                    break;
                }

                Match bojoMatch = bojoRegex.Match(input);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch);
                    int lastIndex = input.IndexOf(bojoMatch.Value);
                    input = input.Remove(0, lastIndex + bojoMatch.Value.Length);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
