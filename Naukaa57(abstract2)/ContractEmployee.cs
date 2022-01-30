using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukaa57_abstract2_
{
    internal class ContractEmployee : BaseEmployee, Interface1
    {
        public int PayForHour { get; set; }
        public int TotalHours { get; set; }

        public override int MonthlySalary()
        {
            return PayForHour * TotalHours / 12;
        }
    }
}
