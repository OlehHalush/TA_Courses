using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Teacher : Staff
    {
        private string subject;

        override public string Name
        {
            get
            {
                return base.Name + "(Teacher)";
            }
        }

        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            this.subject = subject;
        }

        override public void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1} and teaches {2}", this.Name, this.Salary, this.subject);
        }
    }
}
