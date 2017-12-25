using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2. Визначити тип для представлення країни. Кожна країна характеризується такими полями: 
- унікальним номером
- назвою
- площею поверхні
- кількістю населення
- материком, до якого належить країна. 
В класі визначити властивості доступу до полів, конструктор за замовчуванням та конструктори з параметрами,
перевизначити з класу object метод ToString, Equals, 
визначити методи введення та  виведення з консолі.
А)  Ввести дані про 10 країн. Вивести їх у такому форматі:
країна		площа		кільк. нас. 		материк
1		    755000 		55000000		    Європа
8		    43000		9000000		        Австралія
2		    516688		33300000		    Азія
Б) Видрукувати країни в порядку зростання номерів. Обчислити загальну кількість населення в країнах Європи.
B) Обчислити сумарну площу країн за материками
Г) Видрукувати країну з найбільшою кількістю населення
*/

namespace AdditionalTask2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int europianPopulation = 0;
            int maxPopulation = 0;
            string maxPopulationCountry = "Not defined";
            long areaEurope = 0;
            long areaAsia = 0;
            long areaAfrica = 0;
            long areaAustralia = 0;
            Country ukraine = new Country(10, "Ukraine", 603628, 42418235, Mainland.Europe);
            Country germany = new Country(2, "Germany", 357376, 80854000, Mainland.Europe);
            Country poland = new Country(3, "Poland", 312679, 37950000, Mainland.Europe);
            Country estonia = new Country(5, "Estonia", 453360, 13160000, Mainland.Europe);
            Country india = new Country(4, "India", 3287000, 1324000000, Mainland.Asia);
            Country afghanistan = new Country(6, "Afghan", 652864, 34660000, Mainland.Asia);
            Country gana = new Country(9, "Gana", 238535, 28210000, Mainland.Africa);
            Country kongo = new Country(8, "Kongo", 342000, 5126000, Mainland.Africa);
            Country samoa = new Country(7, "Samoa", 2831, 179000, Mainland.Australia);
            Country tonha = new Country(1, "Tonha", 748, 107122, Mainland.Australia);
            Country[] countriesArray = new Country[] { ukraine, germany, poland, estonia, india, afghanistan, gana, kongo, samoa, tonha };
            //Output not sorted list of countries
            Console.WriteLine("Not sorted list of countries:");
            Console.WriteLine("\tID\tCountry\tArea\tPopulation\tMainland");
            foreach (Country country in countriesArray)
            {
                country.Output();
            }
            //Output sorted by ID list of countries
            Console.WriteLine("Sorted list of countries by ID:");
            Console.WriteLine("\tID\tCountry\tArea\tPopulation\tMainland");
            foreach (Country country in countriesArray.OrderBy(Country => Country.ID))
            {
                country.Output();
            }
            //Output the population of Europian countries
            foreach (Country country in countriesArray)
            {
                if (country.Mainland == Mainland.Europe)
                {
                    europianPopulation += country.Population;
                }
            }

            Console.WriteLine("The population of Europian countries is: {0}", europianPopulation);
            //Output the area of countries in each mainland
            foreach (Country country in countriesArray)
            {
                switch (country.Mainland)
                {
                    case Mainland.Europe:
                        {
                            areaEurope += country.Area;
                            break;
                        }
                    case Mainland.Asia:
                        {
                            areaAsia += country.Area;
                            break;
                        }
                    case Mainland.Africa:
                        {
                            areaAfrica += country.Area;
                            break;
                        }
                    case Mainland.Australia:
                        {
                            areaAustralia += country.Area;
                            break;
                        }
                }
            }

            Console.WriteLine("The area of countries in Europe is {0}.", areaEurope);
            Console.WriteLine("The area of countries in Asia is {0}.", areaAsia);
            Console.WriteLine("The area of countries in Africa is {0}.", areaAfrica);
            Console.WriteLine("The are of countries in Australia is {0}.", areaAustralia);
            //Output the country with max population
            foreach (Country country in countriesArray)
            {
                if (country.Population > maxPopulation)
                {
                    maxPopulation = +country.Population;
                    maxPopulationCountry = country.Name;
                }
            }

            Console.WriteLine("The max population is: {0} in {1}.", maxPopulation, maxPopulationCountry);




            Console.ReadKey();
        }
    }
}
