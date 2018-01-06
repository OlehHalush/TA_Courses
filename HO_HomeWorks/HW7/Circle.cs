using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Circle : Shape
    {
        public Circle(string name, double radius) : base(name)
        {
            this.Name = name;
            this.radius = radius;
        }

        public const double Pi = 3.14;
        private double radius;
        private double area;
        private double perimeter;

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                this.radius = value;
            }
        }

        public double Area
        {
            get
            {
                return this.area;
            }
        }

        public double Perimeter
        {
            get
            {
                return this.perimeter;
            }
        }

        public override double GetArea()
        {
            this.area = Pi * Math.Pow(this.radius, 2);
            return this.area;
        }

        public override double GetPerimeter()
        {
            this.perimeter = 2 * Pi * this.radius;
            return this.perimeter;
        }
    }
}
