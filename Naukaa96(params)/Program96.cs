int g = 5;
char w = 'j';
string z = "om";

void ParamMethod(params object[] things ) // params must be the last and marked as one dimensional array
{
    foreach (var item in things)
    {
        Console.WriteLine(item);
    }
}
Square Square = new Square();
ParamMethod();
ParamMethod(g, w, z, "many", Square.x);

class Square
{
    public byte x { get; set; } = 255 - 2;
    public Square()
    {
        Console.WriteLine("square");
    }
}