using System;
using System.Collections.Generic;
using System.Linq;

namespace p07BumbNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arguments = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombNum = arguments[0];
            int power = arguments[1];
            int startIndex = 0;
            int endIndex = 0;
            int index = nums.IndexOf(bombNum);

            while (index != -1)
            {
                startIndex = index - power;
                endIndex = index + power;
                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex >= nums.Count)
                {
                    endIndex = nums.Count - 1;
                }
                int count = endIndex - startIndex + 1; 
                nums.RemoveRange(startIndex, count);
                index = nums.IndexOf(bombNum);
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
