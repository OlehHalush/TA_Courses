using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_1_Interfaces_Collections
{
    public class Programmer : IDeveloper
    {
        public Programmer(string language)
        {
            this.language = language;
        }

        private string language;

        public string Tool
        {
            get
            {
                return this.language;
            }

            set
            {
                this.language = value;
            }
        }

        public void Create()
        {
            Console.WriteLine("Programmer has created a new program with {0} language.", this.Tool);
        }

        public void Destroy()
        {
            Console.WriteLine("Programmer has destroyed a program.");
        }
    }
}
