using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_1_Interfaces_Collections
{
    public interface IDeveloper
    {
        string Tool { get; set; }

        void Create();

        void Destroy();
    }
}
