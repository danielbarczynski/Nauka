using System;
using System.Collections.Generic; // needed for List

namespace Naukaa16
{
    class Program16
    {
        static void Main(string[] args)
        {
            // List similar to array, but it can expand and reduce on need
            /* 
            List<int> list = new List<int>(); // just like Random = new Random();
            list.Add(9);
            list.Add(4);
            list.Add(18);
            list.Add(4);
            */

            // or

            List<int> list = new List<int>() { 9, 4, 18, 4 };
            
            foreach (int n in list) // foreach is just created for lists
                Console.WriteLine(n);

            Console.WriteLine("-------");
            // Insert and remove elements from the list

            list.Insert(1, 8); // put 8 on 2 position [1]
            list.RemoveAt(3); // 4th position
            list.Remove(4); // delete number 4 (only one number 4!)

            for (int i = 0; i < list.Count; i++) // not get length, count because it is collection that can be expanded or reduced
                Console.WriteLine(list[i]);
        }
    }
}
