using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.id = id;
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

        public override string ToString()
        {
            string myString = "Country's ID is " + this.id + ", name is " + this.name + ", area is " + this.area + ", population is " + this.population + ", mainland is " + this.mainland;
            return myString;
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public void Input(int id, string name, long area, int population, Mainland mainland)
        {
            this.name = name;
            this.name = name;
            this.area = area;
            this.population = population;
            this.mainland = mainland;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Country checkedCountry = obj as Country;
            return this.mainland == checkedCountry.mainland;
        }
    }
}
