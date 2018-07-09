using System;
using System.Collections.Generic;
using System.Linq;

namespace p04LongestIncreasingSubSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int numListLength = numList.Count;
            int[] lengths = new int[numListLength]
                .Select(n => n = 1)
                .ToArray();

            int[] previousLongestEndIndex = lengths
                .Select(n => n = -1)
                .ToArray();

            for (int anchor = 1; anchor < numListLength; anchor++)
            {
                int anchorNum = numList[anchor];
                for (int j = 0; j < anchor; j++)
                {
                    int currentNum = numList[j];
                    if (currentNum < anchorNum && lengths[j] == lengths[anchor])
                    {
                        lengths[anchor]++;
                        previousLongestEndIndex[anchor] = j;
                    }
                }
            }

            int maxSubsequenceIndex = Array.IndexOf(lengths, lengths.Max());
            var maxSubsequence = new List<int>();
            for (int i = maxSubsequenceIndex; i >= 0;)
            {
                maxSubsequence.Add(numList[i]);
                i = previousLongestEndIndex[i];
            }
            maxSubsequence.Reverse();
            Console.WriteLine(string.Join(" ", maxSubsequence));
        }
    }
}
