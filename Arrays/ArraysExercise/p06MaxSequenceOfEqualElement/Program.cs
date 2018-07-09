using System;
using System.Linq;

namespace p06MaxSequenceOfEqualElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxSequence = 0;
            int currentSequence = 0;
            int currentDigit=0;
            int maxSeqDigit = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {

                if (sequence[i] == sequence[i + 1])
                {
                    currentSequence++;
                    currentDigit = sequence[i];
                    if (maxSequence < currentSequence)
                    {
                        maxSequence = currentSequence;
                        maxSeqDigit = currentDigit;
                    }
                }
                else
                {
                    currentSequence = 0;
                }
            }

            for (int i = 0; i <= maxSequence; i++)
            {
                Console.Write(maxSeqDigit + " ");
            }
            Console.WriteLine();
        }
    }
}
