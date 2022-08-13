using System;
using System.Linq;
using System.Collections.Generic;

string[] countries = { "UK", "USA", "Poland", "Poland", "usa"};

List<Employee> employees = new List<Employee>()
{ 
    new Employee {EmployeeName = "Adam", EmployeeId = 1}, 
    new Employee {EmployeeName = "Marek", EmployeeId = 2}, 
    new Employee {EmployeeName = "Magda", EmployeeId = 3}
};

List<Employee> employees2 = new List<Employee>()
{ 
    new Employee {EmployeeName = "Klaudia", EmployeeId = 3}, 
    new Employee {EmployeeName = "Marek", EmployeeId = 2}, 
    new Employee {EmployeeName = "Michał", EmployeeId = 4},
    new Employee {EmployeeName = "Magda", EmployeeId = 5}
};

var distinctCountry = countries.Distinct(); // no case sensitive
var distinctCountry2 = countries.Distinct(StringComparer.OrdinalIgnoreCase); // one way
var distinctEmployees = employees.Select(x => new { x.EmployeeName }).Distinct(); // third way
var unionEmployees = employees.Select(x => new { x.EmployeeId, x.EmployeeName }).Union(employees2.Select(x=> new { x.EmployeeId, x.EmployeeName }));
var intersectEmployees = employees.Select(x => new { x.EmployeeId, x.EmployeeName }).Intersect(employees2.Select(x=> new { x.EmployeeId, x.EmployeeName }));
var exceptEmployees = employees.Select(x => new { x.EmployeeId, x.EmployeeName }).Except(employees2.Select(x=> new { x.EmployeeId, x.EmployeeName }));

foreach (var item in exceptEmployees)
{
    Console.WriteLine(item.EmployeeName + " " + item.EmployeeId);
}

Console.WriteLine("------------------------");

//-----------------------------------------------------------------------------------------

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    Console.WriteLine(i);
}

Console.WriteLine("------------------------");

IEnumerable<int> evenNums = Enumerable.Range(0, 10).Where(x=> x % 2 == 0);

foreach (var item in evenNums)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------");

static IEnumerable<int> GetIEnumerable()
{
    return null;
}

IEnumerable<int> emptyList = GetIEnumerable() ?? Enumerable.Empty<int>();

foreach (var item in emptyList)
{
    Console.WriteLine(item);
}

class Employee 
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }

    // second way

    // public override bool Equals(object obj)
    // {
    //     return this.EmployeeName == ((Employee)obj).EmployeeName;
    // }

    // public override int GetHashCode()
    // {
    //     return this.EmployeeName.GetHashCode();
    // }
}