using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukaa56_partial_
{
    partial class PartialClass
    {
        public void Speaking()
        {
            Console.WriteLine($"Hello {_name} who is {_age} yo"); // can access private variables due to Partial Class
        }

        public partial void Test(); // gdyby coś zawierała, wyszedłby błąd

        // public partial void Test() // METODA PARTIAL MUSI MIEC DWIE CZESCI (w tym przypadku druga czesc w drugiej partial klasie)
        // {
        //    Console.WriteLine("testu");
        // }

        public void WykonanieTestu()
        {
            Console.WriteLine("wykonywanie");
            Test();
             // uruchamia pustą metodę partial, lecz kompilator ją pomija, tak jakby jej nie było.
        }
    }
}
