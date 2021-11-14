using System;

namespace Naukaa30_creatingObject_
{
    class Program30
    {
        static void Main(string[] args)
        {
            Point p1 = new() { X = 5, Y = 10 };
            Point p2 = new() { X = 7, Y = 3 };

            //Point p1 = new Point();
            //Point p2 = new Point();

            //p1.X = 5;
            //p1.Y = 10;
            //p2.X = 7;
            //p2.Y = 3;

            //var p1 = new Point { X = 5, Y = 10 };
            //var p2 = new Point { X = 7, Y = 3 };

            int x = 11;

            Console.WriteLine($"another text {p1.X} {p1.Y} {x}");//without $, it doesn't work
        }
    }
    public class Point
    {
        public int X; // how about get set?

        public int Y;

    }

}
