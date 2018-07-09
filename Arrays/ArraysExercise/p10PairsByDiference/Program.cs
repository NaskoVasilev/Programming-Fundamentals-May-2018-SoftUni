using System;
using System.Linq;

namespace p10PairsByDiference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diferance = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] - nums[j] == diferance)
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine(count);
        }
    }
}

