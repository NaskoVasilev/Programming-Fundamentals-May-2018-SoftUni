using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "3:1")
                {
                    break;
                }

                if (input[0] == "merge")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex >= words.Count)
                    {
                        continue;
                    }
                    if (endIndex >= words.Count)
                    {
                        endIndex = words.Count - 1;
                    }
                    if(endIndex<0)
                    {
                        continue;
                    }

                    string merged = "";
                    for (int j = startIndex; j <= endIndex; j++)
                    {
                        merged += words[j];
                    }
                    for (int j = endIndex; j >= startIndex; j--)
                    {
                        words.RemoveAt(j);
                    }
                    words.Insert(startIndex, merged);
                }
                else
                {
                    int index = int.Parse(input[1]);
                    int partions = int.Parse(input[2]);
                    string word = words[index];
                    int lengthOfPartions = word.Length / partions;
                    int lengthOfLast = lengthOfPartions;
                    if(word.Length%partions!=0)
                    {
                        lengthOfLast += word.Length % partions;
                    }
                    int startIndex = 0;
                    for (int i = 0; i < partions-1; i++)
                    {
                        string dividedWord = word.Substring(startIndex, lengthOfPartions);
                        words.Insert(index, dividedWord);
                        index++;
                        startIndex += lengthOfPartions;
                    }
                    string lastDividedWord = word.Substring(startIndex, lengthOfLast);
                    words.Insert(index, lastDividedWord);

                    words.Remove(word);
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
