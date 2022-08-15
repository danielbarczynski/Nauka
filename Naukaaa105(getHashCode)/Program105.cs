using System.Collections.Generic;

PointC pointC = new PointC()
{
    X = 100, Y = 200
};

PointC pointC2 = new PointC()
{
    X = 100, Y = 300
};

PointS pointS = new PointS()
{
    X = 100, Y = 200
};

PointS pointS2 = new PointS()
{
    X = 100, Y = 200
};

PointR pointR = new PointR()
{
    X = 100, Y = 200
};

PointR pointR2 = new PointR()
{
    X = 100, Y = 200
};

Console.WriteLine(pointC == pointC2); // compares references, false. make it stay that way, to be able to compare reference, override equals only
// Console.WriteLine(pointS == pointS2); error
Console.WriteLine(pointR == pointR2); // compares values, true

Console.WriteLine("-------------------");

Console.WriteLine(pointC.Equals(pointC2)); // false, after overriding true
Console.WriteLine(pointS.Equals(pointS2)); // true, compares values
Console.WriteLine(pointR.Equals(pointR2)); // true, compares values

Console.WriteLine("-------------------");

Console.WriteLine(pointC.GetHashCode() + " " + pointC2.GetHashCode);

PointC pointC3 = new PointC()
{
    X = 100, Y = 300
};

Dictionary<PointC, string> dictionary = new Dictionary<PointC, string>();
dictionary.Add(pointC, "c1");
dictionary.Add(pointC2, "c2");

if (dictionary.ContainsKey(pointC3)) // with gethascode it is much faster to look through dictionary
{
    Console.WriteLine(dictionary[pointC3]);
}


public class PointC : IEquatable<PointC>
{
    public int X { get; init; }
    public int Y { get; init; }

    public bool Equals(PointC other)
    {
        Console.WriteLine("Calling Equals"); // equals is called as the final check
        return other != null && this.GetType() == other.GetType() && this.X == other.X && this.Y == other.Y; 
        //&& this != null is useless cuz instance of first object must be always set  
    }

    public override bool Equals(object obj) // now exceptions works if objects are different types for example
    {
        // return base.Equals(obj);
        return Equals(obj as PointC);
    }

    public override int GetHashCode()
    {
        Console.WriteLine("Calling GetHashCode");

        // return base.GetHashCode();
        // return X ^ Y; // xor | 1 & 1 = 0 | 0 & 0 = 0 | 1 & 0 = 1 | 0 & 1 = 1 |
        // so if x = 100, y = 200 and x = 200, y = 100, it will be the same hashcode
        return HashCode.Combine(X, Y); // best ay
    }
}
public struct PointS
{
    public int X { get; set; }
    public int Y { get; set; }
}
public record PointR
{
    public int X { get; set; }
    public int Y { get; set; }
}