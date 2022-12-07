using System;
using System.Linq;
using System.Collections.Generic;

string[] countries = { "UK", "USA", "Poland", "Poland", "usa"};

List<Employee> employees = new List<Employee>()
{ 
    new Employee {Name = "Adam", Id = 1}, 
    new Employee {Name = "Marek", Id = 2}, 
    new Employee {Name = "Magda", Id = 3}
};

List<Employee> employees2 = new List<Employee>()
{ 
    new Employee {Name = "Klaudia", Id = 3}, 
    new Employee {Name = "Marek", Id = 2}, 
    new Employee {Name = "Michał", Id = 4},
    new Employee {Name = "Magda", Id = 5}
};

var distinctCountry = countries.Distinct(); // no case sensitive
var distinctCountry2 = countries.Distinct(StringComparer.OrdinalIgnoreCase); // one way
var distinctEmployees = employees.Select(x => new { x.Name }).Distinct(); // third way

var unionEmployees = employees.Select(x => new { x.Id, x.Name })
    .Union(employees2.Select(x=> new { x.Id, x.Name })); // removes duplicates
var concatEmployees = employees.Concat(employees2); // it doesn't remove duplicates
var intersectEmployees = employees.Select(x => new { x.Id, x.Name })
    .Intersect(employees2.Select(x=> new { x.Id, x.Name }));
var exceptEmployees = employees.Select(x => new { x.Id, x.Name })
    .Except(employees2.Select(x=> new { x.Id, x.Name }));
var exceptEmployees2 = employees.Select(x => x.Id + x.Name) //* not working without select
    .Except(employees2.Select(x => x.Id + x.Name));

var equalEmployees = employees.Select(x => new { x.Id, x.Name })
    .SequenceEqual(employees2.Select(x => new { x.Id, x.Name }));
var containsEmployees = employees.Contains(new Employee { Id = 5, Name = "Magda"}); // false
var containsEmployees2 = employees2.Select(x => new { x.Id, x.Name })
    .Contains(new { Id = 5, Name = "Magda" }); // true

var allEmployees = employees.All(x => x.Id < 10); // prediacte version if all have id < 10
var anyEmployees = employees.Any(); // if there is any element returns true
var any2Employees = employees.Any(x => x.Id < 1); // prediacte version if any have id < 10
var startsWithM = from e in employees
                  where e.Name.StartsWith("M")
                  select e;

foreach (var item in startsWithM)
{
    Console.WriteLine("M: " + item.Name);
}

foreach (var item in exceptEmployees) // if exceptEmployees2 - not accessible name and id, just use item
{
    Console.WriteLine(item);
}

Console.WriteLine();
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

//-----------------------------------------------------------------------------------------
Console.WriteLine("------------------------");

// Creating a list of numbers
List<int> numbers = new List<int> { 1, 2, 3, 4 };

// Trying to append any value of the same type
numbers.Append(5);
// var nnumbers = numbers.Append(5); //* works now

// It doesn't work because the original list has not been changed
Console.WriteLine(string.Join(", ", numbers));

// It works now because we are using a changed copy of the original list
Console.WriteLine(string.Join(", ", numbers.Append(5)));

// If you prefer, you can create a new list explicitly
List<int> newNumbers = numbers.Append(5).ToList();

// And then write to the console output
Console.WriteLine(string.Join(", ", newNumbers));

// This code produces the following output:
//
// 1, 2, 3, 4
// 1, 2, 3, 4, 5
// 1, 2, 3, 4, 5

class Employee 
{
    public int Id { get; set; }
    public string Name { get; set; }

    // second way

    // public override bool Equals(object obj)
    // {
    //     return this.Name == ((Employee)obj).Name;
    // }

    // public override int GetHashCode()
    // {
    //     return this.Name.GetHashCode();
    // }
}