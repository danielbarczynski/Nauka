var list = new List<int>();
object list2 = new List<int>();
dynamic list3 = new List<int>();

object a = 10; // obiektowi mozna dopisac jakakolwiek zmienna
object b = 20;
b = "no";
object bb = "lo";
object c = (int)a + (string)b + (string)bb; // przy rzutowaniu trzeba okreslic typ by kompilator nie zwrocil bledu (cannot operand with + on type object)
object dd = bb;
Console.WriteLine(c);
Console.WriteLine(dd);

var d = 5; 
var e = 6;
// e = "oh"; // throws error
// var p = e.ToString();
// p = "ph";
var ee = "no";
var f = d + e + ee; // przy var kompilator sam dopisuje (wybiera) typ zmiennej
Console.WriteLine(f);

dynamic z = 3;
dynamic z2 = 5;
z2 = "yo";
dynamic zz = "o";
dynamic zzz = z + z2 + zz;
Console.WriteLine(zzz);

dynamic g = "keyword"; // early bounded, brak intellisense
var h = "keywordd"; // late bounded
int len1 = g.Length;
int len2 = h.Length;

Console.WriteLine(len1);
Console.WriteLine(len2);