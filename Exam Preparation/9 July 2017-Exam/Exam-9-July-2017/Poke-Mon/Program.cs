using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int count = 0;
            int currentPower = power;
            while (currentPower >= distance)
            {
                count++;
                currentPower -= distance;
                if (power / 2 == currentPower && power % 2 == 0 && exhaustion != 0)
                {
                    currentPower /= exhaustion;
                }

            }
            Console.WriteLine(currentPower);
            Console.WriteLine(count);
        }
    }
}
