using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p05Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string nummsAsString = Console.ReadLine();

            MatchCollection nums = Regex.Matches(nummsAsString, pattern);

            string[] numbers = nums.Select(n => n.Value).ToArray();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
