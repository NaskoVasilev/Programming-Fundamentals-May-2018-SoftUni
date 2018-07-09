using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10DargonAmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<int>>> dragons =
                new Dictionary<string, Dictionary<string, List<int>>>();
            int numberOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDragons; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string type = tokens[0];
                string name = tokens[1];
                string damageAsString = tokens[2];
                string healthAsString = tokens[3];
                string armorAsString = tokens[4];
                int damage, health, armor;

                if (damageAsString == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(damageAsString);
                }
                if (healthAsString == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(healthAsString);
                }
                if (armorAsString == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(armorAsString);
                }

                if (dragons.ContainsKey(type) == false)
                {
                    Dictionary<string, List<int>> dragonsNames = new Dictionary<string, List<int>>();
                    List<int> stats = new List<int>() { damage, health, armor };
                    dragonsNames.Add(name, stats);
                    dragons.Add(type, dragonsNames);
                }
                else
                {
                    if (dragons[type].ContainsKey(name) == false)
                    {
                        dragons[type].Add(name, new List<int>() { damage, health, armor });
                    }
                    else
                    {
                        dragons[type][name].Clear();
                        dragons[type][name].Add(damage);
                        dragons[type][name].Add(health);
                        dragons[type][name].Add(armor);
                    }
                }
            }

            foreach (var pair in dragons)
            {
                double averageDamage = 0;
                double averageHealth = 0;
                double averageArmor = 0;
                int count = 0;
                foreach (var item in pair.Value)
                {
                    averageDamage += item.Value[0];
                    averageHealth += item.Value[1];
                    averageArmor += item.Value[2];
                    count++;
                }
                averageDamage /= count;
                averageHealth /= count;
                averageArmor /= count;

                Console.WriteLine($"{pair.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (var dragon in pair.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}," +
                        $" health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
