using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace p07QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^=&?]+)=([^&?=]+)";
            string spacePattern = @"(%20|\+)+";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                MatchCollection matches = regex.Matches(input);
                Dictionary<string, List<string>> keys = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string key = match.Groups[1].Value;
                    string value = match.Groups[2].Value;

                    key = Regex.Replace(key, spacePattern, " ").Trim();
                    value = Regex.Replace(value, spacePattern, " ").Trim();

                    if (keys.ContainsKey(key) == false)
                    {
                        keys.Add(key, new List<string>());
                    }
                    keys[key].Add(value);
                }
                foreach (var pair in keys)
                {
                    Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
                }
                Console.WriteLine();
            }
        }
    }
}
