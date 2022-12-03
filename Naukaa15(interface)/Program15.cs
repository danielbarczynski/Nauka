using System;

namespace Naukaa15
{
    class Program15
    {
        static void Main(string[] args)
        {
            Square s = new Square();
            s.Corners = 4;
            s.Len = 8.0;
            Console.WriteLine(s.GetArea());
            Console.WriteLine(IFigure.Hello()); 
        }
    }

    interface IFigure // musi byc z duzej litery i "I", zeby rozeznac sie co jest class a co interface
    {
        int Corners { get; set; } // nie ma sensu by byly publiczne
        abstract int Corners2 { get; set; } // moga byc abstrakcyjne

        double GetArea(); // static tylko jesli maja implementacje, inaczej to bez sensu

        static string Hello() // if there is implementation, no need for class to inherit this
        {
            return "hey";
        }
        int j { get; set; } // can have property
        // public int z = 5; // cannot contain fields!!!
        // public IFigure() // cannot contain constructor
        // {

        // }
    }

    class Square : IFigure
    {
        public int Corners { get; set; }
        public double Len { get; set; }
        public int j { get; set; }

        public double GetArea()
        {
            return Math.Pow(Len, 2); // len do kwadratu
        }
    }

}
