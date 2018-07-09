using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace p05KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyText = Console.ReadLine();
            string text = Console.ReadLine();

            string[] keys = keyText.Split(new char[] { '\\', '|', '<' }
            , StringSplitOptions.RemoveEmptyEntries);

            string startKey = keys[0];
            string endKey = keys[keys.Length - 1];
            string pattern = $@"{startKey}(.*?){endKey}";
            string result = "";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match word in matches)
            {
                result += word.Groups[1].Value;
            }
            if (result == "")
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
