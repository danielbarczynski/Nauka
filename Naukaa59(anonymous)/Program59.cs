namespace Naukaa59_anonymousLambda_
{
    class Program59
    {
        // Anonymous methods are declared with the creation of the delegate instance, with a delegate keyword.For example:

        delegate void NumberChanger(int n);
        static void Main(string[] args)
        {
            NumberChanger nc = delegate (int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
            };

            // or
            nc = (x) => Console.WriteLine(x);
            
            nc(5);

            //-------------------------------------------------------------------------

            // PREDICATE

            List<Employe> list2 = new List<Employe>();
            list2.Add(new Employe()
            {
                Id = 1,
                Name = "Olaf"
            });

            Predicate<Employe> predicate = new Predicate<Employe>(FindEmployee); // delegate (definition)! points to the method (FindEmployee)
            Employe employe = list2.Find(employe => FindEmployee(employe));
            Console.WriteLine($"{employe.Id} {employe.Name}");

            // FUNCKJA ANONIMOWA

            List<Employee> list = new List<Employee>()
            {
                new Employee() { Id = 1, Age = 50, Name = "Basil" },
                new Employee() { Id = 2, Age = 30, Name = "Agata" },
                new Employee() { Id = 3, Age = 40, Name = "Bartlomelo"}
            };
            Console.WriteLine("----------------");
            Employee employee =  // bez stwarzania metody delegacji, funkcja anonimowa
            list.Find(delegate (Employee e) // delegate = Predicate // Predicate<T> (T obj) -- definition // nie wskazujemy na żadną utworzona przez nas metode
            {
                return e.Id == 2;
            });
            Console.WriteLine($"{employee.Id} {employee.Name}");

            // LAMBDA =>

            List<Employeee> list3 = new List<Employeee>()
            {
                new Employeee() { Id = 1, Age = 50, Name = "Basil" },
                new Employeee() { Id = 2, Age = 30, Name = "Agata" },
                new Employeee() { Id = 3, Age = 40, Name = "Bartlomelo"}
            };

            Employeee employeee =
            list3.Find(e => e.Id == 3); // domyślnie traktuje e jako Employee z listy i domyślnie zwraca bool == 3

            int count =
            list3.Count(e => e.Name.StartsWith("B")); // anoother linq expression with lambda

            Console.WriteLine($"{employeee.Id} {employeee.Name}");
            Console.WriteLine("count = " + count);
        }
        public static bool FindEmployee(Employe employe) // bool ponieważ Predicate jest delegacją typu bool
        {
            return employe.Id == 1;
        }
    }

    class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Employeee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}