using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public abstract class Shape
    {

        public Shape(string name)
        {
            this.name = name;
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

        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
