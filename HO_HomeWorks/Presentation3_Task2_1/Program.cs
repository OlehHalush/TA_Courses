using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Визначити перелічення TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted). 
Змінній test1Status присвоїти значення Pass і вивести значення змінної на консоль.
*/

namespace Presentation3_Task2_1
{
    enum TestCaseStatus : byte
    {
        Pass,
        Fail,
        Blocked,
        WP,
        Unexecuted
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
            Console.ReadLine();
        }
    }
}
