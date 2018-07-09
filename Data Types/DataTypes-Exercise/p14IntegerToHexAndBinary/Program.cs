using System;

namespace p14IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numInHexadeciamal = Convert.ToString(num, 16);
            string numInBinary = Convert.ToString(num, 2);
            Console.WriteLine(numInHexadeciamal.ToUpper());
            Console.WriteLine(numInBinary);
        }
    }
}
