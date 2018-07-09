using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int trashedHeadsets = lostGamesCount / 2;
            int trashedMouses = lostGamesCount / 3;
            int trashedKeyboars = lostGamesCount / 6;
            int trashedDisplayss = lostGamesCount / 12;

            decimal headsetExpenses = trashedHeadsets * headsetPrice;
            decimal mouseExpenses = trashedMouses * mousePrice;
            decimal keyboardExpenses = keyboardPrice * trashedKeyboars;
            decimal displayExpenses = trashedDisplayss * displayPrice;

            decimal regeExpenses = headsetExpenses + mouseExpenses + keyboardExpenses + displayExpenses;

            Console.WriteLine($"Rage expenses: {regeExpenses:f2} lv.");
        }
    }
}
