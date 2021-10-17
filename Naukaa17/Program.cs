using System;
using System.Collections.Generic;

namespace Naukaa17
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> animals = new Queue<string>();
            animals.Enqueue("cat"); // enqueue mens add to queue
            animals.Enqueue("dog");
            animals.Enqueue("bird");
            animals.Enqueue("hamster");

            foreach (string s in animals)
                Console.WriteLine(s);

        }
    }
}
