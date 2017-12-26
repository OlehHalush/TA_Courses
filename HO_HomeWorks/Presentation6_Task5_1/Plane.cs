using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation6_Task5_1
{
    public class Plane : IFlyable
    {
        private string mark;
        private int highFly;

        public Plane()
        {
            this.mark = "Not defined";
            this.highFly = 0;
        }

        public Plane(string mark, int highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine("The plane {0} flyies {1} km high.", this.mark, this.highFly);
        }
    }
}
