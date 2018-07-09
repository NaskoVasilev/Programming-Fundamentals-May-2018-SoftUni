using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] bestSeq = { 0, 0, 0, 0, 0 };
            int sample = 1;
            int bestSample = -1;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }

                int[] seq = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currMaxSeq = GetMaxSubSequence(seq);
                int previousMaxSeq = GetMaxSubSequence(bestSeq);
                int currIndex = GetBestIndex(seq);
                int previousIndex = GetBestIndex(bestSeq);
                if (previousMaxSeq < currMaxSeq)
                {
                    bestSeq = seq.ToArray();
                    bestSample = sample;
                }
                else if (previousMaxSeq == currMaxSeq)
                {
                    if (previousIndex > currIndex)
                    {
                        bestSeq = seq.ToArray();
                        bestSample = sample;

                    }
                    else if (previousIndex == currIndex)
                    {
                        if (bestSeq.Sum() < seq.Sum())
                        {
                            bestSample = sample;
                            bestSeq = seq.ToArray();
                        }
                    }


                }
                sample++;
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSeq.Sum()}.");
            Console.WriteLine(string.Join(" ",bestSeq));
        }

        static int GetMaxSubSequence(int[] seq)
        {
            int maxSeq = 0;
            for (int i = 0; i < seq.Length - 1; i++)
            {
                if (seq[i] == seq[i + 1] && seq[i] == 1)
                {
                    maxSeq++;
                }
            }
            return maxSeq;
        }

        static int GetBestIndex(int[]seq)
        {
            for (int i = 0; i < seq.Length-1; i++)
            {
                if(seq[i]==seq[i+1]&&seq[i]==1)
                {
                    return i;
                }
            }
            return seq.Length;
        }
    }
}
