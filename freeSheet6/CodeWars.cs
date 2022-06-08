Console.WriteLine(CustomMath.multiply(2, 3));
string a = "QWERTyUIOP";
string b = "QWERTUIOP";
string c = "1";
string d = "HELLO DONALD";

Console.WriteLine(a.IsUpperCase());
Console.WriteLine(b.IsUpperCase());
Console.WriteLine(c.IsUpperCase());
Console.WriteLine(d.IsUpperCase());


public class CustomMath
{
    public static int multiply(int a, int b)
    {
        return a * b;
    }
}

public static class StringExtensions
{
    public static bool IsUpperCase(this string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (!Char.IsUpper(text[i]) && text[i] != ' ')
            {
                return false;
            }
        }
        return true;
    }

}
