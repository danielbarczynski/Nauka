using System;

namespace OperatorOverloadExample
{
    class Program92
    {
        public class Rectangle
        {
            public int Width = 0;
            public int Height = 0;

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public static Rectangle operator +(Rectangle rect1, Rectangle rect2) // must be static
            {
                Rectangle rectResult = new Rectangle(rect1.Width + rect2.Width, rect1.Height + rect2.Height);

                return rectResult;
            }

            public static Rectangle operator -(Rectangle rect1, Rectangle rect2)
            {
                Rectangle rectResult = new Rectangle(rect1.Width - rect2.Width, rect1.Height - rect2.Height);

                return rectResult;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(10, 10);
            Rectangle rect2 = new Rectangle(5, 10);

            Rectangle rectResult = rect1 + rect2;
            Rectangle rectResult2 = new Rectangle(rect1.Width + rect2.Width, rect1.Height + rect2.Height); // another way without the methods
            // rectResult2 = rect1 + rect2; // works because operator is changed to method for example "publc Rectangle Add(r1,r2) - it wont work
            Rectangle rectResult3 = rect1 - rect2;
            
            Console.WriteLine($"{rectResult.Width},{rectResult.Height}");
            Console.WriteLine($"{rectResult2.Width},{rectResult2.Height}");
            Console.WriteLine($"{rectResult3.Width},{rectResult3.Height}");
        }
    }
}