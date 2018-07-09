using System;
using System.Text;
using System.Text.RegularExpressions;

namespace p08Chains
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"<p>(.+?)<\/p>";
            string spacePattern = @"[^a-z0-9]";
            string result = "";
            MatchCollection matches = Regex.Matches(input, pattern);
            string decrypted = "";
            foreach (Match match in matches)
            {
                string current = Regex.Replace(match.Groups[1].Value, spacePattern, " ");
                decrypted = Decrypt(current);
                result += decrypted;
            }

            result = Regex.Replace(result, @"\s+", " ");
            Console.WriteLine(result);
        }

        private static string Decrypt(string current)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < current.Length; i++)
            {
                if(char.IsLower(current[i]))
                {
                    int newCode = 0;
                    if ((int)current[i] >= 110)
                    {
                        newCode = current[i] - 13;
                    }
                    else
                    {
                        newCode = current[i] + 13;
                    }
                    sb.Append((char)newCode);
                }
                else
                {
                    sb.Append(current[i]);
                }
            }
            return sb.ToString();
        }
    }
}
