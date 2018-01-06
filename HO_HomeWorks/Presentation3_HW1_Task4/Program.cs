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
    public struct Dog
    {
        public string Name;
        public string Mark;
        public byte Age;

        public override string ToString()
        {
            string myString = "Dog's name is " + this.Name + ", mark is " + this.Mark + " and age is " + this.Age;
            return myString;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Console.WriteLine("Please enter dog's name:");
            myDog.Name = Console.ReadLine();
            Console.WriteLine("Please enter dog's mark:");
            myDog.Mark = Console.ReadLine();
            Console.WriteLine("Please enter dog's age:");
            myDog.Age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(myDog.ToString());
            Console.ReadKey();
        }
    }
}
