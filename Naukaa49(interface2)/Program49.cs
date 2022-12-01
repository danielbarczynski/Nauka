namespace Naukaa49_interface2_
{
    class Program49
    {
        static void Main(string[] args)
        {
            IForDogs.Skok();
            Dog.Skok();
            Console.WriteLine();
        }


    }

    interface IForDogs
    {
        void Aport(int x, int y); 
        static void Skok()
        {
            Console.WriteLine("pies interfejs skacze");
        } 
    }

    class Dog : IForDogs
    {
        public int Id { get; set; }
        public static void Skok() // always overriding interface method
        {
            System.Console.WriteLine("Pies skacze");
        }

        public void Aport(int x, int y)
        {
            throw new NotImplementedException();
        }

    }
    
    class ForDogs : Dog
    {
        Dog? Dog1 { get; set; } // get; set; dla obiektu klasy 
        

        Dog dog = new Dog();


    }
}