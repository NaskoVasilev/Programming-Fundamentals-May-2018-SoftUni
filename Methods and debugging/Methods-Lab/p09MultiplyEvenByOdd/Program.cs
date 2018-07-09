using System;

namespace p09MultiplyEvenByOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            int result = MultiplyEvenByOdd(num);
            Console.WriteLine(result);
        }

        static int MultiplyEvenByOdd(int num)
        {
            int oddSum = 0;
            int evenSum = 0;
            while (num > 0)
            {
                if ((num % 10) % 2 == 0)
                {
                    evenSum += num % 10;
                }
                else
                {
                    oddSum += num % 10;
                }
                num /= 10;
            }
            return oddSum * evenSum;
        }
    }
}

