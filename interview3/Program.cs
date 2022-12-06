var A = new[] { 5, 6, 12, 6, 5, 5, 22 };
Console.WriteLine(MyClass.Solve(A));

static class MyClass
{
    //public static int Solve(int[] Array)
    //{
    //    Array.Distinct
    //    return Array.GroupBy(x => x).Single(x => x.Count() == 1).Key;
    //}

    public static int Solve(int[] Array)
    {
        int n = 0;
        try
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] != Array[i + 1] && Array[i] != Array[i + 2] && Array[i] != Array[i + 3] && Array[i] != Array[i + 4])
                {
                    n++;
                }
            }
        }
        catch (Exception)
        {
            for (int i = 4; i < Array.Length; i++)
            {

                if (Array[i] != Array[i - 1] && Array[i] != Array[i - 2] && Array[i] != Array[i - 3] && Array[i] != Array[i - 4])
                {
                    n++;
                }
            }
        }
        return n;
    }

}