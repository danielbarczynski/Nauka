using System;

namespace Naukaa27
{


    public abstract class Ball
    {
        public abstract int returnInt(); // by działało, klasa MUSI być abstrakcyjna
        //public int returnInt(); // to nie zadziała, bo nie jest abstract
        public abstract double returnDouble(); // metody abstrakcyjne nie moga miec ciala
        public abstract void returnString();
        public abstract void returnString2<T>(T value);
        public static string Yo() // moze tez zawierac nieabstrakcyjne pola, jesli maja cialo
        {
            return "yo";
        }
        
        public Ball()
        {
            Console.WriteLine("Ball created");
        }

        public int z = 5;
        // public abstract int k = 3; // not valid on fields, only properties
        public abstract int MyProperty { get; set; } // = 3; won't work

        public Ball(params object[] list) // it can contain constructor
        {
            Console.WriteLine("wow");
        }
    }
    public class SuperBall : Ball // jeśli tutaj również nie chcemy implementacji metody, możemy oznaczyć również klasę jako abstract, tylko wtedy juz jej nie utworzymy
    {
        public override int MyProperty { get; set; } = 5;

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
