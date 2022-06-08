// Is this string uppercase?

string test1 = "HEY DONALD";
Console.WriteLine(test1.IsUpperCase());

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

    public static bool IsUpperCase2(this string text)
    {
        return text == text.ToUpper();
    }

}

