using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    class Student
    {
        private string name;
        private List<int> marks = new List<int>();
        public event MyDel MarksChanged;

        public void AddMark(int mark)
        {
            marks.Add(mark);
            if (MarksChanged != null)
            {
                MarksChanged(mark);
            }

        }
    }
}
