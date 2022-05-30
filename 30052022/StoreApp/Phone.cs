using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    internal class Phone:Product
    {
        public Phone(double price):base(price)
        {

        }
        public byte Camera;
        public byte SimCount;
    }
}
