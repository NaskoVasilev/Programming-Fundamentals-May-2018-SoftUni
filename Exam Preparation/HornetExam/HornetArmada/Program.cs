using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> legions = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> soldiers = new Dictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(new char[] { '=', ' ', '-', '>', ':' }
                , StringSplitOptions.RemoveEmptyEntries);

                long activity = long.Parse(info[0]);
                string legionName = info[1];
                string soldierType = info[2];
                long soldierCount = long.Parse(info[3]);

                if (soldiers.ContainsKey(legionName))
                {
                    if (soldiers[legionName].ContainsKey(soldierType) == false)
                    {
                        soldiers[legionName].Add(soldierType, soldierCount);
                    }
                    else
                    {
                        soldiers[legionName][soldierType] += soldierCount;
                    }

                    if (legions[legionName] < activity)
                    {
                        legions[legionName] = activity;
                    }
                }
                else
                {
                    legions.Add(legionName, activity);

                    Dictionary<string, long> currSoldier = new Dictionary<string, long>();
                    currSoldier.Add(soldierType, soldierCount);
                    soldiers.Add(legionName, currSoldier);
                }
            }

            string[] input = Console.ReadLine().Split('\\');
            if (input.Length == 2)
            {
                long activity = long.Parse(input[0]);
                string solderType = input[1];

                foreach (var soldier in soldiers.Where(x => x.Value.ContainsKey(solderType))
                    .OrderByDescending(x => x.Value[solderType]))
                {
                    if (legions[soldier.Key] < activity)
                    {
                        Console.WriteLine($"{soldier.Key} -> {soldiers[soldier.Key][solderType]}");
                    }
                }
            }
            else
            {
                string soldierType = input[0];
                foreach (var legion in legions.OrderByDescending(x => x.Value))
                {
                    if (soldiers[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }


        }
    }
}
