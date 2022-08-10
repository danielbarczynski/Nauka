var employeeDepartments  = Department.departments
                                    .GroupJoin(Employee.employees, 
                                    d => d.Id,
                                    e => e.DepartmentId, 
                                    (d, e) => new 
                                    { 
                                        Department = d,
                                        Employee = e, 
                                    });

var employeeDepartments2 = from d in Department.departments 
                           join e in Employee.employees
                           on d.Id equals e.DepartmentId into egroup
                           select new 
                           {
                                Department = d,
                                Employee = egroup,
                           };


foreach (var item in employeeDepartments2)
{
    Console.WriteLine(item.Department.Name);
    
    foreach (var item2 in item.Employee)
    {
        Console.WriteLine(" " + item2.Name);
    }
}


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
        DepartmentId = 2,
        Name = "Ewa"
    },
};
}

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }

    public static List<Department> departments = new List<Department>
{
    new Department 
    {
        Id = 1,
        Name = "IT"
    },
    new Department 
    {
        Id = 2,
        Name = "HR"
    }
};
}

