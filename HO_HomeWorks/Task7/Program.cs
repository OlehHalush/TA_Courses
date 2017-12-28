using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1) Додайте два класи Person та Staff (використайте код з презентації)
2) Утворіть два класи Teacher та  Cleaner, похідні від Staff. Для класу Teaсher додайте поле subject, а для класу Cleaner – поле room, перевизначте метод Print для обох класів.
3) В Main  визначте список типу Person та додайте до нього об’єкти кожного типу. Викличте для кожного елементу списку метод Print()
4) Введіть ім’я персони і знайдіть чи є така персона у вашому списку, якщо так – видрукуйте про неї інформацію
5) Посортувати список за ім’ям, вивести в файл
6) Створити список Працівників і перемістити туди тільки працівників.
   - Посортувати їх за зарплатою.
*/

namespace Task7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person myPerson = new Person("Oleg");

            // Create list, add objects of each type and output it
            List<Person> myList = new List<Person>();
            myList.Add(myPerson);
            myList.Add(new Cleaner("Oksana", 25, "1002B"));
            myList.Add(new Staff("Ivan", 100));
            myList.Add(new Teacher("Olga", 50, "Math"));
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("List of persons:");
            foreach (Person item in myList)
            {
                item.Print();
            }

            // Enter name and if such name exists output the info
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Does such person exist?");
            myPerson.GetInfoAboutExistingPerson(myList);

            // Sort list by name and output it
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Sorted list:");
            myList.Sort();
            foreach (Person item in myList)
            {
                item.Print();
            }

            // To Do: implement IEnumerable interface for the last task
            List<Staff> myStaffList = new List<Staff>();
            foreach (Person item in myList)
            {
            }
        }
    }
}
