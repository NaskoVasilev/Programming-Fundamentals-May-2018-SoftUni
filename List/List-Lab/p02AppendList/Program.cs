using System;
using System.Collections.Generic;
using System.Linq;

namespace p02AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] subArray = input.Split('|').ToArray();
            List<int> list = new List<int>();

            for (int i = subArray.Length - 1; i >= 0; i--)
            {
                int[] nums = subArray[i].
                    Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                list.AddRange(nums);
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
