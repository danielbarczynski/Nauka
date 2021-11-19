using System;
using System.Collections.Generic;

namespace freeSheet
{
    class freeSheet
    {
        static void Main ()
        {
            string vars = "AdamKowalski,OlekKopijka";

            List<string> list = new();
            List<string[]> listt = new();
            listt.Add(vars.Split(','));

            foreach (var x in listt)
            {
                foreach (var xx in x)
                {
                    list.Add(xx);
                    Console.WriteLine(xx);
                }
            } 
           
            //foreach (var x in list)
            //{
            //    Console.WriteLine(x);
            //}

        }

    }

}

