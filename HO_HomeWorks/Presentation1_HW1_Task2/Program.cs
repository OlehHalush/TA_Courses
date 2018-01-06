using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create Console Application project in VS.
In method Main() write code for solving next tasks:
c) Define string variable name and integer value age.
Output question "What is your name?";
Read the value name and output next question: "How old are you,(name)?". 
Read age and write whole information  
*/

namespace Presentation1_HW1_Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you, {0}", name);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and you are {1} years old.", name, age);
            Console.ReadKey();
        }
    }
}
