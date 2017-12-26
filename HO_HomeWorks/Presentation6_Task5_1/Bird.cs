using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation6_Task5_1
{
    public class Bird : IFlyable
    {
        private string name;
        private bool canFly;

        public Bird()
        {
            this.name = "Not defined";
            this.canFly = false;
        }

        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }

        public void Fly()
        {
            string fly = string.Empty;
            if (this.canFly == true)
            {
                fly = "can";
            }
            else
            {
                fly = "can't";
            }

            Console.WriteLine("I'm {0} and I {1} fly.", this.name, fly);
        }
    }
}
