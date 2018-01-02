using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Задані натуральне число п і символи s_1,…,s_n, серед яких є двокрапка.
Переписати в інший список всі символи, розміщені між першою і другою двокрапкою.
Якщо другої двокрапки немає,то переписати всі символи, розміщені після єдиної двокрапки. 
Повторити з наступними двокрапками в тексті
*/

namespace AdditionalTask_Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestClass someObject = new TestClass("Oleg:You:Are:My:Friend", ':');
            someObject.DevideIntoStringByChar();
            someObject.Output();
            Console.ReadKey();
        }
    }
}
