using System;

namespace Naukaa57_abstract2_
{
    internal class Program57
    {
        static void Main(string[] args)
        {
            FullTimeEmployee f = new FullTimeEmployee{};
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Name = "Marcin",
                Surname = "Klęsk",
                AnnualSalary = 50000
            };

            fullTimeEmployee.FullName();
            Console.WriteLine(fullTimeEmployee.MonthlySalary());

            Console.WriteLine();

            ContractEmployee contractEmployee = new ContractEmployee
            {
                Name = "Miłosz",
                Surname = "Żaliński",
                PayForHour = 80,
                TotalHours = 500,
            };

            contractEmployee.FullName();
            Console.WriteLine(contractEmployee.MonthlySalary());

            // możemy to zepsuć tworząc BaseEmployee i przypisując mu dane do zmiennych
        }
    }
}
