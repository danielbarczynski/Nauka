// C# program to illustrate Func delegate
using System;

class GFG
{

    // for func
    public static int method(string num)
    {
        return 5;
    }

    public static bool IsTrue(int n)
    {
        if (n == 0)
            return true;
        return false;
    }

    // for action

    public void Actionn(bool isBool)
    {
        bool isBooll = isBool;
        Console.WriteLine(isBooll);
    }

    static public void Main()
    {
        Func<string, int> myfun = method; // (string (in)) & return int (out)

        Console.WriteLine(myfun("h"));

        //Console.WriteLine(method("h"));

        Func<int, bool> boolFunc = IsTrue;
        Console.WriteLine(boolFunc(0));

        // można również używać z anonimowymi funkcjami

        Action<bool> actionFunc = new GFG().Actionn; // tylko jeden <T> argument, bo domyślnie jest void
        actionFunc(false); // nie musimy przypisywac do obiektu metody. jakbysmy np mieli kilka metod z tym samym typem, latwiej tak operowac
    }
}
