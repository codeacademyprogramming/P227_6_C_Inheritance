using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    internal class Notebook:Product
    {
        public Notebook(double price):base(price)
        {

        }
        public string CPU;
        public int RAM;
        public int Storage;
    }
}
