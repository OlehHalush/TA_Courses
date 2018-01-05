using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    public class AccountingDepartment
    {
        public void PayScholarship(int i)
        {
            if (i <= 2)
            {
                Console.WriteLine("No scolarship will be paid.");
            }

            if (i > 2)
            {
                Console.WriteLine("Scolarship will be paid.");
            }
        }
    }
}
