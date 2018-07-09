using System;
using System.Collections.Generic;
using System.Linq;

namespace p05ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "print")
            {
                string[] arguments = command.Split();
                string action = arguments[0];
                int index = 0;
                int element = 0;
                switch (action)
                {
                    case "add":
                        index = int.Parse(arguments[1]);
                        element = int.Parse(arguments[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        index = int.Parse(arguments[1]);
                        List<int> elements = new List<int>();
                        for (int i = 2; i < arguments.Length; i++)
                        {
                            elements.Add(int.Parse(arguments[i]));
                        }
                        numbers.InsertRange(index, elements);
                        break;
                    case "sumPairs":
                        SumPair(numbers);
                        break;
                    case "shift":
                        int rotations = int.Parse(arguments[1]);
                        Shift(rotations, numbers);
                        break;
                    case "remove":
                        index = int.Parse(arguments[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "contains":
                        element = int.Parse(arguments[1]);
                        index = numbers.IndexOf(element);
                        Console.WriteLine(index);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static void SumPair(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }
        }

        static void Shift(int rotations, List<int> numbers)
        {
            rotations = rotations % numbers.Count;
            /*for (int i = 0; i < rotations; i++)
            {
                arr[i] = numbers[i];
            }
            for (int i = 0; i < numbers.Count - rotations; i++)
            {
                numbers[i] = numbers[i + rotations];
            }
            int index = 0;
            for (int i = numbers.Count - rotations; i < numbers.Count; i++)
            {
                numbers[i] = arr[index];
                index++;
            }
            */
            for (int i = 0; i < rotations; i++)
            {
                int temp = numbers[0];
                numbers.Add(temp);
                numbers.RemoveAt(0);
            }
        }
    }
}
