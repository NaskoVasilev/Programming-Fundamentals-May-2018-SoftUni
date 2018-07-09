using System;
using System.Collections.Generic;
using System.Linq;

namespace p07CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            nums.Sort();
            int pos = 0;
            while (pos < nums.Count)
            {
                int currentNum = nums[pos];
                int count = 0;
                while ((pos + count) < nums.Count && nums[pos + count] == currentNum)
                {
                    count++;
                }
                pos += count;
                Console.WriteLine($"{currentNum} -> {count}");
            }
        }
    }
}
