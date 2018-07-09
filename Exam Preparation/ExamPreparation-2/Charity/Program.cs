using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            uint days = uint.Parse(Console.ReadLine());
            uint runners = uint.Parse(Console.ReadLine());
            uint averageNumberOfLaps = uint.Parse(Console.ReadLine());
            uint lapLength = uint.Parse(Console.ReadLine());
            uint trackCapacity = uint.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            uint capacityForAllDays = days * trackCapacity;
            if(capacityForAllDays<runners)
            {
                runners = capacityForAllDays;
            }

            decimal totalKm = ((long)runners *averageNumberOfLaps * lapLength)/1000M;
            decimal totalMoney = totalKm * moneyPerKm;

            Console.WriteLine("Money raised: {0:f2}",totalMoney);

        }
    }
}
