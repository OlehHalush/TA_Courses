using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Declare myColl of 10 integers and fill it from Console.
    1) Find and print all positions of element -10 in the collection
    2) Remove from collection elements, which are greater then 20. Print collection
    3) Insert elements 1,-3,-4 in positions 2, 8, 5. Print collection
    4) Sort and print collection 
Use next Collections for this tasks: List and ArrayList
*/

namespace Presentation6_Task5_2
{
    public class Program
    {
        private int myInt;
        private List<int> myList = new List<int>();

        public Program()
        {
            this.myInt = 0;
        }

        public Program(int myInt)
        {
            this.myInt = myInt;
        }

        // Add 10 items into a list and output them to console
        public void LetsGo()
        {

            string userInput = string.Empty;
            bool stayInLoop = true;
            Console.WriteLine("You have to enter 10 numbers.");
            do
            {
                int counter = 0;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Enter a number:");
                userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out this.myInt);
                if (isNumber != true)
                {
                    Console.WriteLine("Please entered not a number.");
                }

                myList.Add(this.myInt);
                foreach (int item in myList)
                {
                    counter += 1;
                    if (counter == 10)
                    {
                        stayInLoop = false;
                    }
                }
            }
            while (stayInLoop == true);
            Output();
        }

        // Output each item ina  list
        public void Output()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Your list contains next numbers:");
            myList.ToArray();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("Item with index '{0}' has value '{1}'.", i, myList[i]);
            }
        }

        // Remove values over 20 and output a new list
        // =====Exception is thrown after removal some items ina  list=====
        public void RemoveValuesOver20()
        {
            for (int i = 0; i <= myList.Count; i++)
            {
                if (myList[i] > 20)
                {
                    myList.Remove(myList[i]);
                }
            }
            Output();
        }

        // Insert elements 1,-3,-4 in positions 2, 8, 5 and print collection
        public void InsertElements()
        {
            myList.Insert(2, 1);
            myList.Insert(7, -3);
            myList.Insert(5, -4);
            Output();
        }

        public void GetSortedList()
        {
            myList.Sort();
            Output();
        }
        
        public static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.LetsGo();
            myProgram.RemoveValuesOver20();
            myProgram.InsertElements();
            myProgram.GetSortedList();
            Console.ReadKey();
        }
    }
}
