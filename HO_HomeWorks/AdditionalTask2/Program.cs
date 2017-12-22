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
    public enum Mainland
    {
        Europe,
        Asia,
        Africa,
        Australia,
        Antarctica,
        NorthAmerica,
        SouthAmerica
    }

    public class Country
    {
        public Country()
        {
        }

        public Country(int id, string name, long area, int population, Mainland mainland)
        {
            this.name = name;
            this.name = name;
            this.area = area;
            this.population = population;
            this.mainland = mainland;
        }

        private int id;

        public int ID
        {
            get
            {
                return this.id;
            }
        }

        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        private long area;

        public long Area
        {
            get
            {
                return this.area;
            }

            set
            {
                this.area = value;
            }
        }

        private int population;

        public int Population
        {
            get
            {
                return this.population;
            }

            set
            {
                this.population = value;
            }
        }

        private Mainland mainland;

        public Mainland Mainland
        {
            get
            {
                return this.mainland;
            }

            set
            {
                this.mainland = value;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
