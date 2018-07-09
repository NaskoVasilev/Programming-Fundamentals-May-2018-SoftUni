using System;

namespace p11Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int mintes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int timeInSecond = (hour * 3600) + (mintes * 60) + seconds;
            decimal speedInMetresPerSecond = distance / (decimal)timeInSecond;
            decimal distanceInKm = distance / 1000.00m;
            decimal timeInHours = timeInSecond / 3600.00m;
            decimal speedInKmPerHour = distanceInKm / timeInHours;
            decimal distanceInMiles = distance / 1609.00m;
            decimal speedInMilesPerHour = distanceInMiles / timeInHours;
            Console.WriteLine("{0:f7}",speedInMetresPerSecond);
            Console.WriteLine("{0:f7}", speedInKmPerHour);
            Console.WriteLine("{0:f7}", speedInMilesPerHour);
        }
    }
}
