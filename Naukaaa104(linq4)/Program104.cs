using System.Linq;

string[] countries = { "UK", "USA", "Poland", "Poland", "usa"};
Employee[] employees = { new Employee {EmployeeName = "Adam"}, new Employee {EmployeeName = "Marek"}, new Employee {EmployeeName = "Marek"}, new Employee {EmployeeName = "Magda"}};

var distinctCountry = countries.Distinct(); // no case sensitive
var distinctCountry2 = countries.Distinct(StringComparer.OrdinalIgnoreCase); // one way
var distinctEmployees = employees.Select(x => new { x.EmployeeName }).Distinct(); // third way


foreach (var item in distinctEmployees)
{
    Console.WriteLine(item.EmployeeName);
}

class Employee 
{
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