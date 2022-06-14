class Osoba
{
    public String imie { get; set; }
    public Osoba(string imie) { this.imie = imie; }
    public void Info() { Console.WriteLine("imie: {0}", imie); }
}

class Naukaaa100
{
    static void Main(string[] args)
    {
        Osoba osoba1 = new Osoba("Karol");
        osoba1.Info(); // imie: Karol

        Zmien(ref osoba1); // bez ref będzie Arek
        osoba1.Info(); //imie: Maciek

        Console.ReadKey();
    }

    public static void Zmien(ref Osoba o) // bez ref będzie Arek
    {
        o.imie = "Arek";         // zadziała, przy out wyjdzie błąd kompilacji
        o = new Osoba("Maciek"); // także dzaiała!
    }
}