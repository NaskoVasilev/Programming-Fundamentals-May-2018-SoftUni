using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace p05Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(new char[] { '\\', '/', ' ', ')', '(' }
            , StringSplitOptions.RemoveEmptyEntries);

            string pattern = $@"^[A-Za-z]\w+$";
            Regex regex = new Regex(pattern);

            List<string> validNames = new List<string>();

            foreach (string name in usernames)
            {
                Match match = regex.Match(name);
                if (match.Success)
                {
                    if (match.Value.Length >= 3 && match.Value.Length <= 24)
                    {
                        validNames.Add(match.Value);
                    }
                }
            }

            int maxLength = 0;
            string firstUser = "";
            string secondUser = "";
            for (int i = 0; i < validNames.Count - 1; i++)
            {
                int currLength = validNames[i].Length + validNames[i + 1].Length;
                if (maxLength < currLength)
                {
                    maxLength = currLength;
                    firstUser = validNames[i];
                    secondUser = validNames[i + 1];
                }
            }
            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);
        }
    }
}
