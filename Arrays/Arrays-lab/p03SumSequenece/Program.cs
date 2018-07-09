using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int sum = 0;
            nums[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int initialPlace;
                if (i - k < 0)
                {
                    initialPlace = 0;
                }
                else
                {
                    initialPlace = i -k;
                }
                for (int j = initialPlace; j < i; j++)
                {
                     sum += nums[j];
                }
                nums[i] = sum;
                sum = 0;
            }
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
