using System;
using System.Collections.Generic;

namespace p07PrimeNumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<int> primeNumbers = GetPrimeNumbers(start, end);
            Console.WriteLine(string.Join(", ",primeNumbers));
        }

        private static List<int> GetPrimeNumbers(int start, int end)
        {
            List<int> primeNumbers = new List<int>();
            for (int num = start; num <= end; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if(num%i==0)
                    {
                        isPrime = false;
                    }
                }
                if(isPrime)
                {
                    primeNumbers.Add(num);
                }
            }
            return primeNumbers;
        }
    }
}
