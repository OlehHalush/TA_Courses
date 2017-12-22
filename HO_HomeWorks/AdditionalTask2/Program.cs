using System;
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
            Country ukraine = new Country(1, "Ukraine", 603628, 42418235, Mainland.Europe);
            Country germany = new Country(2, "Germany", 357376, 80854000, Mainland.Europe);
            Country poland = new Country(3, "Poland", 312679, 37950000, Mainland.Europe);
            Country estonia = new Country(4, "Estonia", 45336, 1316000, Mainland.Europe);
            Country india = new Country(5, "India", 3287000, 1324000000, Mainland.Asia);
            Country afghanistan = new Country(6, "Afghanistan", 652864, 34660000, Mainland.Asia);
            Country gana = new Country(7, "Gana", 238535, 28210000, Mainland.Africa);
            Country kongo = new Country(8, "Kongo", 342000, 5126000, Mainland.Africa);
            Country samoa = new Country(9, "Samoa", 2831, 179000, Mainland.Australia);
            Country tonha = new Country(10, "Tonha", 748, 107122, Mainland.Australia);
            Country[] countriesArray = new Country[] { ukraine, germany, poland, estonia, india, afghanistan, gana, kongo, samoa, tonha };
        }
    }
}
