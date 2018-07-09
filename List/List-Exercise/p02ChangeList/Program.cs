using System;
using System.Collections.Generic;
using System.Linq;

namespace p02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "Odd" && command != "Even")
            {
                string[] arguments = command.Split();
                string action = arguments[0];
                int element = int.Parse(arguments[1]);
                if (action == "Delete")
                {
                    Delete(numbers, element);
                }
                else
                {
                    int pos = int.Parse(arguments[2]);
                    numbers.Insert(pos, element);
                }

                command = Console.ReadLine();
            }
            
            if(command=="Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if(numbers[i]%2!=0)
                    {
                        Console.Write("{0} ",numbers[i] );
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write("{0} ", numbers[i]);
                    }
                }
            }
            Console.WriteLine();
        }

        static void Delete(List<int> numbers, int element)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i]==element)
                {
                    numbers.Remove(element);
                    i--;
                }
            }
        }
    }
}
