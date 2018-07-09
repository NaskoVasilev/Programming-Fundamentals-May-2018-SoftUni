using System;
using System.Collections.Generic;
using System.Linq;

namespace p02PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                if (action == "A")
                {
                    string name = tokens[1];
                    string number = tokens[2];
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, number);
                    }
                    else
                    {
                        phonebook[name] = number;
                    }
                }
                else if (action == "S")
                {
                    string name = tokens[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (action == "ListAll")
                {
                    SortedDictionary<string, string> sorted = new SortedDictionary<string, string>();
                    foreach (var pair in phonebook)
                    {
                        sorted.Add(pair.Key, pair.Value);
                    }
                    foreach (var item in sorted)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
