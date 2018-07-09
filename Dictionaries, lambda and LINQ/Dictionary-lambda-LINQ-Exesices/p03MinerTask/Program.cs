using System;
using System.Collections.Generic;

namespace p03MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resource = "";
            string command = Console.ReadLine();
            int line = 0;
            while (command != "stop")
            {
                int quantitiy = 0;
                if (line % 2 == 0)
                {
                    resource = command;
                }
                else
                {
                    quantitiy = int.Parse(command);
                    if(!resources.ContainsKey(resource))
                    {
                        resources.Add(resource, quantitiy);
                    }
                    else
                    {
                        resources[resource] += quantitiy;
                    }
                }
                line++;
                command = Console.ReadLine();
            }
            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
