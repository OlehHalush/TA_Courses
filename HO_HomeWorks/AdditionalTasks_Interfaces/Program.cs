using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Для розробленого раніше класу (напр. Doctor, Car, Person) реалізувати інтерфейс IClonable для клонування об’єктів.
Перевірити роботу методу Clone(), створюючи і клонуючи 10 об’єктів класу (використати конструктор для створення об’єкта лише 1 раз, решту об’єктів створити клонуванням)
*/

namespace AdditionalTasks_Interfaces
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> myListOfPersons = new List<Person>();
            Person myPerson = new Person("Oleg", 28);
            myListOfPersons.Add(myPerson);
            for (int i = 1; i < 11; i++)
            {
                myListOfPersons.Add((Person)myPerson.Clone());
            }

            foreach (Person somePerson in myListOfPersons)
            {
                somePerson.Output();
            }
        }
    }
}
