using System;

namespace p08GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "string")
            {
                string n = Console.ReadLine();
                string a = Console.ReadLine();
                Console.WriteLine(GetMax(a, n));
            }
            else if (type == "int")
            {
                int n = int.Parse(Console.ReadLine());
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, n));
            }
            else
            {
                char n = char.Parse(Console.ReadLine());
                char a = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, n));
            }

        }

        static int GetMax(int a, int n)
        {
            return Math.Max(a, n);
        }

        static char GetMax(char a, char n)
        {
            if (a <= n)
            {
                return n;
            }
            else
            {
                return a;
            }
        }

        static string GetMax(string a, string n)
        {
            if (a.CompareTo(n) >= 0)
            {
                return a;
            }
            else
            {
                return n;
            }
        }
    }
}

