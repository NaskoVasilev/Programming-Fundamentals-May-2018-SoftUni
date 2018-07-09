using System;
using System.Collections.Generic;
using System.Linq;

namespace p09LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
                { "motes",0}
                ,{ "shards",0}
                ,{ "fragments",0}
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool isWinners = false;
            string winnerName = "";
            while (true)
            {
                if(isWinners)
                {
                    break;
                }
                string[] info = Console.ReadLine().ToLower().Split();
                int quantity = 0;
                for (int i = 0; i < info.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(info[i]);
                    }
                    else
                    {
                        string name = info[i];

                        if(materials.ContainsKey(name))
                        {
                            materials[name] += quantity;
                            if(materials[name]>=250)
                            {
                                materials[name] -= 250;
                                isWinners = true;
                                winnerName = name;
                                break;
                            }
                        }
                        else
                        {
                            if(junk.ContainsKey(name)==false)
                            {
                                junk.Add(name, 0);
                            }
                            junk[name] += quantity;
                        }
                    }
                }
            }
            string item = "";
            switch(winnerName)
            {
                case "shards":
                    item = "Shadowmourne";
                    break;
                case "fragments":
                    item = "Valanyr";
                    break;
                case "motes":
                    item = "Dragonwrath";
                    break;
            }
            Console.WriteLine($"{item} obtained!");
            foreach (var pair in materials.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            foreach (var pair in junk.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
