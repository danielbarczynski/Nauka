object a = 10;
object b = 20;
object c = (int)a + (int)b; // obiektowi mozna dopisac jakakolwiek zmienna

Console.WriteLine(c);
var d = 5;
var e = 6;
var f = d + e; // przy var kompilator sam dopisuje (wyebiara) typ zmiennej
Console.WriteLine(f);

dynamic g = "keyword"; // early bounded, brak intellisense
var h = "keywordd"; // late bounded
int len1 = g.Length;
int len2 = h.Length;

Console.WriteLine(len1);
Console.WriteLine(len2);