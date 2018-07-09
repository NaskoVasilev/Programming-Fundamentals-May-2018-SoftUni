using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foood
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int energyper100ml = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            double energy = (quantity / 100.00) * energyper100ml;
            double allSugar = (quantity / 100.00) * sugar;
            Console.WriteLine($"{quantity}ml {name}:");
            Console.WriteLine($"{energy}kcal, {allSugar}g sugars");
        }
    }
}
