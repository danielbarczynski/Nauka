object a = 10; // obiektowi mozna dopisac jakakolwiek zmienna
object b = 20;
object c = (int)a + (int)b; // przy rzutowaniu trzeba okreslic typ by kompilator nie zwrocil blad

Console.WriteLine(c);
var d = 5; // var rowniez mozna jakkakolwiek zmienna, ale rowniez jakies dlgie typy np ienumerable<...> itd
var e = 6;
var f = d + e; // przy var kompilator sam dopisuje (wyebiara) typ zmiennej
Console.WriteLine(f);

dynamic g = "keyword"; // early bounded, brak intellisense
var h = "keywordd"; // late bounded
int len1 = g.Length;
int len2 = h.Length;

Console.WriteLine(len1);
Console.WriteLine(len2);