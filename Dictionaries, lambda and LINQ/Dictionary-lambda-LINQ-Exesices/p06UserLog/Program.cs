using System;
using System.Collections.Generic;
using System.Linq;

namespace p06UserLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split(new char[] { ' ', '=' }
                , StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[5];
                string IP = tokens[1];
                string message = tokens[3];

                if (users.ContainsKey(name) == false)
                {
                    users.Add(name, new Dictionary<string, int>());
                    users[name].Add(IP, 1);
                }
                else
                {
                    if (users[name].ContainsKey(IP) == false)
                    {
                        users[name].Add(IP, 0);
                    }
                    users[name][IP]++;
                }
                command = Console.ReadLine();
            }

            foreach (var pair in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(pair.Key + ":");
                
                foreach (var item in pair.Value)
                {
                    
                    if (item.Key == pair.Value.Last().Key)
                    {
                        Console.Write($"{item.Key} => {item.Value}.");
                    }
                    else
                    {
                        Console.Write($"{item.Key} => {item.Value}, ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
