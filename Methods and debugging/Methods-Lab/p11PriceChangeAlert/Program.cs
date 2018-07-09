using System;

namespace p11PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfprices = int.Parse(Console.ReadLine());
            double significance = double.Parse(Console.ReadLine());
            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfprices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double diferenceInPercentage = GetPercentage(previousPrice, currentPrice);
                bool isMajorChange = GetKindOfChange(diferenceInPercentage, significance);
                string message = GetOutput(currentPrice, previousPrice, diferenceInPercentage, isMajorChange);
                Console.WriteLine(message);
                previousPrice = currentPrice;
            }
        }

        private static string GetOutput(double currentPrice, double prevoiusPrice, double diference, bool isMajorChange)
        {
            string message = "";
            if (diference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isMajorChange)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", prevoiusPrice, currentPrice, diference * 100);
            }
            else if (isMajorChange && (diference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", prevoiusPrice, currentPrice, diference * 100);
            }
            else if (isMajorChange && (diference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", prevoiusPrice, currentPrice, diference * 100);
            }
            return message;
        }
        private static bool GetKindOfChange(double diferenceInPercentage, double significance)
        {
            if (Math.Abs(diferenceInPercentage) >= significance)
            {
                return true;
            }
            return false;
        }

        private static double GetPercentage(double previousPrice, double currentPrice)
        {
            double diferenceInPercentage = (currentPrice - previousPrice) / previousPrice;
            return diferenceInPercentage;
        }
    }
}


