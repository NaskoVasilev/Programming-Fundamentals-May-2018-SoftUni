using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace p01NumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split();
            int toBase = int.Parse(info[0]);
            BigInteger num = BigInteger.Parse(info[1]);
            List<int> convertedNum = new List<int>();

            while (num > 0)
            {
                int digit = (int)(num % toBase);
                convertedNum.Add(digit);
                num = num / toBase;
            }
            convertedNum.Reverse();
            Console.WriteLine(string.Join("", convertedNum));


        }
    }
}
