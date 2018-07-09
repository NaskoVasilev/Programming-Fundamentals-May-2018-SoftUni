using System;

namespace p08LettersChangeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] {' ','\t' }
            ,StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;
            foreach (var word in words)
            {
                char firtsDigit = word[0];
                char lastDigit = word[word.Length - 1];
                int number = int.Parse(word.Substring(1, word.Length - 2));
                double sum = 0;

                if (char.IsUpper(firtsDigit))
                {
                    sum += number / (firtsDigit - 64.00);
                }
                else
                {
                    sum += number * (firtsDigit - 96.00);
                }

                if (char.IsUpper(lastDigit))
                {
                    sum -= lastDigit - 64.00;
                }
                else
                {
                    sum += lastDigit - 96.00;
                }
                totalSum += sum;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
