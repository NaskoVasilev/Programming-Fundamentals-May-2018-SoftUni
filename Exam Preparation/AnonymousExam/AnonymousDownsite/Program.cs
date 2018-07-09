using System;
using System.Collections.Generic;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWedsites = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());
            decimal loss = 0M;
            List<string> affectedSites = new List<string>(numberOfWedsites);
            for (int i = 0; i < numberOfWedsites; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                long siteVisits = long.Parse(input[1]);
                decimal pricePerVisit = decimal.Parse(input[2]);
                loss += pricePerVisit * siteVisits;
                affectedSites.Add(name);
            }

            foreach (var website in affectedSites)
            {
                Console.WriteLine(website);
            }
            Console.WriteLine($"Total Loss: {loss:F20}");
            BigInteger securityToken = BigInteger.Pow(key, numberOfWedsites);
            Console.WriteLine($"Security Token: {securityToken}");
        }

    }
}
