using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Human human2 = new Human("Hikmet", "Abbasov",45);


            Student student1 = new Student("Nezrin","Abbasova","P123")
            {
                Age = 18,
                Point = 69
            };

            Employee employee = new Employee("Abbas","Qulamov","Developer");

            WarrantyStudent wStudent2 = new WarrantyStudent("Abbas", "Nezerov", "P124");
            wStudent2.Age = 25;
            wStudent2.PrevGroupNo = "P123";
            wStudent2.Point = 88;


        }
    }
}
