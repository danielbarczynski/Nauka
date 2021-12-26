using System;
using System.Collections.Generic;
using System.Linq;

namespace Naukaa55_lambda_
{

    delegate void Delegate(int x, int y);

    internal class Program55
    {
        static void Main(string[] args)
        {
            Delegate del = (x, y) => Console.WriteLine(x + y);
            del(4, 5);

            Console.WriteLine("---------------");

            //Delegate del2 = new Delegate(x, y);
            //Console.WriteLine(x + y);
            //del(4, 5);

            //----------------------------------------------------------------------

            var myNumbers = new List<int> { 0 , 1, 2, 3, 4, 5};

            // No lambda

            var numbersOver2 = new List<int>();

            foreach (int x in myNumbers)
            {
                if (x > 2) numbersOver2.Add(x);
            }

            // Lambda

            var myNumbers2 = new List<int> { 0, 1, 2, 3, 4, 5 };
            var numbersOver3 = myNumbers2.Where(n => n > 3);

            /*
            same as: (with use of LINQ)
            bool isOver3(int n) // n =>
            {
                return n > 3; // n > 3
            }
            */

            foreach(int x in numbersOver3)
            {
                Console.WriteLine(x);
            }


        }
    }
}
