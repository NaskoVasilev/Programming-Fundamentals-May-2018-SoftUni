using System;
using System.Linq;

namespace p03IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstCirle = Console.ReadLine();
            string secondCircle = Console.ReadLine();
            Circle c1 = ReadCircle(firstCirle);
            Circle c2 = ReadCircle(secondCircle);

            bool isInside = Intersect(c1, c2);
            if (isInside)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }
        }

        static bool Intersect(Circle c1, Circle c2)
        {
            double distanceBetweenCentres = GetDistance(c1.Center, c2.Center);
            if (distanceBetweenCentres <= c1.Radius + c2.Radius)
            {
                return true;
            }
            return false;
        }

        static double GetDistance(Point p1, Point p2)
        {
            double a = p1.X = p2.X;
            double b = p1.Y - p2.Y;
            double distance = Math.Sqrt(a * a + b * b);
            return distance;
        }

        static Circle ReadCircle(string input)
        {
            Circle circle = new Circle();
            int[] info = input.Split().Select(int.Parse).ToArray();
            circle.Center = new Point() { X = info[0], Y = info[1] };
            circle.Radius = info[2];
            return circle;
        }
    }
}

