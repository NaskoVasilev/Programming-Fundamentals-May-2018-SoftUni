using System;
using System.Text.RegularExpressions;

namespace p03HexadecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?([0-9A-F])+\b";
            string nums = Console.ReadLine();
            MatchCollection matches = Regex.Matches(nums, pattern);
            Console.WriteLine(string.Join(" ",matches));
        }
    }
}
