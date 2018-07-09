using System;

namespace p04Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbertInHexadecimal = Console.ReadLine();
            int number = Convert.ToInt32(numbertInHexadecimal, 16);
            Console.WriteLine(number);
        }
    }
}
