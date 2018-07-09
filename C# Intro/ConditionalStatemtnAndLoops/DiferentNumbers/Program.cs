using System;

namespace DiferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int flag = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    for (int k = j + 1; k <= b; k++)
                    {
                        for (int t = k + 1; t <= b; t++)
                        {
                            for (int v = t + 1; v <= b; v++)
                            {
                                Console.WriteLine($"{i} {j} {k} {t} {v}");
                                flag = 1;
                            }
                        }
                    }
                }
                 
            }
             
            if(flag==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
