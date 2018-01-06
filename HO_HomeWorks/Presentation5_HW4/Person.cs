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
Then calculate and write to console the name and Age of each person; Change the name of persons, which Age is less then 16, to "Very Young".
Output information about all persons. 
Find and output information about Persons with the same names (use ==) 
*/

namespace Presentation5_HW4
{
    public class Person
    {
        public Person()
        {
            this.name = "Not Defined";
            this.birthYear = 0;
        }

        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        private string name;
        private int birthYear;
        private bool isNameDuplicated = false;

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

        public int BirthYear
        {
            get
            {
                return this.birthYear;
            }
        }

        public bool IsNameDuplicate
        {
            get
            {
                return this.isNameDuplicated;
            }

            set
            {
                this.isNameDuplicated = value;
            }
        }

        public int GetAge(int year)
        {
            int currentYear = Convert.ToInt32(DateTime.Today.Year);
            int age = currentYear - year;
            return age;
        }

        public void Input(string name, int year)
        {
            this.name = name;
            this.birthYear = year;
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            string userInfo = "User's name is " + this.name + " and age is " + this.GetAge(this.birthYear);
            return userInfo;
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public static bool operator ==(Person user1, Person user2)
        {
            if (user1.Name == user2.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Person user1, Person user2)
        {
            if (!(user1.Name == user2.Name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
