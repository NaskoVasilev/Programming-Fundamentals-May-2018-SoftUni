using System;
using System.Linq;
using System.Text;

namespace p07Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            if(multiplier==0)
            {
                Console.WriteLine("0");
                Environment.Exit(0);
            }

            StringBuilder num = new StringBuilder(firstNum.Length);
            int remainder = 0;
            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int firstDigit = int.Parse(firstNum[i].ToString());

                int sum = firstDigit * multiplier + remainder;
                remainder = 0;
                num.Append(sum % 10);
                remainder = sum / 10;
            }
            num.Append(remainder);
            string number = num.ToString().TrimEnd('0');
            Console.WriteLine(string.Join("", number.Reverse()));
        }
    }
}
