// C# program to illustrate Func delegate
using System;

class GFG
{

    // Method
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

    //Action

    public static void Actionn(bool isBool)
    {
        bool isBooll = isBool;
        Console.WriteLine(isBooll);
    }

    // Main method
    static public void Main()
    {
        // Using Func delegate Here, Func delegate contains the one parameters of int type one result parameter of int type
        Func<string, int> myfun = method; // (string (in)) & return int (out)

        Console.WriteLine(myfun("h"));

        //Console.WriteLine(method("h"));

        Func<int, bool> boolFunc = IsTrue;
        Console.WriteLine(boolFunc(0));

        // można również używać z anonimowymi funkcjami

        Action<bool> actionFunc = Actionn;
        Actionn(false);
    }
}
