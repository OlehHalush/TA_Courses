using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Output question “How are you?“. 
Define string variable answer.
Read the value answer and output: “You are (answer)". 
*/

namespace Presentation1_Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine("You are {0}.", answer);
            Console.ReadKey();
        }
    }
}
