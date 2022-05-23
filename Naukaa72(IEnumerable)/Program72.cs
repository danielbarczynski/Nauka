public class Program72
{
    public static void Main()
    {
        IEnumerable<string> enumerable = new string[] { "A", "B", "C" }; // na liscie tez by dzialalo, bo implementuje ienumerable
     List<string> list = new List<string> { "A", "B", "C" };

        int[] arr = { 1, 2, 3 };
        // or IEnumerable<TopicModel> 
        // Z użyciem foreach dostępnego w IEnumerable:
        foreach (var s in arr) // or var item... in Enumerable!!!
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