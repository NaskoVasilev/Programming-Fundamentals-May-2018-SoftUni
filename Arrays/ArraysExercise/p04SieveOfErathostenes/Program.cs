using System;

namespace p04SieveOfErathostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];

            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    Console.WriteLine(i);
                    for (int j = 2; j <= n / i; j++)
                    {
                        primes[j * i] = false;
                    }
                }

            }
        }
    }
}
