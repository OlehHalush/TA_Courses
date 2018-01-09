using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_1_Interfaces_Collections
{
    public class Builder : IDeveloper
    {
        public Builder(string tool)
        {
            this.tool = tool;
        }

        private string tool;
        private string language;

        public string Tool
        {
            get
            {
                return this.tool;
            }

            set
            {
                this.tool = value;
            }
        }

        public void Create()
        {
            Console.WriteLine("Builder has created a new program with {0} tool.", this.Tool);
        }

        public void Destroy()
        {
            Console.WriteLine("Builder has destroyed a program.");
        }
    }
}
