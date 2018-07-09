using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] ladybugs = new int[size];
            for (int i = 0; i < initialIndexes.Length; i++)
            {
                if (initialIndexes[i] < ladybugs.Length && initialIndexes[i] >= 0)
                {
                    ladybugs[initialIndexes[i]] = 1;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] tokens = input.Split();
                int index = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLength = int.Parse(tokens[2]);
                if (index >= ladybugs.Length || index < 0 || ladybugs[index] == 0)
                {
                    continue;
                }

                if (direction == "right")
                {
                    int nextIndex = index + flyLength;
                    ladybugs[index] = 0;
                    if (nextIndex < ladybugs.Length)
                    {

                        if (ladybugs[nextIndex] == 0)
                        {
                            ladybugs[nextIndex] = 1;
                        }
                        else
                        {
                            while (true)
                            {
                                nextIndex += flyLength;
                                if (nextIndex >= ladybugs.Length)
                                {
                                    break;
                                }
                                if (ladybugs[nextIndex] == 0)
                                {
                                    ladybugs[nextIndex] = 1;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    int previousIndex = index - flyLength;
                    ladybugs[index] = 0;
                    if (previousIndex >= 0)
                    {
                        if (ladybugs[previousIndex] == 0)
                        {
                            ladybugs[previousIndex] = 1;
                        }
                        else
                        {
                            while (true)
                            {
                                previousIndex -= flyLength;
                                if (previousIndex < 0)
                                {
                                    break;
                                }
                                if (ladybugs[previousIndex] == 0)
                                {
                                    ladybugs[previousIndex] = 1;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", ladybugs));
        }
    }
}
