using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Square : Shape
    {
        public Square(string name, double side, double radius) : base(name)
        {
            this.Name = name;
            this.side = side;
            this.radius = radius;
        }

        private double side;
        private double radius;
        private double area;
        private double perimeter;

        public double Side
        {
            get
            {
                return this.side;
            }
            set
            {
                this.side = value;
            }
        }

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
            this.area = Math.Pow(this.side, 2);
            return this.area;
        }

        public override double GetPerimeter()
        {
            this.perimeter = 4 * this.radius;
            return this.perimeter;
        }
    }
}
