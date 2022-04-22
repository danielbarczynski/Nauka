using System.Text;

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

    public static void Nothing() => Console.WriteLine("nothing");

}



public class Program
{
   
    static void Main(string[] args)
    {

        var title = "Programowanie w C#";
        title.Display();//Programowanie w C#
        Program program = new Program();
        string xyz = "wombat";
        if(xyz is string)
        {
            Console.WriteLine("great!");
        }
        Console.WriteLine(typeof(StreamReader));
        Console.WriteLine(sizeof(ulong));

        Object obj = new StringReader("Hi");
        StringReader r = obj as StringReader;

        double liczba = 3765.47;
        int i;
        // Konwersja typu doble na int - użycie operatora rzutowania;
        i = (int)liczba;
        // Rezultat wywołania takiego programu to: 3765
        Console.WriteLine(i);
        StringExtensions.Nothing();
    }
}
