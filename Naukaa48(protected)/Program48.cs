namespace Naukaa48_protected_
{
    class Program48 : Customer
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            SuperCustomer superCustomer = new SuperCustomer();

            //superCustomer.ID = 5; nie działa
            superCustomer.GetID();
            //Console.WriteLine(customer.ID); -- protected nie mozna ani edytowac (set), ani drukowac (get)
        }
    }

    public class Customer
    {
        protected int ID { get; set; }
    }

    public class SuperCustomer : Customer
    {
        public void GetID()
        {
            //Customer customer = new Customer();
            SuperCustomer scustomer = new SuperCustomer();

            //customer.ID = 1; cannot access protected
            //examples that are working
            scustomer.ID = 2;
            this.ID = 5;
            base.ID = 7;
            ID = 3;
            Console.WriteLine(this.ID); // printing 3, cuz ID = 3 is the last
        }
        
        
    }


}