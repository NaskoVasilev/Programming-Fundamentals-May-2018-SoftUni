using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string str1 = words[0];
            string str2 = words[1];
            Console.WriteLine(GetMultiplication(str1, str2));
        }

        private static int GetMultiplication(string str1, string str2)
        {
            int sum = 0;
            int str1Len = str1.Length;
            int str2Len = str2.Length;
            int length = Math.Max(str1.Length, str2.Length);

            for (int i = 0; i < length; i++)
            {
                if(str1Len>i&&str2Len>i)
                {
                    sum += str1[i] * str2[i];
                }
                else if (str1Len>i)
                {
                    sum += str1[i];
                }
                else 
                {
                    sum += str2[i];
                }
                
            }
            return sum;
        }
    }
}
