using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (snowmen.Count>1)
            {
                for (int i = 0; i < snowmen.Count; i++)
                {
                    if(snowmen[i]==-1)
                    {
                        continue;
                    }
                    int attacker = i;
                    int target = snowmen[i];
                    if(target>=snowmen.Count)         
                    {
                        target %= snowmen.Count;
                    }

                    int diference = Math.Abs(target - attacker);
                    if (diference % 2 == 0 && diference != 0)
                    {
                        snowmen[target] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    }
                    else if (diference % 2 == 1)
                    {
                        snowmen[attacker]=-1;
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    }
                    else if(diference==0)
                    {
                        snowmen[attacker]=-1;
                        Console.WriteLine($"{attacker} performed harakiri");
                    }
                    if (snowmen.Count == snowmen.Where(x => x == -1).ToList().Count + 1)
                    {
                        break;
                    }
                }
                snowmen = snowmen.Where(x => x != -1).ToList();
            }
        }
    }
}
