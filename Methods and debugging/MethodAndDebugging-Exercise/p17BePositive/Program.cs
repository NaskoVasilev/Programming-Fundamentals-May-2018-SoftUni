using System;
using System.Collections.Generic;

namespace p17BePositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                List<int> numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }
                bool isPositiveNum = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (isPositiveNum)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(currentNum);
                        isPositiveNum = true;
                    }
                    else if (currentNum < 0 && j != numbers.Count - 1)
                    {
                        currentNum += numbers[j + 1];
                        if (currentNum >= 0)
                        {
                            if (isPositiveNum)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(currentNum);
                            isPositiveNum = true;
                        }
                        j++;
                    }
                }

                if (!isPositiveNum)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

