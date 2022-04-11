public class Program72
{
    public static void Main()
    {
        IEnumerable<string> enumerable = new string[] { "A", "B", "C" };
 
        // Z użyciem foreach dostępnego w IEnumerable:
        foreach (string s in enumerable)
            Console.WriteLine(s);
 
        // Z użyciem Enumeratora:
        IEnumerator<string> enumerator = enumerable.GetEnumerator();
        while (enumerator.MoveNext())
        {
            string s = enumerator.Current;
            Console.WriteLine(s);
        }
    }
}