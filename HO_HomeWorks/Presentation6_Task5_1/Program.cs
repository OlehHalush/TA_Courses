using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Develop interface IFlyable with method Fly().
Create two classes Bird (with fields: name and canFly) and Plane  (with fields: mark and highFly) , which implement interface IFlyable.
Create List of IFlyable objects and add some Birds and Planes to it. Call Fly() method for every item from the list of it. 
*/

namespace Presentation6_Task5_1
{
    public class Program
    {
        public void LetsGo()
        {
            List<IFlyable> myList = new List<IFlyable>();
            string userInput = string.Empty;
            do
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("Enter 'b' to create a bird or 'p' to create a plane.");
                Console.WriteLine("To exit enter 'e'.");
                userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "b":
                        {
                            Console.WriteLine("Please enter bird's name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Please specify can the bird fly? true/false");
                            string userValue = Console.ReadLine().ToLower();
                            bool isBoolean = bool.TryParse(userValue, out bool canFly);
                            if (isBoolean != true)
                            {
                                Console.WriteLine("Something went wrong. Looks like your bird can't fly.");
                                canFly = false;
                            }

                            myList.Add(new Bird(name, canFly));
                            break;
                        }

                    case "p":
                        {
                            Console.WriteLine("Please enter plane's mark:");
                            string name = Console.ReadLine();
                            Console.WriteLine("How high can your plane fly?");
                            string userValue = Console.ReadLine();
                            bool isInt = int.TryParse(userValue, out int height);
                            if (isInt != true)
                            {
                                Console.WriteLine("Something went wrong. Looks like your plane can't fly at all.");
                                height = 0;
                            }

                            myList.Add(new Plane(name, height));
                            break;
                        }

                    case "e":
                        {
                            userInput = "e";
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("You entered something wrong!");
                            break;
                        }
                }
            }
            while (userInput != "e");

            foreach (IFlyable item in myList)
            {
                item.Fly();
            }
        }

        public static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.LetsGo();
            Console.ReadKey();
        }
    }
}
