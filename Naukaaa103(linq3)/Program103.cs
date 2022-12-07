//--------------------------------------------------------------------------------
// OUTER JOIN
//--------------------------------------------------------------------------------

var employeeDepartments  = Department.departments
                                    .GroupJoin(Employee.employees, 
                                        d => d.Id,
                                        e => e.DepartmentId, 
                                        (d, e) => new 
                                        { 
                                            Department = d,
                                            Employee = e, 
                                        });

// tutaj pracownicy sa pogrupowani dla danego departamentu, hierarchicznie. dziala jak outer join, wyswietli departament, nawet jesli nie ma w nim pracownikow

var employeeDepartments2 = from d in Department.departments 
                           join e in Employee.employees
                           on d.Id equals e.DepartmentId into egroup
                           select new 
                           {
                                Department = d,
                                Employee = egroup,
                           };

//--------------------------------------------------------------------------------
// INNER JOIN
//--------------------------------------------------------------------------------

var employeeDepartments3  = Department.departments
                                    .Join(Employee.employees, 
                                        d => d.Id,
                                        e => e.DepartmentId, 
                                        (d, e) => new 
                                        { 
                                            Department = d,
                                            Employee = e, 
                                        });

// tutaj pracownicy maja dodatkowa kolumne z departamentem, jesli nie sa do zadnego przypisani, nie zostana wymienieni

var employeeDepartments4 = from d in Department.departments 
                           join e in Employee.employees
                           on d.Id equals e.DepartmentId 
                           select new 
                           {
                                Department = d,
                                Employee = e,
                           };
//--------------------------------------------------------------------------------
// LEFT JOIN
//--------------------------------------------------------------------------------

var employeeDepartments5  = Employee.employees
                                    .GroupJoin(Department.departments, 
                                        e => e.DepartmentId, 
                                        d => d.Id,
                                        (e, d) => new 
                                        { 
                                            e,
                                            d,
                                        })
                                    .SelectMany(x => x.d.DefaultIfEmpty(),
                                        (a, b) => new
                                        {
                                            Employee = a.e.Name,
                                            Department = b == null ? "No department" : b.DepartmentName
                                        });

var employeeDepartments6 = from e in Employee.employees 
                           join d in Department.departments
                           on e.DepartmentId equals d.Id into egroup
                           from d in egroup.DefaultIfEmpty() // because we started from employees
                           // without defaultifempty(), no matching record would be printed
                           select new 
                           {
                                Employee = e.Name,
                                Department = d == null ? "No department" : d.DepartmentName
                           };

//--------------------------------------------------------------------------------

foreach (var item in employeeDepartments)
{
    Console.WriteLine(item.Department.DepartmentName);
    
    foreach (var item2 in item.Employee)
    {
        Console.WriteLine(" " + item2.Name);
    }
}

Console.WriteLine("------------");

foreach (var item in employeeDepartments3)
{
    Console.WriteLine(item.Employee.Name + " " + item.Department.DepartmentName);
}

Console.WriteLine("------------");

foreach (var item in employeeDepartments5)
{
    Console.WriteLine(item.Employee + " " + item.Department);
}

//--------------------------------------------------------------------------------

public class Employee
{
    public int DepartmentId {get; set; }
    public string Name { get; set; }

    public static List<Employee> employees = new List<Employee>
{
    new Employee 
    {
        DepartmentId = 1,
        Name = "Adam"
    },
    new Employee 
    {
        DepartmentId = 1,
        Name = "Grażyna"
    },
    new Employee 
    {
        DepartmentId = 2,
        Name = "Rumcajs"
    },
    new Employee 
    {
        DepartmentId = 1,
        Name = "Tomek"
    },
    new Employee 
    {
        Name = "Ewa"
    },
};
}

//--------------------------------------------------------------------------------

public class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }

    public static List<Department> departments = new List<Department>
{
    new Department 
    {
        Id = 1,
        DepartmentName = "IT"
    },
    new Department 
    {
        Id = 2,
        DepartmentName = "HR"
    },
    new Department 
    {
        Id = 3,
        DepartmentName = "XYZ"
    }
};
}

