using System;

namespace Naukaa14
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            h.Surname = "Cosby";
            h.HelloHuman();

            Console.WriteLine("----");

            Worker w = new Worker();
            w.Surname = "Gates";
            w.Salary = 4e9; // 4 000 000 000 - e 9 - dolicza 9 zer
            w.HelloHuman();
            w.PrintInfo();
            

        }
    }


    class Human
    {

        private int BirthYear { get; set; } = 1900;

        protected string Name { get; set; } = "Bill";

        public string Surname { get; set; } = "Anonymous";

        public void HelloHuman()
        {
            Console.WriteLine("I'm human!");
        }
    }

    class Worker : Human //kopiowanie rzeczy z klasy human
    {
        public double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("{0} {1} {2}", Name, Surname, Salary);
        }
    }
}