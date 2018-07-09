using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>pokemons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            long removedSum=0;
            int removed = 0;

            while(pokemons.Count>0)
            {
                int index = int.Parse(Console.ReadLine());

                if(index>=pokemons.Count)
                {
                    removed = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else if (index<0)
                {
                    removed = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else
                {
                    removed = pokemons[index];
                    pokemons.RemoveAt(index);
                }

                removedSum += (long)removed;

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if(pokemons[i]>removed)
                    {
                        pokemons[i] -= removed;
                    }
                    else
                    {
                        pokemons[i] += removed;
                    }
                }
            }

            Console.WriteLine(removedSum);
        }
    }
}
