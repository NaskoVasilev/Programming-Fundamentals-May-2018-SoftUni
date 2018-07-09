using System;
using System.Linq;

namespace p02RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counOfRotations = int.Parse(Console.ReadLine());
            int[] rotatedNums = new int[nums.Length];
            int[] sum = new int[nums.Length];

            for (int i = 0; i < counOfRotations; i++)
            {
                rotatedNums = Rotete(nums);
                for (int j = 0; j < nums.Length; j++)
                {
                    sum[j] = rotatedNums[j] +sum[j];
                }
                nums = rotatedNums;
            }
            Console.WriteLine(string.Join(" ",sum));
        }

        static int[] Rotete(int[] nums)
        {
            int[] rotatedNums = new int[nums.Length];
            rotatedNums[0] = nums[nums.Length - 1];
            for (int i = 1; i < nums.Length; i++)
            {
                rotatedNums[i] = nums[i - 1];
            }
            return rotatedNums;
        }
    }
}
