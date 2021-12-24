namespace Naukaa47_enum_
{

    class Program47
    {
        public enum Gender
        {
            Unknown,
            Male,
            Female
        };

        class Customer
        {
            public string Name { get; set; }
            public Gender Gender { get; set; } // najwazniejsze
        }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "there is a problem";
            }
        }

        static void Main(string[] args)
        {
            Customer[] customers = new Customer[2];

            customers[0] = new Customer
            {
                Name = "Pablo",
                Gender = Gender.Male
            };

            customers[1] = new Customer
            {
                Name = "Lucy",
                Gender = Gender.Female
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Name is {customer.Name} and gender is {GetGender(customer.Gender)}");
            }
        }
    }
}