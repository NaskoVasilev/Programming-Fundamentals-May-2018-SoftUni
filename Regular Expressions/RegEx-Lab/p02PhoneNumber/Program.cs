using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p02PhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ -])2(\1)\d{3}(\1)\d{4}\b";

            string numbers = Console.ReadLine(); 

            MatchCollection matches = Regex.Matches(numbers, pattern);

            string[] matchedNums = matches.Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ",matchedNums));
        }
    }
}
