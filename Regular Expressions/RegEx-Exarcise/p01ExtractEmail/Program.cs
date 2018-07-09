using System;
using System.Text.RegularExpressions;

namespace p01ExtractEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)[A-Za-z0-9]+([-_.])?[A-Za-z0-9]+@([A-Za-z][A-Za-z-.]+[A-Za-z])+\.[A-Za-z]+";
            string text = Console.ReadLine();

            MatchCollection emails = Regex.Matches(text, pattern);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
