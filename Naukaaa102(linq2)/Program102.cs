var allSubjects = Student.GetStudents().SelectMany(x => x.Subjects); // with just Select it wont work and print just System.Generic.List and we would have to create two foreach loop. it is not ienumerable then
var allSubjects2 = from student in Student.GetStudents()
from subject in student.Subjects select subject; // selectmany in sql query

int[] nums = {1, 2, 3, 4, 2, 6, 5};
var takeNums = nums.Skip(2).Take(2);
var takeNums2 = nums.SkipWhile(x => x < 3);

// top 3 numbers
var topNums = nums.OrderByDescending(x => x).Take(3);
var groupStudents = Student.GetStudents().GroupBy(x => x.Gender); //* grupuje czyli nie drukuje wszystkich wynikow (wylacza duplikaty)
var groupStudents2 = Student.GetStudents()
                    .GroupBy(x => new { x.Gender, x.Age, x.Salary }); // or just with anonymous type: select(x => new { Gender = x.key.gender}), to not write it later

foreach (var item in groupStudents2)
{
    Console.WriteLine(item.Key.Gender + " " + item.Key.Age + " " + item.Sum(x => x.Salary)); // IEnumerable<IGrouping> requires .Key
}

int[] nums2 = { 3, 9, 8, 2 };
int firstNum = nums2.FirstOrDefault(); // not throwing the exception when the array is empty
int elAt = nums2.ElementAtOrDefault(3);
//int singl = nums2.SingleOrDefault(); // only prints if there is a single value in the array
int[] nums3 = { };
IEnumerable<int> empt = nums3.DefaultIfEmpty(300);

foreach (var item in empt)
{
    Console.WriteLine(item);
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public List<string> Subjects { get; set; }
    public int Salary { get; set; }

    public static List<Student> GetStudents()
    {
        List<Student> students = new List<Student>
        {
            new Student
            {
                Name = "Adam",
                Age = 20,
                Gender = "male",
                Subjects = new List<string> { "C#", "Math" },
                Salary = 3000
            
            },
            new Student
            {
                Name = "Beth",
                Age = 30,
                Gender = "female",
                Subjects = new List<string> { "English", "Economic" },
                Salary = 2000
            },
            new Student
            {
                Name = "Maria",
                Age = 20,
                Gender = "female",
                Subjects = new List<string> { "English", "Math" },
                Salary = 1000
            },
                   new Student
            {
                Name = "Taffi",
                Age = 20,
                Gender = "female",
                Subjects = new List<string> { "English", "Math" },
                Salary = 5000
            },
                   new Student
            {
                Name = "Taffi",
                Age = 20,
                Gender = "female",
                Subjects = new List<string> { "English", "Math" },
                Salary = 5000
            }
        };

        return students;
    }
}

