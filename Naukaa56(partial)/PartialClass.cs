using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukaa56_partial_
{
    partial class PartialClass
    {
        string _name = "Julia";
        int _age = 14;

        public partial void Test() // metoda wywołana, gdy umieściłem jej drugą część ją w drugiej części partial klasy. Gdyby nie było pierwszej części wyskakiwałby błąd
        {
            Console.WriteLine("testu");
        }
    }
}
