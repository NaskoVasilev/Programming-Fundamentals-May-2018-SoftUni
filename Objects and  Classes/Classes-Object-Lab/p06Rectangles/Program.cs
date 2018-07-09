using System;
using System.Linq;

namespace p06Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            bool isInside = Rectangle.IsInside(r1, r2);
            if(isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }
        }

        class Rectangle
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }
            public int Bottom
            {
                get
                {
                    return Top - Height;
                }
            }
            public static bool IsInside(Rectangle r1, Rectangle r2)
            {
                if ((r1.Left >= r2.Left) && (r1.Right <= r2.Right) &&
                    (r1.Top <= r2.Top) && (r1.Bottom >= r2.Bottom))
                {
                    return true;
                }
                return false;
            }

        }

        static Rectangle ReadRectangle()
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle r = new Rectangle();
            r.Left = info[0];
            r.Top = info[1];
            r.Width = info[2];
            r.Height = info[3];
            return r;
        }
    }
}
