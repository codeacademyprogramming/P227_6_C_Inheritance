using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    internal class Notebook
    {
        public string Name;
        public string BrandName;
        public double Price;

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Brand: {BrandName} - Price: {Price}");
        }
    }
}
