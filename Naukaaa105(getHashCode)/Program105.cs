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

Console.WriteLine(pointC == pointC2); // compare references
// Console.WriteLine(pointS == pointS2); error
Console.WriteLine(pointR == pointR2); // compare values

public class PointC
{
    public int X { get; set; }
    public int Y { get; set; }
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