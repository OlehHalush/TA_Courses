using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Person : IComparable
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        virtual public string Name
        {
            get
            {
                return this.name;
            }
        }

        virtual public void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }

        public int CompareTo(object somePerson)
        {
            if (somePerson == null)
            {
                return 1;
            }

            Person otherPerson = somePerson as Person;
            if (otherPerson != null)
            {
                return this.Name.CompareTo(otherPerson.Name);
            }
            else
            {
                throw new ArgumentException("Object is not a Person");
            }
        }

        public void GetInfoAboutExistingPerson(List<Person> myList)
        {
            Console.WriteLine("Enter some name:");
            string someName = Console.ReadLine();
            int counter = 0;
            foreach (Person item in myList)
            {
                if (item.Name == someName)
                {
                    item.Print();
                    counter += 1;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Such name doesn't exist.");
            }
        }
    }
}
