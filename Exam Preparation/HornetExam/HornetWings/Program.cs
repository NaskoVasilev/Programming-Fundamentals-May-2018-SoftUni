using System;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePer1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = (wingFlaps / 1000.00) * distancePer1000Flaps;
            int restTime = (wingFlaps / endurance) * 5;
            double flightTime = (wingFlaps / 100.00)+restTime;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{flightTime} s.");

        }
    }
}
