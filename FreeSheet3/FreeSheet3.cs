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

object Cow
{
            public string name = "muu";
        }

public class Program
{
    static void Main(string[] args)
    {
        var title = "Programowanie w C#";
        title.Display();//Programowanie w C#

        //object vs var 

        object a = 10;
        object b = 20;
        object c = (int)a + (int)b; // obiektowi mozna dopisac jakakolwiek zmienna
        
        Console.WriteLine(c);
        var d = 5;
        var e = 6;
        var f = d + e; // przy var kompilator sam dopisuje (wyebiara) typ zmiennej
        Console.WriteLine(f);
    }
}
