var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
Console.WriteLine($"{student.Id} {student.LastName} {student.FirstName}");

student.Id = 2;//Error: cannot chage value
student.FirstName = "Steve";//Error: cannot chage value