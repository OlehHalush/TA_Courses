using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public abstract class Shape : IComparable
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

        public int CompareTo(object shape)
        {
            if (shape == null)
            {
                return 1;
            }

            Shape otherShape = shape as Shape;
            if (otherShape != null)
            {
                return this.GetArea().CompareTo(otherShape.GetArea());
            }
            else
            {
                throw new ArgumentException("Object is not a Shape.");
            }
        }
    }
}
