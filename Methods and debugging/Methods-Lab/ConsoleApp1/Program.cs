using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reciept();
        }
        static void Top()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void Middle()
        {
            Console.WriteLine("Charged to____________________ ");
            Console.WriteLine("Received by___________________ ");
        }
        static void Bottom()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
        static void Reciept()
        {
            Top();
            Middle();
            Bottom();
        }
    }

}
    

