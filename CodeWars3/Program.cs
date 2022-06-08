int num = 254342;
Console.WriteLine(Kata.DescendingOrder(num));

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        string text = num.ToString();
        var arr = text.ToArray();
        List<char> list = new List<char>();

        for (int i = 0; i < arr.Length; i++)
        {
            list.Add(arr[i]);           
        }

        var q1 = list.OrderByDescending(x => x);
        q1.ToList();
        string empty = " ";

        foreach (var x in q1)
        {
            empty += x;
        }

        return Convert.ToInt32(empty);
    }
}