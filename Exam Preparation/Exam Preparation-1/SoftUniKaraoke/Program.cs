using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@",\s+");
            string[] participants = regex.Split(Console.ReadLine());
            string[] songs = regex.Split(Console.ReadLine());

            Dictionary<string, List<string>> awards = new Dictionary<string, List<string>>();

            string input = "";
            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] tokens = regex.Split(input);
                string name = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participants.Contains(name) && songs.Contains(song))
                {
                    if (awards.ContainsKey(name) == false)
                    {
                        awards.Add(name, new List<string>());
                    }
                    if (awards[name].Contains(award) == false)
                    {
                        awards[name].Add(award);
                    }
                }

            }

            foreach (var pair in awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count} awards");
                foreach (var award in pair.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"--{award}");
                }
            }

            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
            }

        }
    }
}
