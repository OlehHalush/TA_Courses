using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation6_Task5_2
{
    class TestClass
    {
        private List<int> myList = new List<int>();

        // Add 10 items into a list and output them to console
        public void InputNumbers()
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
                bool isNumber = int.TryParse(userInput, out int myInt);
                if (isNumber != true)
                {
                    Console.WriteLine("Please entered not a number.");
                }

                this.myList.Add(myInt);
                foreach (int item in this.myList)
                {
                    counter += 1;
                    if (counter == 10)
                    {
                        stayInLoop = false;
                    }
                }
            }
            while (stayInLoop == true);
        }

        // Output each item ina  list
        public void Output()
        {
            this.myList.ToArray();
            for (int i = 0; i < this.myList.Count; i++)
            {
                Console.WriteLine("Item with index '{0}' has value '{1}'.", i, this.myList[i]);
            }
        }

        // Remove values over 20 and output a new list
        public void RemoveValuesOver20()
        {
            for (int i = 0; i < this.myList.Count; i++)
            {
                if (this.myList[i] > 20)
                {
                    this.myList.Remove(this.myList[i]);
                    i--;
                }
            }
        }

        // Insert elements 1,-3,-4 in positions 2, 8, 5 and print collection
        public void InsertElements()
        {
            this.myList.Insert(2, 1);
            this.myList.Insert(7, -3);
            this.myList.Insert(5, -4);
        }

        public void GetSortedList()
        {
            this.myList.Sort();
        }
    }
}
