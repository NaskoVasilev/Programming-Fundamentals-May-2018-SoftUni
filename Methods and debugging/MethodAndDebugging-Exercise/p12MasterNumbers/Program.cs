using System;

namespace p12MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                bool isPolindrom = CheckForPolindrom(i);
                bool sumOfDigitIsDividableBy7 = CheckForDividableBy7SumOfDigit(i);
                bool containEvenDigit = CheckForEvenDigit(i);
                if (isPolindrom && sumOfDigitIsDividableBy7 && containEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool CheckForEvenDigit(int num)
        {
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

        private static bool CheckForDividableBy7SumOfDigit(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool CheckForPolindrom(int num)
        {
            string numAsString = num.ToString();
            int middle = numAsString.Length / 2;
            int length = numAsString.Length;
            int count = 0;
            for (int i = 0; i < middle; i++)
            {
                if (numAsString[i] == numAsString[length-1-i])
                {
                    count++;
                }
            }
            if (count == middle)
            {
                return true;
            }
            return false;
        }
    }
}
