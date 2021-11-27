using System;

namespace Naukaa39_virtual_
{
    class Program39
    {
        static void Main(string[] args)
        {

            Chef chef1 = new();
            ItalianChef chef2 = new();

            chef1.SpecialDish();
            chef2.SpecialDish();
            chef2.CasualDish();

        }
    }

     class Chef
    {
        public void CasualDish()
        {
            Console.WriteLine("chef making chicken");
        }
        public virtual void SpecialDish() // virtual można nadpisywac przez override tak jak abstract, w takich sytuacjach dziedziczenia przydatne
        {
            Console.WriteLine("chef making risotto");
        }
    }

     class ItalianChef : Chef
    {
        public override void SpecialDish()
        {
            Console.WriteLine("chef making spaghetti");
        }
    }

}
