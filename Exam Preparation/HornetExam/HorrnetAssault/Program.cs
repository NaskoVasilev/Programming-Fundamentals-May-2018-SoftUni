using System;
using System.Collections.Generic;
using System.Linq;

namespace HorrnetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehieves = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehieves.Count; i++)
            {
                long hornetsPower = hornets.Sum();

                if (beehieves[i] >= hornetsPower)
                {
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                        beehieves[i] -= hornetsPower;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                        beehieves.RemoveAt(i);
                        i--;
                }
            }
            beehieves = beehieves.Where(x => x > 0).ToList();
            if (beehieves.Count == 0)
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
            else
            {
                Console.WriteLine(string.Join(" ", beehieves));
            }
        }
    }
}
