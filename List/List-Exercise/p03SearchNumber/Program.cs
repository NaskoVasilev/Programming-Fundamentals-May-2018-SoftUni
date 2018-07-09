using System;
using System.Collections.Generic;
using System.Linq;

namespace p03SearchNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[]arguments = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfElement = arguments[0];
            int numberToDelete = arguments[1];
            int numbertoSearch = arguments[2];
          
            for (int i = 0; i < numberToDelete; i++)
            {
                numbers.RemoveAt(0);
            }

            bool isFound = false;
            for (int i = 0; i < numberOfElement-numberToDelete; i++)
            {
                if(numbertoSearch==numbers[i])
                {
                    isFound = true;
                    break;
                }
            }

            if(isFound)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
