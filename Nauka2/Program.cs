using System;

namespace Nauka2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("linia\nnowa linia");

            bool a = true;
            bool b = false;
            bool c = !a; // c = false

            int x = 35;
            int y = -2;

            bool w = x > y;

            if (w)
                Console.WriteLine("x rządzi\n");
            else
                Console.WriteLine("y rządzi\n");

            //------------------------------------------------------------------------------------------

            Random rnd = new Random();
            int z;

            //  c = c * 5 ==== c *= 5 lub c++ haha


            // (start, end, incrementation)

            for (int i = 1; i < 5000 ; i++) // i++ -> i = i + 1
            {
                z = rnd.Next(0, 2000);
                Console.WriteLine(i + " bicie: " + z);

                if (z == 1)
                {
                    Console.WriteLine("LEGA");
                    break;
                }
            }
            
        }
    }
}
