using System;
using System.Collections.Generic;

namespace Naukaa13_getSet_
{
    class Program13
    {
        static void Main(string[] args)
        {
            int i = 0;
            var student1 = new Student();
            var student2 = new Student();
         
            student1.Name = "Alex"; //set 
            student1.Age = 22;
            student2.Iq = 102; 

            student2.Name = "Marry"; //set 
            student2.Iq = -50;

            List<Student> list = new List<Student>();

            list.Add(student1);
            list.Add(student2);

            foreach (Student student in list)
            {
                Console.WriteLine($"Dane studenta {++i} id: {student.Id + i} imie: {student.Name} wiek: {student.Age} iq: {student.Iq} adress: {student.Adress} {student.Adress2}"); //get
            }
        }
    } 
}