using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukaa57_abstract2_
{
    abstract class BaseEmployee // we give it an abstract name so it couldnt be created (because it is then easy to broke the code)
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public void FullName()
        {
            Console.WriteLine($"{Name} {Surname}");
        }

        public abstract int MonthlySalary(); //virtuala się nadpisuje, ale tak samo abstract
        // lecz przy abstractcie nie trzeba wyrzucać notimplementedexception
    }
}
