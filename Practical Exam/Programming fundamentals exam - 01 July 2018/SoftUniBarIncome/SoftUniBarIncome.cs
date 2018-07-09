using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\|%$\.]*%(?<name>[A-Z][a-z]+)%[^\|%$\.]*<(?<product>\w+)>[^\|%$\.]*\|(?<count>\d+)\|[^\|%$\.]*?(?<price>\d+\.?\d*)\$$";
            Regex regex = new Regex(pattern);
            string input = string.Empty;
            List<string> orders = new List<string>();
            double totalIncome = 0.00;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string custumerName = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count  = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = count * price;
                    totalIncome += totalPrice;

                    string order = $"{custumerName}: {product} - {totalPrice:f2}";
                    orders.Add(order);
                }
            }

            foreach (string order in orders)
            {
                Console.WriteLine(order);
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
