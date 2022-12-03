class Osoba
{
    public String imie { get; set; }
    public Osoba(string imie) => this.imie = imie;
    public void Info() => Console.WriteLine("imie: {0}", imie);

    //* Tym razem nadpisujemy referencję nową instancją klasy Osoba. Uzyskujemy pełną kontrolę zarówno nad wartością referencji jak i instancją klasy, na którą wskazuje. Po drodze gubimy referencję do jednej z instancji. Zostanie to wykryte przez Garbage Collector a obiekt zostanie usunięty ze sterty.
    public static void Zmien(ref Osoba o) // traktowane jak referencja, bez ref będzie Arek
    {
        o.imie = "Arek";         // zadziała, przy out wyjdzie błąd kompilacji
        o = new Osoba("Maciek"); // także dzaiała! gdyby zakomentowac, bedzie arek, ale jest ponowna inicjalizacja
    }

    //* Out i Ref pozwalaja nam inicjzliować obiekty (new osoba()) w srodku metody i bedzie to widoczne w mainie
    public static void Zmien2(out Osoba o)
    {
        // o.imie = "Arek"; // nie można, unassigned variable
        o = new Osoba("Maciek");
    }

    //* Istnieje prosta zasada jaką trzeba zapamiętać, przesyłając typy referencyjne do funkcji poprzez wartość. Wewnątrz funkcji możemy zmienić stan obiektu na jaki wskazuje przesłana referencja, jednak nie można tej referencji zmienić. 
    public static void Zmien3(Osoba o)
    {
        o.imie = "Arek"; // bedzie Arek
        o = new Osoba("Maciek"); // nie inizjalicuje nowej osoby w mainie
        Console.WriteLine("inside method3: " + o.imie);
    }

    //* Nie jesteśmy w stanie zmienić wartości referencji, ponieważ tak samo jak w przypadku przesyłania typów wartościowych, zmiany nie będą widoczne poza ciałem funkcji.

    // Tworzymy instancję klasy Osoba i wypełniamy ją danymi. Przekazujemy referencję do obiektu do funkcji poprzez wartość. Do funkcji powędrowała kopia referencji, ponieważ jest to charakterystyczne dla przekazywania przez wartość. Mimo, że przesłaliśmy kopię referencji, jej wartość wskazuje na stercie na oryginalny obszar pamięci zawierający instancję klasy Osoba.

    // Dlatego przypisanie nowego imienia zadziała.Mimo że przesłaliśmy kopię referencji, operujemy na oryginalnym bloku pamięci na stercie.W przypadku gdybyśmy przesyłali typ wartościowy, sytuacja wyglądała by całkiem inaczej! Mielibyśmy wewnątrz funkcji kopię wartości, a więc jakiekolwiek operacje wewnątrz funkcji nie zmieniały by obiektu z poza niej.


}

class Naukaaa100
{
    static void Main()
    {
        Osoba osoba1 = new Osoba("Karol");
        Osoba.Zmien(ref osoba1); // bez ref będzie Arek
        osoba1.Info(); //imie: Maciek

        Osoba osoba2 = new Osoba("Karol");
        Osoba.Zmien2(out osoba2); // nie ma znaczenia kogo podalismy, w srodku metody inicjalizujemy osobe od nowa
        osoba2.Info();

        Osoba osoba3 = new Osoba("Karol");
        Osoba.Zmien3(osoba3);
        osoba3.Info();
    }
}