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

            Console.WriteLine("-------");

            string txt = animals.Dequeue(); //removing first animal cat and saving to string
            animals.Dequeue(); // removing another one in the line, dog
            Console.WriteLine("The next element in line: {0}", animals.Peek()); // peek of queue

            foreach (string s in animals)
                Console.WriteLine(s);

        }
    }
}
