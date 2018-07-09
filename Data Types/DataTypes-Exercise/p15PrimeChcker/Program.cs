using System;

namespace p15PrimeChcker
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            for (int num = 2; num <= end; num++)
            {
                bool isPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(num); divider++)
                {
                    if(num%divider==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {isPrime}");
            }

        }
    }
}
