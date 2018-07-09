using System;
using System.Collections.Generic;
using System.Linq;

namespace p04tIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            LongestIncreasingSeq(nums);
        }
        static void LongestIncreasingSeq(int[] input)
        {
            int[] len = new int[input.Length];
            int[] prev = new int[input.Length];
            int max = int.MinValue;

            len[0] = 1;

            for (int i = 0; i < input.Length; i++)
            {
                prev[i] = -1;
            }

            for (int i = 1; i < input.Length; i++)
            {
                len[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (input[j] < input[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                        if (len[i] > max)
                        {
                            max = len[i];
                        }
                    }
                }
            }

            List<int> longIncreasingSubseq = new List<int>();
            int index = Array.IndexOf(len, max);
            if (input.Length == 1)
            {
                index = 0;
            }
            longIncreasingSubseq.Add(input[index]);

            while (true)
            {
                index = prev[index];
                if (index < 0)
                {
                    break;
                }
                longIncreasingSubseq.Add(input[index]);
            }
            longIncreasingSubseq.Reverse();
            Console.WriteLine(string.Join(" ", longIncreasingSubseq));
        }
    }
}

