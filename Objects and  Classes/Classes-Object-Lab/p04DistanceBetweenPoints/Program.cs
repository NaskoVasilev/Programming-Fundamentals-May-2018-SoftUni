using System;
using System.Linq;

namespace p04DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            double distance = Point.GetDistance(p1, p2);
            Console.WriteLine("{0:f3}",distance);
        }
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public static double GetDistance(Point p1, Point p2)
            {
                double a = Math.Abs(p1.X - p2.X);
                double b = Math.Abs(p1.Y - p2.Y);
                double distance = Math.Sqrt(a * a + b * b);
                return distance;
            }
        }

        static Point ReadPoint()
        {
            Point p = new Point();
            double []input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            p.X = input[0];
            p.Y = input[1];
            return p;
        }
    }
}
