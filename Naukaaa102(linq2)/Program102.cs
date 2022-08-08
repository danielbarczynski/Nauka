var allSubjects = Student.GetStudents().SelectMany(x => x.Subjects);
// with just Select it wont work and print just System.Generic.List. and we would have to create two foreach loop. it is not ienumerable then

var allSubjects2 = from student in Student.GetStudents()
from subject in student.Subjects select subject; // selectmany in sql query

int[] nums = {1, 2, 3, 4, 2, 6, 5};
var takeNums = nums.Skip(2).Take(2);
var takeNums2 = nums.SkipWhile(x => x < 3);

// top 3 numbers

var topNums = nums.OrderByDescending(x => x).Take(3);

var groupStudents = Student.GetStudents().GroupBy(x => x.Gender); // grupuje czyli nie drukuje wszystkich wynikow (wylacza duplikaty)


foreach (var item in groupStudents)
{
    Console.WriteLine(item.Key);
}


public class Student
{
    public string Name {get; set;}
    public string Gender {get; set;}
    public List<string> Subjects {get; set;}

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
            new Student
            {
                Name = "Maria",
                Gender = "female",
                Subjects = new List<string> {"English", "Math"}
            },
        };

        return students;
    }
}

