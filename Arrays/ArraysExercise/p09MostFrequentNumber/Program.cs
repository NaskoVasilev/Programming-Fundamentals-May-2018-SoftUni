using System;
using System.Linq;

namespace p09MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentCount = 0;
            int maxCount = 0;
            int mostFrequentDigit = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        currentCount++;
                    }
                }
                if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    mostFrequentDigit = nums[i];
                }
                currentCount = 0;
            }
            Console.WriteLine(mostFrequentDigit);
        }
    }
}
