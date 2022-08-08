var allSubjects = Student.GetStudents().SelectMany(x => x.Subjects);
// with just Select it wont work and print just System.Generic.List. it is not ienumerable then

foreach (var item in allSubjects)
{
    Console.WriteLine(item);
}

public class Student
{
    public string Name {get;set;}
    public string Gender {get;set;}
    public List<string> Subjects {get;set;}

    public static List<Student> GetStudents()
    {
        List<Student> students = new List<Student>
        {
            new Student
            {
                Name = "Adam",
                Gender = "male",
                Subjects = new List<string> {"C#", "Math"}
            },
            new Student
            {
                Name = "Beth",
                Gender = "female",
                Subjects = new List<string> {"English", "Economic"}
            },
        };

        return students;
    }
}

