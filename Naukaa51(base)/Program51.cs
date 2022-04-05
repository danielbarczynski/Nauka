using System;

namespace Naukaa51_base_
{
    internal class Program51
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub(); // drukuje sie base bez arg, prawdopodobnie przez konstuktor, ktory dziedziczymy. Powolujemy klase, ktora dziedziczy, uruchamiamy w niej
            //konstruktor, wiec ona uruchamia takze konstruktor klasy po ktorej dziedziczy

            Console.WriteLine("---------------");

            Sub subb = new Sub("adam"); // drukuje sie rowniez base bez arg, dopiero po dodaniu base drukuje sie base z argumentem
            Sub subbb = new Sub(18);
        }

    }

    class Basee
    {
        public Basee() // gdyby tego nie bylo, public Sub() nie moglby byc uruchomiony, bo nie ma (string name) po Basee
        {
            Console.WriteLine("base bez argumentow");
        }

        public Basee(string name)
        {
            Console.WriteLine($"base z argumentem {name}");
        }
    }

    class Sub : Basee
    {
        public Sub()  //base() jest domyślnie, nie trzeba tu pisać
        {
            //Console.WriteLine("sub bez argumentow");
            // odpali sie to co jest w base(), nie musze tu nic pisac
        }

        public Sub(string name) : base(name) // wowczas juz nie wywoluje zwyklego konstruktora z base klasy, tylko ten wskazany z nejmem. 
        {// bez base(name) bylby blad, bo klasa dziedziczy, takze przy dziedziczeniu moze byc problem czesto konstuktorami jak nie dziedzicza rowniez
            Console.WriteLine("hi");
            //Console.WriteLine($"sub z argumentem {name}");
            // odpali sie to co jest w base(name), nie musze tu nic pisac
        }

        public Sub(int age) // base tego nie ma, wiec bez problemu
        {
            Console.WriteLine(age);
        }
    }
}
