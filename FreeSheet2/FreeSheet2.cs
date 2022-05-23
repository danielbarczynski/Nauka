
namespace FreeSheet2
{
    public class FreeSheet2
    {
        public class Horse
        {
            protected internal string Name = "Stefan";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nothing");


            // casting

            int d = 5;
            double f = 3.3;
            f = d;
            double z = 3.5;
            z = 6;

            
            Console.WriteLine(z.GetType());
            Console.WriteLine(z);

        }
    }
}