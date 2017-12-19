using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ввести ціле число h , які представляють час доби (година ). 
Залежності від часу доби вивести привітання («Доброго ранку!», «Доброго дня!», «Доброго вечора!», «Доброї ночі!»)
*/

namespace Presentation3_Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = Convert.ToInt32(Console.ReadLine());
            string greeting = "Hello World!";
            if (hours > 0 && hours <= 6)
                greeting = "Good Night!";
            if (hours > 6 && hours <= 12)
                greeting = "Good Morning!";
            if (hours > 12 && hours <= 18)
                greeting = "Good Day!";
            if (hours > 18 && hours <= 24)
                greeting = "Good Evening!";
            Console.WriteLine(greeting);
            Console.ReadLine();
        }
    }
}
