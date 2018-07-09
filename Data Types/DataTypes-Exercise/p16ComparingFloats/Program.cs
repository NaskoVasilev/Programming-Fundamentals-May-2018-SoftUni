using System;

namespace p16ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double diference = Math.Abs(a - b);
            bool isEqual = diference < 0.000001;
            Console.WriteLine(isEqual);
        }
    }
}
