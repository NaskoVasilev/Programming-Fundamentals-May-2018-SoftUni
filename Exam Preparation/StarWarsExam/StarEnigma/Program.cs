using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();
            string pattern = @"[^@:\->!]*@([A-Za-z]+)[^@:\->!]*:(\d+)[^@:\->!]*!(A|D)![^@:\->!]*->(\d+)[^@:\->!]*";
            Regex regex = new Regex(pattern);
            char[] lettersToCount = new char[] { 's', 't', 'a', 'r' ,'S','T','A','R'};

            for (int i = 0; i < numberOfMessages; i++)
            {
                string input = Console.ReadLine();
                int key = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if(lettersToCount.Contains(input[j]))
                    {
                        key++;
                    }
                }
                string message = Decrypt(input, key);
                Match match = regex.Match(message);
                if (match.Success)
                {
                    string planet = match.Groups[1].Value;
                    string action = match.Groups[3].Value;
                    if(action=="A")
                    {
                        attackedPlanet.Add(planet);
                    }
                    else if (action=="D")
                    {
                        destroyedPlanet.Add(planet);
                    }
                }
            }

            Console.Write("Attacked planets: ");
            Console.WriteLine(attackedPlanet.Count);
            foreach (var planet in attackedPlanet.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.Write("Destroyed planets: ");
            Console.WriteLine(destroyedPlanet.Count);
            foreach (var planet in destroyedPlanet.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

        }

        private static string Decrypt(string input, int key)
        {
            StringBuilder sb = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = (char)(input[i] - key);
                sb.Append(symbol);
            }
            return sb.ToString();
        }
    }
}
