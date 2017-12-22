using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create class Person.
Class Person should consists of:
a) two private fields: name and birthYear (the birthday year). (*As a type for this field you may use DataTime type.)
b) two properties for access to these fields (only get)
c) default constructor and constructor with 2 parameters 
d) methods:
 - Age() - to calculate the age of person
 -Input() - to input information about person
 -ChangeName() - to change the name of person
 -ToString() 
 -Output() - to output information about person (call ToString())
 - operator== (equal by name)

In the method Main() create 6 objects of Person type and input information about them.  
Then calculate and write to console the name and Age of each person; 
Change the name of persons, which Age is less then 16, to "Very Young".
Output information about all persons. 
Find and output information about Persons with the same names (use ==) 
*/

namespace Presentation5_HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("Oleg", 1989);
            Person person2 = new Person("Bogdan", 2000);
            Person person3 = new Person("Oleg", 1990);
            Person person4 = new Person("Roman", 1990);
            Person person5 = new Person("Oleg", 1988);
            Person person6 = new Person("Oleg", 2010);
            Person[] personsArray = new Person[] { person1, person2, person3, person4, person5, person6 };
            Console.WriteLine("Info about each person:");
            foreach (Person person in personsArray)
            {
                person.Output();
            }

            foreach (Person person in personsArray)
            {
                if (person.GetAge(person.BirthYear) < 16)
                {
                    person.Name = "Very Young";
                }
            }

            Console.WriteLine("Info about each persons after checking for persons younger than 16:");
            foreach (Person person in personsArray)
            {
                person.Output();
            }

            Console.WriteLine("Info about peoples with the same names:");
            for (int i = 0; i <= personsArray.Length - 1; i++)
            {
                string userName = personsArray[i].Name;
                for (int j = i + 1; j <= personsArray.Length - 1; j++)
                {
                    if (userName == personsArray[j].Name && personsArray[j].IsNameDuplicate == false)
                    {
                        personsArray[j].Output();
                        personsArray[j].IsNameDuplicate = true;
                        if (personsArray[i].IsNameDuplicate == false)
                        {
                            personsArray[i].Output();
                            personsArray[i].IsNameDuplicate = true;
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
