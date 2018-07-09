using System;
using System.Linq;

namespace p04Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            nums=nums.OrderByDescending(x => x).Take(3).ToArray();
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
