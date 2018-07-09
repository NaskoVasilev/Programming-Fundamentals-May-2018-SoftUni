using System;
using System.Collections.Generic;
using System.Linq;

namespace p08LogsAggergator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> users =
                new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string IP = info[0];
                string name = info[1];
                int time = int.Parse(info[2]);

                if (users.ContainsKey(name) == false)
                {
                    users.Add(name, new Dictionary<string, int>());
                    users[name].Add(IP, time);
                }
                else
                {
                    if (users[name].ContainsKey(IP) == false)
                    {
                        users[name].Add(IP, 0);
                    }
                    users[name][IP] += time;
                }
            }

            foreach (var pair in users.OrderBy(x => x.Key))
            {
                List<string> IPadresses = new List<string>();
                Console.Write(pair.Key + ": ");
                Console.Write(pair.Value.Values.Sum() + " ");
                foreach (var IP in pair.Value.OrderBy(x => x.Key))
                {
                    IPadresses.Add(IP.Key);
                }
                Console.WriteLine($"[{string.Join(", ", IPadresses)}]");
            }
        }
    }
}
