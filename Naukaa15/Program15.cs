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
        }
    }

    interface IFigure // musi byc z duzej litery i "I", zeby rozeznac sie co jest class a co interface
    {
        int Corners { get; set; } // nie ma sensu by byly publiczne

        double GetArea();
    }

    class Square : IFigure
    {
        public int Corners { get; set; }
        public double Len { get; set; }

        public double GetArea()
        {
            return Math.Pow(Len, 2); // len do kwadratu
        }
    }

}
