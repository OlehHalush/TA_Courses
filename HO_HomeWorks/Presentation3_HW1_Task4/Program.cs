using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create Console Application project in VS.
In method Main() write code for solving next task:
d) declare struct Dog with fields Name, Mark, Age. Declare variable myDog of Dog type and read values for it.
Output myDog into console. (Declare method ToString in struct)
*/

namespace Presentation3_HW1_Task4
{
    struct Dog
    {
        public string name;
        public string mark;
        public byte age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Console.WriteLine("Please enter dog's name:");
            myDog.name = Console.ReadLine();
            Console.WriteLine("Please enter dog's mark:");
            myDog.mark = Console.ReadLine();
            Console.WriteLine("Please enter dog's age:");
            myDog.age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Dog's name is {0}, mark is {1} and age is {2}", myDog.name, myDog.mark, myDog.age);
            Console.ReadKey();
        }
    }
}
