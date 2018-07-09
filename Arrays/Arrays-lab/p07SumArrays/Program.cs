using System;
using System.Linq;

namespace p07SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstLength = first.Length;
            int secondLength = second.Length;
            int sumLength = Math.Max(firstLength, secondLength);
            int[] sum = new int[sumLength];
            for (int i = 0; i < sumLength; i++)
            {
                sum[i] = first[i % firstLength] + second[i % secondLength];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
