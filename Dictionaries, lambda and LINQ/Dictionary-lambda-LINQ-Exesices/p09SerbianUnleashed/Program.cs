using System;
using System.Collections.Generic;
using System.Linq;

namespace p10SerbianUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> venues = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(" @");
                if(tokens.Length<2)
                {
                    continue;
                }
                string name = tokens[0];
                string[] info = tokens[1].Split(' ');

                if(info.Length<3)
                {
                    continue;
                }
                string ticketCountAsString = info[info.Length - 1];
                string priceAsString = info[info.Length - 2];
                int ticketCount = 0;
                double ticketPrice = 0;

                bool ticketCountIsValid = int.TryParse(ticketCountAsString,out ticketCount);
                if(ticketCountIsValid == false)
                {
                    continue;
                }

                bool priceIsValid = double.TryParse(priceAsString, out ticketPrice);
                if(priceIsValid==false)
                {
                    continue;
                }

                string venue = "";

                for (int i = 0; i < info.Length-2; i++)
                {
                    venue += info[i];
                    venue += " ";
                }
                venue = venue.TrimEnd();

                if (venues.ContainsKey(venue)==false)
                {
                    Dictionary<string, double> singers = new Dictionary<string, double>();
                    singers.Add(name, ticketPrice * ticketCount);
                    venues.Add(venue, singers);
                }
                else
                {
                    if (venues[venue].ContainsKey(name)==false)
                    {
                        venues[venue].Add(name, 0);
                    }
                    venues[venue][name] += ticketCount * ticketPrice;
                }
            }

            foreach (var venue in venues)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
