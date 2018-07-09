using System;
using System.Collections.Generic;
using System.Linq;

namespace p01CountRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double,int> counts = new SortedDictionary< double,int>();
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (double item in nums)
            {
                if(!counts.ContainsKey(item))
                {
                    counts.Add(item, 1);
                }
                else
                {
                    counts[item]++;
                }
            }

            foreach (var pair in counts)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
