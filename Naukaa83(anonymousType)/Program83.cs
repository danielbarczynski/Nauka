dynamic student = new { Id = 1, FirstName = "James", LastName = "Bond" }; // doesn't work with object keyword
Console.WriteLine($"{student.Id} {student.LastName} {student.FirstName}");

//student.Id = 2; //Error: cannot change value
//student.FirstName = "Steve"; //Error: cannot change value

//An anonymous type's property can include another anonymous type.
var student2 = new
{
    Id = 1,
    FirstName = "James",
    LastName = "Bond",
    Address = new { Id = 1, City = "London", Country = "UK" }
};

Console.WriteLine(student2.Address.City + "\n");

// you can create array of anonymous types also
var students3 = new[] {
    new { Id = 1, FirstName = "James", LastName = "Bond" },
    new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
    new { Id = 3, FirstName = "Bill", LastName = "Gates" }
};

foreach (var item in students3)
{
    Console.WriteLine(item.FirstName);
}