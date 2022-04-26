using System;

namespace Naukaa58_outRef_
{
    internal class Program58
    {
        static void Main(string[] args)
        {
            int outside = 20;

            Nothing(outside); // mozna poodac zmienna i wartosc
            Nothing(50);

            Console.WriteLine();

            Reff(ref outside); // mozna podac jakas zmienna z zewnatrz, ale nie mozna podac wartosci (przekazanie referencji)
            //Reff(ref 20); // nie działa

            Console.WriteLine();

            Outt(out outside);// mozna podac jakas zmienna z zewnatrz, ale nie mozna podac wartosci (przekazanie referencji)
            // zmienna za to w ogóle nie zostanie uwzględniona, czyli takie bezpieczne odpalenie funckji z konstuktorem

            var student = new Student
            {
                Name = "Susan",
                Enrolled = false
            };

            Enroll(student);


        }
        public static void Nothing(int inside) // int outside wazny i liczony
        {
            Console.WriteLine("Nothing:");
            inside = inside + 10;
            Console.WriteLine(inside);
        }

        public static void Reff(ref int inside) // int outside wazny i liczony
        {
            Console.WriteLine("Ref:");
            inside = inside + 10;
            Console.WriteLine(inside);
        }

        public static void Outt(out int inside) // int outside uniewazniony
        {
            Console.WriteLine("Out:");
            inside = 10; // musimy ustalic w funkcji dana zmienna przy out
            inside = inside + 10;
            Console.WriteLine(inside);
        }

        static void Enroll(in Student student)
        {
            // With in assigning a new object would throw an error
            // student = new Student();

            // We can still do this with reference types though
            student.Enrolled = true; // extension mthod
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}
