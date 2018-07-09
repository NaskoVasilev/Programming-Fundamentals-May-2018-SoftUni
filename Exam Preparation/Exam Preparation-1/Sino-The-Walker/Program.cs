using System;
using System.Globalization;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            //first solution
            //DateTime leftHour = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss"
            //    , CultureInfo.InvariantCulture);
            //int numberOfSteps = int.Parse(Console.ReadLine())%86400;
            //int timeForStepInSec = int.Parse(Console.ReadLine())%86400;

            //double walkTimeInSec = numberOfSteps * timeForStepInSec;
            //leftHour = leftHour.AddSeconds(walkTimeInSec);
            //Console.WriteLine($"Time Arrival: {leftHour.ToString("HH:mm:ss", CultureInfo.InvariantCulture)}");

            //second solution
            //string[] date = Console.ReadLine().Split(':');
            //int hours = int.Parse(date[0]);
            //int minutes = int.Parse(date[1]);
            //int seconds = int.Parse(date[2]);
            //int numberOfSteps = int.Parse(Console.ReadLine());
            //int timeForStepInSec = int.Parse(Console.ReadLine());

            //long walkTimeInSec = (long)numberOfSteps * timeForStepInSec;
            //long hoursToAdd = walkTimeInSec / 3600;
            //int minutesToAdd = (int)(walkTimeInSec % 3600);
            //int secondsToAdd = minutesToAdd % 60;
            //minutesToAdd /= 60;
            //hoursToAdd = hoursToAdd % 24;
            //hours += (int)hoursToAdd;
            //if(hours>=24)
            //{
            //    hours -= 24;
            //}
            //minutes += minutesToAdd;
            //if(minutes>=60)
            //{
            //    minutes -= 60;
            //    hours++;
            //    if(hours==24)
            //    {
            //        hours -= 24;
            //    }
            //}
            //seconds += secondsToAdd;
            //if(seconds>=60)
            //{
            //    seconds -= 60;
            //    minutes++;
            //    if(minutes>=60)
            //    {
            //        minutes -= 60;
            //        hours++;
            //    }
            //    if(hours>=24)
            //    {
            //        hours -= 24;
            //    }
            //}

            //Console.WriteLine($"Time Arrival: {hours:D2}:{minutes:D2}:{seconds:D2}");

            //third solution
            TimeSpan time = TimeSpan.ParseExact(Console.ReadLine(), @"hh\:mm\:ss", CultureInfo.InvariantCulture);
            int stepsCount = int.Parse(Console.ReadLine())%86400;
            int timePerStep = int.Parse(Console.ReadLine())%86400;

            double timeToAdd = stepsCount * timePerStep;

            time += TimeSpan.FromSeconds(timeToAdd);
            Console.WriteLine("Time Arrival: "+time.ToString(@"hh\:mm\:ss"));

        }
    }
}
