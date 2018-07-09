using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonsEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Evolution>> pokemons = new Dictionary<string, List<Evolution>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                string[] tokens = input.Split(" -> ");
                if (tokens.Length < 3)
                {
                    string pokemonToPrint = tokens[0];
                    if (pokemons.ContainsKey(pokemonToPrint))
                    {
                        Console.WriteLine($"# {pokemonToPrint}");
                        foreach (Evolution evolution in pokemons[pokemonToPrint])
                        {
                            Console.WriteLine($"{evolution.Name} <-> {evolution.Index}");
                        }
                    }

                }
                else
                {
                    string pokemonName = tokens[0];
                    string evolutionName = tokens[1];
                    int evolutionIndex = int.Parse(tokens[2]);

                    if (pokemons.ContainsKey(pokemonName) == false)
                    {
                        pokemons.Add(pokemonName, new List<Evolution>());
                    }
                    Evolution currEvolution = new Evolution(evolutionName, evolutionIndex);
                    pokemons[pokemonName].Add(currEvolution);
                }
            }

            foreach (var pair in pokemons)
            {
                Console.WriteLine($"# {pair.Key}");
                foreach (Evolution evolution in pair.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine($"{evolution.Name} <-> {evolution.Index}");
                }
            }
        }
    }

    class Evolution
    {
        public string Name { get; set; }
        public int Index { get; set; }

        public Evolution(string name, int index)
        {
            Name = name;
            Index = index;
        }
    }
}
