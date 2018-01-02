using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTasks_Interfaces
{
    public class Person : ICloneable
    {
        public Person()
        {
            this.name = "Not Defined";
            this.age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private string name;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public object Clone()
        {
            Person newPerson = this;
            return newPerson;
        }

        public void Output()
        {
            Console.WriteLine("Name is {0}, age is {1}.", this.name, this.age);
        }
    }
}
