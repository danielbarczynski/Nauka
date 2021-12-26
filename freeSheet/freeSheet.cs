﻿using System;
using System.Collections.Generic;

namespace Naukaa53_delegate2_
{

    delegate bool IsPromotable(Employee emp);

    internal class Program53
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Id = 1, Name = "Mary", Salary = 3000, Experience = 1 });
            list.Add(new Employee() { Id = 2, Name = "James", Salary = 7000, Experience = 5 });
            list.Add(new Employee() { Id = 3, Name = "John", Salary = 13000, Experience = 15 });
            list.Add(new Employee() { Id = 4, Name = "Mika", Salary = 5000, Experience = 4 });


            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(list, isPromotable);
        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
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

        public static void whatever()
        {
            Console.WriteLine("w");
        }
        public static void PromoteEmployee(List<Employee> list, IsPromotable isPromotable)
        {
            foreach (Employee emp in list)
            {
                if (isPromotable(emp)) // juz bez hardkodowania
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
