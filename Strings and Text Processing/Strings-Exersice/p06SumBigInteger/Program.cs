using System;
using System.Linq;
using System.Text;

namespace p06SumBigInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstnum = Console.ReadLine();
            string secondNum = Console.ReadLine();

            int length = Math.Max(firstnum.Length, secondNum.Length);
            firstnum = firstnum.PadLeft(length, '0');
            secondNum = secondNum.PadLeft(length, '0');

            StringBuilder num = new StringBuilder(length);
            int remainder = 0;
            for (int i = length-1; i >=0; i--)
            {
                int firstDigit = int.Parse(firstnum[i].ToString());
                int secondDigit = int.Parse(secondNum[i].ToString());

                int sum = firstDigit + secondDigit+remainder;
                remainder = 0;
                if(sum>=10)
                {
                    sum -= 10;
                    remainder++;
                }
                num.Append(sum);
            }
            num.Append(remainder);
            string number = num.ToString().TrimEnd('0');
            Console.WriteLine(string.Join("",number.Reverse()));
        }
    }
}
