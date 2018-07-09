using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int bestTime = 0;
            int bestSnow = 0;
            int bestQuality = 0;
            BigInteger bestValue = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snow / time, quality);
                if(snowballValue>bestValue)
                {
                    bestValue = snowballValue;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
