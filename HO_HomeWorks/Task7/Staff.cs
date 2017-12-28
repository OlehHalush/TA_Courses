using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Staff : Person, IComparable
    {
        private int salary;

        public int Salary
        {
            get
            {
                return this.salary;
            }
        }

        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        override public string Name
        {
            get
            {
                return base.Name + "(Staff)";
            }
        }

        override public void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1}", this.Name, this.salary);
        }
    }
}
