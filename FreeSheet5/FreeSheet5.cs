string cos = "hey and hey";
var tos = cos.TekstBezSpacji();
Console.WriteLine(tos);

List<string> list = new List<string>() { "milk", "egg", "cheese", "ham" };

var q1 = list.Where(x => x == "egg");
q1.ToList().ForEach(x => { Console.WriteLine(x); });

Console.WriteLine("enter numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

try
{
  
    Console.WriteLine(num1 / num2);
}
catch (Exception)
{
    num2 = 1;
    Console.WriteLine(num1 / num2);
}

static class MyClass
{
    public static string TekstBezSpacji(this string tekst)
    {
        string tekstNoSpaces = "";
        for (int i = 0; i < tekst.Length; i++)
        {       
            char c = tekst[i];
            if (c == ' ')
            {
                tekstNoSpaces = tekstNoSpaces + "";
            }
            else
            {
                tekstNoSpaces = tekstNoSpaces + c;
            }         
        }
        return tekstNoSpaces;
    }
}

