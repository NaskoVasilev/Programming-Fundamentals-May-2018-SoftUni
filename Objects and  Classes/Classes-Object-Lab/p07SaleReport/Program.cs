using System;
using System.Collections.Generic;
using System.Linq;

namespace p07SaleReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            Sales[] orders = new Sales[numberOfOrders];

            for (int i = 0; i < numberOfOrders; i++)
            {
                orders[i] = GetSale();
            }

            SortedDictionary<string, double> salesByTown = new SortedDictionary<string, double>();

            for (int i = 0; i < orders.Length; i++)
            {
                string townName = orders[i].Town;
                double sum = orders[i].Sum;
                if(salesByTown.ContainsKey(townName)==false)
                {
                    salesByTown.Add(townName, 0);
                }
                salesByTown[townName] += sum;
            }

            foreach (var pair in salesByTown)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }

        }

        class Sales
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public double Price { get; set; }
            public double Quantity { get; set; }
            public double Sum
            {
                get
                {
                    return Price * Quantity;
                }
            }
        }

        static Sales GetSale()
        {
            Sales sale = new Sales();
            string []info = Console.ReadLine().Split();
            sale.Town = info[0];
            sale.Product = info[1];
            sale.Price = double.Parse(info[2]);
            sale.Quantity = double.Parse(info[3]);
            return sale;
        }
    }
}
