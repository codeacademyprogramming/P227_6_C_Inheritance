using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Employee : Human
    {

        public Employee(string name,string surname,string position):base(name,surname)
        {
            Position = position;
        }

        public string Position;
        public double Salary;
    }
}
