// Używamy EF aby połączyć się z naszą bazą bazą danych: Adventure Works

AdventureWorks2012_DataEntities db = new AdventureWorks2012_DataEntities();

// Tworzymy nowy obiekt pobierając wskazane dane

IEnumerable<Employee> employeeIEnumberable = db.Employee.Where(a => a.JobTitle.StartsWith("P"));
employeeIEnumberable = employeeIEnumberable.Take<Employee>(5);

// Tworzymy nowy obiekt pobierając wskazane dane

IQueryable<Employee> employeeIQueryable = db.Employee.Where(a => a.JobTitle.StartsWith("P"));
employeeIQueryable = employeeIQueryable.Take<Employee>(5);



//Wykonanie pierwszego zapytania do bazy danych jest niewydajne. W pierwszej kolejności zostanie wykonane zapytanie zwracające wszystkie rekordy w których
//tytuł stanowiska pracy zaczyna się od literki "P". Kolejnym krokiem będzie pobranie 5 zwróconych rekordów. W przypadku naszej tabeli to nie jest problem.
//Wyobrażmy sobie, że mamy kilkaset tysięcy rekordów i wykonujemy takie zapytanie…

//Zapytanie takie w języku SQL wygląda w poniższy sposób:

select * from HumanResources.Employee where JobTitle like 'P%';

//Dopiero w następnym kroku zostaną zwrócone wymagane rekordy. W przypadku założonej przez nas liczby rzędu kilkuset tysięcy rekodów będzie to bardzo
//niewydajne zapytanie.

//Z kolei w przypadku interfejsu IQueryable proces ten został zoptymalizowany. Zapytanie wygląda w następujący sposób:

select top(5) * from HumanResources.Employee where JobTitle like 'P%';

//Z bazy danych zostaną odczytanie te wartości, których tak naprawdę potrzebujemy. Pokazuje to jak łatwo napisać kod, który w znaczący sposób wpłynie
//na spadek wydajności naszej aplikacji.


//The main difference, from a user's perspective, is that, when you use IQueryable<T> (with a provider that supports things correctly), you can save a lot
//of resources. For example, if you're working against a remote database, with many ORM systems, you have the option of fetching data from a table
//in two ways, one which returns IEnumerable<T>, and one which returns an IQueryable<T>. Say, for example, you have a Products table, and you want to get
//all of the products whose cost is >$25.

//If you do:

IEnumerable<Product> products = myORM.GetProducts();
var productsOver25 = products.Where(p => p.Cost >= 25.00);

//What happens here, is the database loads all of the products, and passes them across the wire to your program. Your program then filters the data.
//In essence, the database does a SELECT * FROM Products, and returns EVERY product to you.

//With the right IQueryable<T> provider, on the other hand, you can do:

 IQueryable<Product> products = myORM.GetQueryableProducts();
var productsOver25 = products.Where(p => p.Cost >= 25.00);

// The code looks the same, but the difference here is that the SQL executed will be SELECT * FROM Products WHERE Cost >= 25.

// From your POV as a developer, this looks the same. However, from a performance standpoint, you may only return 2 records across the network instead
// of 20,000....