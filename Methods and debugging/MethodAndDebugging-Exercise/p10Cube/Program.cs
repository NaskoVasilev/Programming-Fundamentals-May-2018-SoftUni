using System;

namespace p10Cube
{
    class Program
    {
        static void Main(string[] args)
        {

            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            switch(parameter)
            {
                case "face":
                    double faceDiagonal = GetFaceDiagonal(side);
                    Console.WriteLine("{0:f2}", faceDiagonal);
                    break;
                case "space":
                    double spaceDiagonal = GetSpaceDiagonal(side);
                    Console.WriteLine("{0:f2}", spaceDiagonal);
                    break;
                case "area":
                    double area = GetArea(side);
                    Console.WriteLine("{0:f2}",area);
                    break;
                case "volume":
                    double volume = GetVolume(side);
                    Console.WriteLine("{0:f2}", volume);
                    break;
            }
        }

        private static double GetVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        private static double GetArea(double side)
        {
            return 6 * side * side;
        }

        private static double GetSpaceDiagonal(double side)
        {
            return Math.Sqrt(3 * side * side); 
        }

        private static double GetFaceDiagonal(double side)
        {
            return Math.Sqrt(2 * side * side);
        }
    }
}
