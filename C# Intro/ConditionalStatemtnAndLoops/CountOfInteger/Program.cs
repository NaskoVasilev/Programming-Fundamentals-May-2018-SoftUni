using System;

namespace CountOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            while (true)
            {
                bool isNumber = int.TryParse(input, out int result);
                if(isNumber)
                {
                    count++;
                }
                else
                {
                    break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(count);
        }
    }
}
