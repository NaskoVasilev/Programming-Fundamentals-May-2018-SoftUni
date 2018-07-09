using System;
using System.Collections.Generic;
using System.Numerics;

namespace p02ConvertNumberTo10_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split();
            int fromBase = int.Parse(info[0]);
            string num = info[1];
            BigInteger convertedNum = 0;
            BigInteger pow = 1;
            if (fromBase == 10)
            {
                Console.WriteLine(BigInteger.Parse(num));
            }
            else
            {
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    int digit = int.Parse(num[i].ToString());
                    convertedNum += (BigInteger)(digit * pow);
                    pow *= fromBase;
                }
                Console.WriteLine(convertedNum);
            }
        }
    }
}