using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Cleaner : Staff
    {
        private string room;

        override public string Name
        {
            get
            {
                return base.Name + "(Cleaner)";
            }
        }

        public Cleaner(string name, int salary, string room) : base(name, salary)
        {
            this.room = room;
        }

        override public void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1} and cleans room {2}", this.Name, this.Salary, this.room);
        }
    }
}
