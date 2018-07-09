using System;
using System.Linq;

namespace p08CondensedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length];
            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }
            int length = nums.Length;
            int countOfChanges = nums.Length;
            for (int i = 0; i < countOfChanges; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                nums = condensed;
                length--;
            }
            
            if(nums.Length>1)
            {
                Console.WriteLine(condensed[0]);
            }
        }
    }
}
