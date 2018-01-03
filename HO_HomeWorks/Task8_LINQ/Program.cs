using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Утворити і заповнити колекцію з 10 цілих чисел
Отримати і вивести на консоль тільки від’ємні числа
Отримати і вивести на консоль тільки додатні парні числа
Отримати найбільший та найменший елементи з масиву, а також суму всіх елементів.
Отримати перший елемент з масиву, який є менший ніж середнє арифметичне значення елементів масиву
Посортувати масив з використанням OrderBy
*/

namespace Task8_LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create and fill in a collection with 10 numbers
            int[] intArray = { 1, 2, 3, -2, 8, 99, -100, 57, 33, 0};
            List<int> intList = new List<int>();
            foreach (int someInt in intArray)
            {
                intList.Add(someInt);
            }

            Console.WriteLine("GET ONLY NEGATIVE NUMBERS==================================");
            // Get negative numbers
            var negativeNumbers = from item in intList
                                  where item < 0
                                  select item;

            foreach (int i in negativeNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("GET ONLY POSITIVE PAIRED NUMBERS===========================");
            // Get only positive paired numbers
            var positivePairedNumbers = from item in intList
                        where item > 0 && item % 2 == 0
                        select item;

            foreach (int i in positivePairedNumbers)
            {
                Console.WriteLine(i);
            }

            // Get min and max element and a sum of all elements
            int maxValue = intList.Max();
            int minValue = intList.Min();
            int sum = intList.Aggregate(0, (acc , x) => acc + x);
            Console.WriteLine("Max value is " + maxValue + " and Min value is " + minValue);
            Console.WriteLine("The sum is {0}", sum);

            // TODO: 
            //Отримати перший елемент з масиву, який є менший ніж середнє арифметичне значення елементів масиву
            //Посортувати масив з використанням OrderBy
        }
    }
}
