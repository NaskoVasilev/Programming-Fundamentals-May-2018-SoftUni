using System;
using System.Globalization;

namespace p01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateAsString = Console.ReadLine();
            DateTime date = DateTime
                .ParseExact(dateAsString, "d-M-yyyy"
                , CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
            //string[] input = Console.ReadLine().Split('-');
            //int day = int.Parse(input[0]);
            //int month = int.Parse(input[1]);
            //int year = int.Parse(input[2]);
            //DateTime date = new DateTime(year, month, day);
            //Console.WriteLine(date.DayOfWeek);
        }
    }
}
