string s = "ala ma kota";

Console.WriteLine(MyCLass.ReverseWordsInSentence(s));

static class MyCLass
{
    public static string ReverseWordsInSentence(string s)
    {
        string result = "";
        for (int i = s.Length; i <= 0; i--)
        {
            result += s[i];
        }
        return result;
    }
    public static string ReverseWordsInSentence2(string s)
    {
        List<string> list = new List<string>();

        string[] words = s.Split(' ');

        foreach (var word in words)
        {
            char[] charArr = word.ToCharArray();
            Array.Reverse(charArr);

            string reverse = new string(charArr);

            list.Add(reverse);
        }
        return string.Join(" ", list.ToArray());
    }
}