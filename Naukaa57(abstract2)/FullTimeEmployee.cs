using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukaa57_abstract2_
{
    internal class FullTimeEmployee : BaseEmployee, Interface1
    {
        public int AnnualSalary { get; set; }

        public override int MonthlySalary()
        {
            return AnnualSalary / 12;
        }
    }
}
