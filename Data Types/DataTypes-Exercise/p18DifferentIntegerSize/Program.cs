using System;

namespace p18DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();
            string properTypes = null;

            bool isPossible = sbyte.TryParse(numAsString, out sbyte sbyteResult);
            if (isPossible)
            {
                properTypes += "* sbyte\r\n";
            }
            isPossible = byte.TryParse(numAsString, out byte byteResult);
            if (isPossible)
            {
                properTypes += "* byte\r\n";
            }
            isPossible = short.TryParse(numAsString, out short shortResult);
            if (isPossible)
            {
                properTypes += "* short\r\n";
            }
            isPossible = ushort.TryParse(numAsString, out ushort ushortResult);
            if (isPossible)
            {
                properTypes += "* ushort\r\n";
            }
            isPossible = int.TryParse(numAsString, out int intResult);
            if (isPossible)
            {
                properTypes += "* int\r\n";
            }
            isPossible = uint.TryParse(numAsString, out uint uintResult);
            if (isPossible)
            {
                properTypes += "* uint\r\n";
            }
            isPossible = long.TryParse(numAsString, out long longResult);
            if (isPossible)
            {
                properTypes += "* long\r\n";
            }
            if (properTypes != null)
            {
                Console.WriteLine("{0} can fit in:", numAsString);
                Console.WriteLine(properTypes);
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", numAsString);
            }
        }
    }
}
