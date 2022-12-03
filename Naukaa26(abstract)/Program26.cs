using System;

namespace Naukaa27
{


    public abstract class Ball
    {
        public abstract int returnInt(); // by działało, klasa MUSI być abstrakcyjna
        //public int returnInt(); // to nie zadziała, bo nie jest abstract
        public abstract double returnDouble(); // metody abstrakcyjne nie moga miec ciala
        public abstract void returnString(); // metody abstrakcyjne moga byc tylko w abstrakcyjnej klasie
        public abstract void returnString2<T>(T value);
        public static string Yo() // moze tez zawierac nieabstrakcyjne pola, jesli maja cialo
        {
            return "yo";
        }

        public Ball()
        {
            Console.WriteLine("Ball created");
        }
        public static char g = 'g';
        public static char gg() => 'g';
        public int z = 5;
        // public abstract int k = 3; // not valid on fields, only properties
        public abstract int MyProperty { get; set; } // = 3; won't work, //* virtual or abstract can't be private
        int MyProperty2 { get; set; } = 3;
        public Ball(params object[] list) // it can contain constructor
        {
            Console.WriteLine("wow");
        }
    }
    public class SuperBall : Ball // jeśli tutaj również nie chcemy implementacji metody, możemy oznaczyć również klasę jako abstract, tylko wtedy juz jej nie utworzymy
    {
        //* no need to override constructor, it runs anyways
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
        public void returnString3<T>(T[] value) { }
    }

    class Program26
    {
        static void Main()
        {
            int[] vals = { 1, 2 };
            SuperBall super = new SuperBall();
            Console.WriteLine(super.returnInt());
            Console.WriteLine(super.returnDouble());
            //super.returnString(); // wyrzuci exception
            super.returnString2(1);
            super.returnString2("something");
            super.returnString3(vals);
        }
    }
}
