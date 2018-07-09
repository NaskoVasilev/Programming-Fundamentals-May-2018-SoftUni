using System;
using System.Linq;

namespace p06FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();

            int k = nums.Length / 4;
            int[] left = nums.
                Take(k)
                .Reverse()
                .ToArray();

            int[] right = nums
                .Skip(3 * k)
                .Take(k)
                .Reverse()
                .ToArray();

            int[] middle = nums.Skip(k)
                .Take(2 * k)
                .ToArray();


            left = left.Concat(right).ToArray();

            int[] sum = middle.Select((x, index) => x + left[index]).ToArray();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
