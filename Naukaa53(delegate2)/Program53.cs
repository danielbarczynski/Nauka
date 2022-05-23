using System;
using System.Collections.Generic;

namespace Naukaa53_delegate2_
{
    delegate bool IsPromotable(Employee emp); //#1 parametr musi byc, tak jak jest w metodzie, by dzialalo utworzenie instancji

    internal class Program53
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Id = 1, Name = "Mary", Salary = 3000, Experience = 1 });
            list.Add(new Employee() { Id = 2, Name = "James", Salary = 7000, Experience = 5 });
            list.Add(new Employee() { Id = 3, Name = "John", Salary = 13000, Experience = 15 });
            list.Add(new Employee() { Id = 4, Name = "Mika", Salary = 5000, Experience = 4 });

            //Employee.PromoteEmployee(list);

            IsPromotable isPromotable = new IsPromotable(Promote); // dziala dopiero po uzupelnieniu delegacji(#1), poniewaz Promote bierze arugemnt emp
            Employee.PromoteEmployee(list, isPromotable); // lub z lambdą (list, emp => emp.Experience >= 5) nie trzeba wtedy metody Promote
        }

        public static bool Promote(Employee emp) // zawarte w delegacji
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            if (emp.Salary <= 4000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public static void PromoteEmployee(List<Employee> list, IsPromotable isPromotable) // delegacja z metodą bool, przekazana do nowej metody
        {
            foreach (Employee emp in list) // uzycie list
            {
                if (isPromotable(emp)) // uzycie isPromotable, juz bez hardkodowania
                {
                    Console.WriteLine($"Employee promoted {emp.Name}");
                }
            }
        }

        //public static void PromoteEmployee(List<Employee> list)
        //{
        //    foreach (Employee emp in list)
        //    {
        //        if (emp.Experience >= 5) // pętla if w pętli forach. Jest to hardkodowanie
        //        {
        //            Console.WriteLine($"Employee promoted {emp.Name}");
        //        }
        //    }
        //}
    }
}
