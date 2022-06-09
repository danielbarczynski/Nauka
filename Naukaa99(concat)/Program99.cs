string s1 = "www";
string s2 = ".readit.";
string s3 = "pl";
int i1 = 99;
int[] array = { 1, 5, 9, 100 };

string result = string.Concat(s1, s2, s3, i1);
string result2 = string.Concat(array);
Console.WriteLine(result);
Console.WriteLine(result2);