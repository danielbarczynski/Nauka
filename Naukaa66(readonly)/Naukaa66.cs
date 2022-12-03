class User
{
    private readonly int Age; // nie wymaga podania wartosci
    private const string? UserName = "k"; // wymaga
    // Age = 30; // nie istnieje, mozna tylko zainicjalizowac w konstruktorze
    public User()
    {
        Age = 10;
        // UserName = "stefan";  // const sie nie da zainicjowac w konstruktorze
    }

}

class MainClass
{
    static void Main(string[] args)
    {
        User user = new User();
        // user.Age = 10; // error, readonly
        // user.UserName = "stefan"; // error, const
    }
}