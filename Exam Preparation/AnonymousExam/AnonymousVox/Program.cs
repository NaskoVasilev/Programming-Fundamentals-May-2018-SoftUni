using System;
using System.Text.RegularExpressions;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] values = Console.ReadLine()
                .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"([A-Za-z]+)(.+)()\1";

            MatchCollection matches = Regex.Matches(text, pattern);
            int length = Math.Min(matches.Count, values.Length);

            for (int i = 0; i < length; i++)
            {
                string placeholder = matches[i].Value;
                string changedPlaceholder = placeholder.Replace(matches[i].Groups[2].Value, values[i]);
                text = text.Replace(placeholder, changedPlaceholder);
            }
            Console.WriteLine(text);
        }
    }
}
