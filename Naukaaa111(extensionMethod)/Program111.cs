StringExtensions.Nothing();
var title = "Programowanie w C#";
title.Display();//Programowanie w C#

Object obj = new StringReader("Hi");
StringReader r = obj as StringReader;

public static class StringExtensions
{
    public static void Display(this string value)
    {
        Console.WriteLine(value);
    }
    
    static IEnumerable<T> Where2<T>(this IEnumerable<T> list, Func<T, bool> func)
    {
        return list;
    }
    
    public static void Nothing() => Console.WriteLine("nothing");
}

