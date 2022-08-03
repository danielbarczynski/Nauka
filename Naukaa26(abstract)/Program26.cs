using System;

namespace Naukaa27
{


    public abstract class Ball
    {
        public abstract int returnInt(); // by działało, klasa MUSI być abstrakcyjna
        //public int returnInt(); // to nie zadziała, bo nie jest abstract
        public abstract double returnDouble();
        public abstract void returnString();
        public abstract void returnString2<T>(T value);
        public static string Yo() // moze tez zawierac nieabstrakcyjne pola
        {
            return "yo";
        }

        public int z = 5;

        public Ball(params object[] list) // it can contain constructor
        {
            Console.WriteLine("wow");
        }
    }
    public class SuperBall : Ball // jeśli tutaj również nie chcemy implementacji metody, możemy oznaczyć również klasę jako abstract, tylko wtedy juz jej nie utworzymy
    {
        public override int returnInt()
        {
            return 5;
        }
        public override double returnDouble()
        {
            return 2.5;
        }
        public override void returnString()
        {
            throw new NotImplementedException();
        }

        public override void returnString2<T>(T value)
        {
            Console.WriteLine(value);
        }
    }

    abstract class Program26 
    {

        static void Main(string[] args)
        {
            SuperBall super = new SuperBall();
            Console.WriteLine(super.returnInt());
            Console.WriteLine(super.returnDouble());
            //super.returnString(); // wyrzuci exception
            super.returnString2(1);
            super.returnString2("something");
        }
    }
}
