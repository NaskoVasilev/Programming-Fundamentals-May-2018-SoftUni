using System;
using System.Linq;

namespace p11EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool existIndex = false;

            for (int i = 0; i < nums.Length; i++)
            {
                leftSum = GetLeftSum(nums, i);
                rightSum = GteRightSum(nums, i);
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    existIndex = true;
                    break;
                }
            }
            if (!existIndex)
            {
                Console.WriteLine("no");
            }
        }

        static int GteRightSum(int[] nums, int index)
        {
            int sum = 0;
            for (int i = index+1; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        static int GetLeftSum(int[] nums, int index)
        {
            int sum = 0;
            for (int i = 0; i < index; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
