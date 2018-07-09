using System;
using System.Linq;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split();
            double[] trackInfo = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkpointIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0 && x <= trackInfo.Length-1)
                .ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                string name = drivers[i];
                double fuel = (int)name[0];
                bool isRunning = true;
                for (int j = 0; j < trackInfo.Length; j++)
                {
                    if(checkpointIndexes.Contains(j))
                    {
                        fuel += trackInfo[j];
                    }
                    else
                    {
                        fuel -= trackInfo[j];
                    }

                    if(fuel<=0)
                    {
                        isRunning = false;
                        Console.WriteLine($"{name} - reached {j}");
                        break;
                    }
                }

                if(isRunning)
                {
                    Console.WriteLine($"{name} - fuel left {fuel:f2}");
                }
            }


        }
    }
}
