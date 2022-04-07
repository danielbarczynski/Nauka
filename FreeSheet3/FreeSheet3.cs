class Test
{
    public int n;
    public int i { get; set; }
    public void InitAnInt(out int p)
    {
        p = 100;
    }
    public Test()
    {
        InitAnInt(out n); // This is OK
                          //InitAnInt(out i); // ERROR: A property or indexer may not be passed 
                          // as an out or ref parameter
    }
}

public static class StringExtensions
{
    public static void Display(this string value)
    {
        Console.WriteLine(value);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var title = "Programowanie w C#";
        title.Display();//Programowanie w C#

        string xyz = "wombat";
        if(xyz is string)
        {
            Console.WriteLine("great!");
        }
    }
}
