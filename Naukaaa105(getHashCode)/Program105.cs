PointC pointC = new PointC()
{
    X = 100, Y = 200
};

PointC pointC2 = new PointC()
{
    X = 100, Y = 200
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

public class PointC : IEquatable<PointC>
{
    public int X { get; set; }
    public int Y { get; set; }

    public bool Equals(PointC other)
    {
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
        // return base.GetHashCode();
        return X ^ Y;
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