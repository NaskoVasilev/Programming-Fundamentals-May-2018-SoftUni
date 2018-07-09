using System;
using System.Collections.Generic;
using System.Linq;

namespace p07PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dataBase = 
                new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input!="report")
            {
                string[] info = input.Split('|');
                string town = info[0];
                string country = info[1];
                long population = long.Parse(info[2]);

                if (dataBase.ContainsKey(country) == false)
                {
                    dataBase.Add(country, new Dictionary<string, long>());
                    dataBase[country].Add(town,population);
                }
                else
                {
                    if(dataBase[country].ContainsKey(town)==false)
                    {
                        dataBase[country].Add(town, population);
                    }
                    else
                    {
                        dataBase[country][town] += population;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in dataBase.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");

                foreach (var town in pair.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }
            }
        }
    }
}
