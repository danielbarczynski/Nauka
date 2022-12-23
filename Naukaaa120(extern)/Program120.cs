using System.Runtime.InteropServices;

// using external code from another language or from windows library in this case
[DllImport("User32.dll")]
static extern int MessageBox(int h, string m, string c, int type);

var result = MessageBox(0, "trojan.exe", "virus alert", 0);
Console.WriteLine(result);