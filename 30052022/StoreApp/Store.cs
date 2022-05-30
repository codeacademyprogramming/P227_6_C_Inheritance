using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    internal class Store
    {
        public Store(int phoneCount)
        {
            this.Phones = new Phone[phoneCount];
        }
      
        public Phone[] Phones;
        public Notebook[] Notebooks;

        public void AddPhone(Phone phone)
        {

        }
    }
}
