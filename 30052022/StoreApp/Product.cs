using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp
{
    internal class Product
    {
        public Product(double price)
        {
            this.Price = price;
        }

        public string Brand;
        public string Name;
        public double Price;

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name} - Brand: {this.Brand} - Price: {this.Price}");
        }
    }
}
