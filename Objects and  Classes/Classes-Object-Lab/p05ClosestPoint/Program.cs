using System;
using System.Collections.Generic;
using System.Linq;

namespace p05ClosestPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            Point[] points = new Point[numberOfPoints];

            for (int i = 0; i < numberOfPoints; i++)
            {
                points[i] = ReadPoint();
            }

            List<Point> closestPoint = FindClosestPoint(points);
            double distance = GetDistance(closestPoint[0], closestPoint[1]);

            Console.WriteLine("{0:f3}",distance);
            Console.WriteLine($"({closestPoint[0].X}, {closestPoint[0].Y})");
            Console.WriteLine($"({closestPoint[1].X}, {closestPoint[1].Y})");

        }

        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        static Point ReadPoint()
        {
            Point p = new Point();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            p.X = input[0];
            p.Y = input[1];
            return p;
        }

        static double GetDistance(Point p1, Point p2)
        {
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);
            double distance = Math.Sqrt(a * a + b * b);
            return distance;
        }

        static List<Point> FindClosestPoint(Point[] points)
        {
            double minDistance =double.MaxValue;
            List<Point> closestPoint = new List<Point>();
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                    double distance = GetDistance(points[i], points[j]);
                    if(minDistance>distance)
                    {
                        minDistance = distance;
                        closestPoint.Clear();
                        closestPoint.Add(points[i]);
                        closestPoint.Add(points[j]);
                    }
                }
            }
            return closestPoint;
        }
    }
}
