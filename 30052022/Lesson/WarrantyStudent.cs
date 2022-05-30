using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class WarrantyStudent : Student
    {
        public WarrantyStudent(string name,string surname,string groupNo):base(name,surname,groupNo)
        {

        }
        public string PrevGroupNo;
    }
}
