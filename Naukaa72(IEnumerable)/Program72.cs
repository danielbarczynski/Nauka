public class Program72
{
    public static void Main()
    {
        IEnumerable<string> enumerable = new string[] { "A", "B", "C" }; // przypisanie tablicy do interfejsu ienumerable. na liscie tez by dzialalo, bo implementuje ienumerable
        List<string> list = new List<string> { "A", "B", "C" };
        int[] arr = { 1, 2, 3 };

        // or IEnumerable<TopicModel> 
        // Z użyciem foreach dostępnego w IEnumerable:
        foreach (var s in arr) // or var item... in Enumerable!!!
            Console.WriteLine(s);
 
        // enumerable.Add() // doesn't work, still an array

        // Z użyciem Enumeratora:
        IEnumerator<string> enumerator = enumerable.GetEnumerator();
        int[] newArr = new int[5];
        newArr.GetEnumerator(); 
        list.GetEnumerator().MoveNext();

        while (enumerator.MoveNext())
        {
            string s = enumerator.Current;
            Console.WriteLine(s);
        }

        char[] charArr = new char[3] { 'g', 'h', 'j' };
        var charrArr2 = charArr.GetEnumerator();

        while (charrArr2.MoveNext())
        {
            Console.WriteLine(charrArr2.Current);
        }

        // while (charArr.GetEnumerator().MoveNext()) // won't work
        //     Console.WriteLine(charArr.GetEnumerator().Current);
    }
}