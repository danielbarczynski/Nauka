class IntroToLINQ
{
    static void Main()
    {
        // The Three Parts of a LINQ Query:
        // 1. Data source.
        int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery = //Notacja standardowych zapytań:
            from num in numbers
            where num % 2 == 0
            select num;

        IEnumerable<int> numQuery4 = // to samo, tyle ze jasne typ zamiast var, ktory jest tym samym
            from num in numbers select num;

        var numQuery2 = numbers.Where(num => num % 2 == 0); // notacja z lambdą
        var numQuery3 = numbers.Select(num => num).Where(num => num % 2 == 0);
        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
        }

        Console.WriteLine();

        foreach (int num in numQuery2)
        {
            Console.Write("{0,1} ", num);
        }

        Console.WriteLine();


        //------------------------------------------------------------------------------


        int[] kolekcjaLiczb = new[] { 1, 4, 6, 5, 3, 2, 8, 9, 0 };

        //tworzymy zapytanie w którym z naszej kolekcji pobieramy wszystkie elementy
        // i wrzucamy do kolejnej kolekcji

        var querry1 = kolekcjaLiczb.Select(n => n).ToArray();
        var query2 = kolekcjaLiczb.Select(n => n).ToArray().OrderBy(b => b); // sortowanie z linq
        var query3 = kolekcjaLiczb.Select(n => n).ToArray().OrderByDescending(c => c);

        foreach (var item in querry1)
        {
            Console.Write(item + " ");
        }

        //lambda:

        //var querry = kolekcja.Select(n=>n).Where(s=>s <= 4).ToArray();

        // normalne:

        //from n in numbers
        //where n <= 4
        //select n

        // bardziej zaawansowany przykład

        //var queryCar =
        //NaszePojazdy.Select(n => n)
        //.Where(n => n.RodzajPojazdu == Rodzaj.Osobowy)
        //.Where(n => n.Kolor == "Czarny")
        //.Where(n => n.Cena <= 100)
        //.ToList();

        // z asp: (+ iqueryable)

        [HttpGet]
        public async Task<IActionresult> List(string name)
        {
            IQueryable<ProductEntity> productsQuery = _dbContext.Products;
            if (!string.IsNullOrEmpty(name))
            {
                productsQuery = productsQuery.Where(x => x.Name.Contains(name));
            }
            var products = await productsQuery.ToListAsync(); // uproszczenie
            return View(products);
        }

    }
}
