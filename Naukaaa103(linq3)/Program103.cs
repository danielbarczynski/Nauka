var employeeDepartments = Employee.employees
                                    .GroupJoin(Department.departments, 
                                    e => e.DepartmentId, 
                                    d => d.Id,
                                    (e, d) => new 
                                    { 
                                        Employee = e, 
                                        Department = d
                                    });

foreach (var item in employeeDepartments)
{
    Console.WriteLine(item.Employee.Name);
    
    foreach (var item2 in item.Department)
    {
        Console.WriteLine(item2.Name);
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

