namespace Naukaa49_interface2_
{
    class Program49
    {
        static void Main(string[] args)
        {
            Dog.Skok();
        }


    }

    interface IForDogs
    {
        void Aport(int x, int y); // mozna tez tworzyc inty w konstruktorze hah
        void Skok(); // czyli metody w interfejsie moga byc puste (jakby abstract)
    }

    class Dog
    {
        public static void Skok() //cannot be overrided, it is not abstract
        {
            System.Console.WriteLine("Pies skacze");
        }
    }
}