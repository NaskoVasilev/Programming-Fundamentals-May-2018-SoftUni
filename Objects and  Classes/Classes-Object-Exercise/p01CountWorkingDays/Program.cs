using System;
using System.Globalization;

namespace p01CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine()
                , "dd-MM-yyyy",
                CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine()
               , "dd-MM-yyyy",
               CultureInfo.InvariantCulture);
            int numberOfNonWorkingDays = 0;
            for (DateTime curreneDate = startDate; curreneDate <= endDate; curreneDate = curreneDate.AddDays(1))
            {
                if (curreneDate.DayOfWeek != DayOfWeek.Saturday
                    && curreneDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    numberOfNonWorkingDays++;
                    if (curreneDate.Day == 1 &&
                        (curreneDate.Month == 1 || curreneDate.Month == 5 || curreneDate.Month == 11))
                    {
                        numberOfNonWorkingDays--;
                    }
                    else if (curreneDate.Day == 3 && curreneDate.Month == 3)
                    {
                        numberOfNonWorkingDays--;
                    }
                    else if (curreneDate.Day == 6 && curreneDate.Month == 5)
                    {
                        numberOfNonWorkingDays--;
                    }
                    else if (curreneDate.Day == 24 && curreneDate.Month == 5)
                    {
                        numberOfNonWorkingDays--;
                    }
                    else if (curreneDate.Month == 9 &&
                        (curreneDate.Day == 6 || curreneDate.Day == 22))
                    {
                        numberOfNonWorkingDays--;
                    }
                    else if (curreneDate.Month == 12 &&
                       (curreneDate.Day == 24 || curreneDate.Day == 25 || curreneDate.Day == 26))
                    {
                        numberOfNonWorkingDays--;
                    }
                }
            }
            Console.WriteLine(numberOfNonWorkingDays);
        }


    }
}
