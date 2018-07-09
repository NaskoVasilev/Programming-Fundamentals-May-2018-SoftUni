using System;
using System.Text;

namespace p04ReversedOreder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string reversed = ReverseNumber(number);
            Console.WriteLine(reversed); 
        }

        private static string ReverseNumber(string number)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = number.Length-1 ; i >= 0; i--)
            {
                sb.Append(number[i]);
            }
            return sb.ToString();
        }
    }
}
