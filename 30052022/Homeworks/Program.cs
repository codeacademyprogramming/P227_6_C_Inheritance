using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car
            {
                Brand = "Mercedes",
                Model = "E200",
                CurrentFuel = 20,
                FuelFor1Km = 0.7,
                Millage = 200
            };

            car.ShowInfo();
            car.Drive(10);
            car.ShowInfo();





            Console.WriteLine("Notebooklarin sayini daxil et:");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);


            Notebook[] notebooks = new Notebook[count];

            for (int i = 0; i < count; i++)
            {

                Console.WriteLine($"{i+1}. notebookun adi:");
                string name = Console.ReadLine();

                Console.WriteLine($"{i+1}. notebookun brand adi:");
                string brand = Console.ReadLine();

                Console.WriteLine($"{i+1}. notebookun qiymeti:");
                string priceStr = Console.ReadLine();
                double price = Convert.ToDouble(priceStr);

                notebooks[i] = new Notebook
                {
                    Name = name,
                    BrandName = brand,
                    Price = price
                };
            }


            Console.WriteLine("MinPrice deyerini daxil edin:");
            string minPriceStr = Console.ReadLine();
            double minPrice = Convert.ToDouble(minPriceStr);


            Console.WriteLine("MaxPrice deyerini daxil edin:");
            string maxPriceStr = Console.ReadLine();
            double maxPrice = Convert.ToDouble(maxPriceStr);


            foreach (var nb in notebooks)
            {
                if (nb.Price >= minPrice && nb.Price <= maxPrice)
                    nb.ShowInfo();
            }

        }

        
    }
}
