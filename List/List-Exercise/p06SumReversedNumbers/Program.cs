using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p06SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().
                Split().
                ToList();
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
               sum+= ReversedNum(nums[i]);
            }
            Console.WriteLine(sum);
        }

        static int ReversedNum(string num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                sb.Append(num[i]);
            }
            return int.Parse(sb.ToString());
        }
    }
}
