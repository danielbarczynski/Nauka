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
var unionEmployees = employees.Select(x => new { x.EmployeeId, x.EmployeeName }).Union(employees2.Select(x=> new { x.EmployeeId, x.EmployeeName })); // removes duplicates
var concatEmployees = employees.Concat(employees2); // it doesn't remove duplicates
var intersectEmployees = employees.Select(x => new { x.EmployeeId, x.EmployeeName }).Intersect(employees2.Select(x=> new { x.EmployeeId, x.EmployeeName }));
var exceptEmployees = employees.Select(x => new { x.EmployeeId, x.EmployeeName }).Except(employees2.Select(x=> new { x.EmployeeId, x.EmployeeName }));
var equalEmployees = employees.Select(x => new { x.EmployeeId, x.EmployeeName }).SequenceEqual(employees2.Select(x => new { x.EmployeeId, x.EmployeeName }));
var containsEmployees = employees.Contains(new Employee { EmployeeId = 5, EmployeeName = "Magda"}); // false
var containsEmployees2 = employees2.Select(x => new { x.EmployeeId, x.EmployeeName }).Contains(new { EmployeeId = 5, EmployeeName = "Magda" }); // true
var allEmployees = employees.All(x => x.EmployeeId < 10); // prediacte version if all have id < 10
var anyEmployees = employees.Any(); // if there is any element returns true
var any2Employees = employees.Any(x => x.EmployeeId < 1); // prediacte version if any have id < 10
var startsWithM = from e in employees
                  where e.EmployeeName.StartsWith("M")
                  select e;

foreach (var item in startsWithM)
{
    Console.WriteLine("M: " + item.EmployeeName);
}

foreach (var item in concatEmployees)
{
    Console.WriteLine(item.EmployeeName + " " + item.EmployeeId);
}
Console.WriteLine(containsEmployees);
Console.WriteLine(containsEmployees2);
Console.WriteLine(equalEmployees);
Console.WriteLine(allEmployees);
Console.WriteLine(anyEmployees);
Console.WriteLine(any2Employees);
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