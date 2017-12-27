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
        public static void Main(string[] args)
        {
            TestClass myProgram = new TestClass();
            myProgram.InputNumbers();
            Console.WriteLine("===================================");
            Console.WriteLine("Your list contains numbers:");
            myProgram.Output();
            myProgram.RemoveValuesOver20();
            Console.WriteLine("===================================");
            Console.WriteLine("Your list after removal is:");
            myProgram.Output();
            myProgram.InsertElements();
            Console.WriteLine("===================================");
            Console.WriteLine("Your lsit after insert is:");
            myProgram.Output();
            myProgram.GetSortedList();
            Console.WriteLine("===================================");
            Console.WriteLine("This is your sorted list:");
            myProgram.Output();
            Console.ReadKey();
        }
    }
}
