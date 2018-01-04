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
            // Create and fill in a collection with 10 numbers and output it
            int[] intArray = { 1, 2, 3, -2, 8, 99, -100, 57, 33, 0 };
            List<int> intList = new List<int>();
            Console.WriteLine("GET MY LIST================================================");
            int counter = 0;
            foreach (int someInt in intArray)
            {
                intList.Add(someInt);
            }

            foreach (int item in intList)
            {
                if (counter < intList.Count - 1)
                {
                    Console.Write("{0}, ", intList[counter]);
                    counter += 1;
                }

                if (counter == intList.Count - 1)
                {
                    Console.WriteLine("{0}.", intList[counter]);
                    counter += 1;
                }
            }

            Console.WriteLine("\nGET ONLY NEGATIVE NUMBERS==================================");

            // Get negative numbers
            var negativeNumbers = from item in intList
                                  where item < 0
                                  select item;
            foreach (int i in negativeNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nGET ONLY POSITIVE PAIRED NUMBERS===========================");

            // Get only positive paired numbers
            var positivePairedNumbers = from item in intList
                                        where item > 0 && item % 2 == 0
                                        select item;
            foreach (int i in positivePairedNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nGET MIN & MAX VALUES AND A SUM OF ALL ELEMENTS=============");

            // Get min and max element and a sum of all elements
            int maxValue = intList.Max();
            int minValue = intList.Min();
            int sum = intList.Aggregate(0, (acc, x) => acc + x);
            Console.WriteLine("Max value is " + maxValue + " and Min value is " + minValue);
            Console.WriteLine("The sum is {0}", sum);

            Console.WriteLine("\nGET AVERAGE VALUE AND FIRST ELEMENT LESS THEN AVERAGE======");

            // Get first element that is less then average
            double average = intList.Average();
            double firstValueLessThenAverage = intList.First(valueLessThenAverage => valueLessThenAverage < average);
            Console.WriteLine("Average value is '{0}' and the first value less then average is '{1}'", average, firstValueLessThenAverage);

            Console.WriteLine("\nGET SORTED LIST============================================");

            // Get sorted list
            foreach (int item in intList.OrderBy(c => c))
            {
                Console.WriteLine(item);
            }

        }
    }
}
