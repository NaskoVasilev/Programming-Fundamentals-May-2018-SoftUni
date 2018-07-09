using System;
using System.Linq;

namespace p07MaxSequenceOfIncreasingElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bestIndex = 0;
            int bestLength = 1;
            int currentLength = 1; ;

            for (int i = 1; i < seq.Length; i++)
            {
                if(seq[i-1]<seq[i])
                {
                    currentLength++;
                    if(bestLength<currentLength)
                    {
                        bestLength = currentLength;
                        bestIndex = i;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
            int startIndex = bestIndex - bestLength+1;
            for (int i = startIndex; i <= bestIndex; i++)
            {
                Console.Write($"{seq[i]} ");
            }
            Console.WriteLine();
        }
    }
}
