int g = 5;
char w = 'j';
string z = "om";
double zz = 6.0 / 2.34;
float f = 6.0f / 2.34f;

Console.WriteLine(zz);
Console.WriteLine(f);

void ParamMethod(params dynamic[] things) // params must be the last and marked as one dimensional array, can be dynamic, object but not var
{
    foreach (var item in things)
    {
        Console.WriteLine(item);
    }
}

// var[] vars = new var[] { }; // not working
object[] objs = new object[] { 1, "tim", true};
dynamic[] dynamics = new dynamic[] { 1, "tim", true };
Square[] sq = new Square[] { };
Square Square = new Square();

foreach (var item in dynamics) // works also with objs
{
    Console.WriteLine(item);
}

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