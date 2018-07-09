using System;
using System.Globalization;

namespace p10HolidayBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            int holidaysCount = 0;

            DateTime date = new DateTime();
            for (date = startDate; date <= endDate; date=date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    holidaysCount++;
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                    date=date.AddDays(5);
                }
            }
            Console.WriteLine(holidaysCount);

        }
    }
}
